-- Single query to get everything needed for rendering
WITH user_data AS (
  SELECT 
    up.grammatical_feature_progress,
    up.syntactical_feature_progress,
    up.vocabulary_progress,
    up.completed_lesson_ids
  FROM user_progress up
  WHERE up.user_id = $1
),
chapter_data AS (
  SELECT 
    c.unit_tree,
    c.title
  FROM chapters c
  WHERE c.book_id = $2 AND c.chapter_index = $3
),
translation_data AS (
  SELECT 
    tu.original_unit_path,
    tu.translated_text,
    tu.display_order
  FROM translation_units tu
  JOIN translations t ON t.id = tu.translation_id
  WHERE t.book_id = $2 
    AND tu.chapter_id = (SELECT id FROM chapters WHERE book_id = $2 AND chapter_index = $3)
    AND t.language_code = $4 -- User's target language
  ORDER BY tu.display_order
)
SELECT 
  cd.unit_tree,
  cd.title,
  ud.grammatical_feature_progress,
  ud.syntactical_feature_progress,
  ud.vocabulary_progress,
  ud.completed_lesson_ids,
  json_agg(
    json_build_object(
      'path', td.original_unit_path,
      'text', td.translated_text,
      'order', td.display_order
    )
  ) as translations
FROM chapter_data cd
CROSS JOIN user_data ud
LEFT JOIN translation_data td ON true
GROUP BY cd.unit_tree, cd.title, ud.grammatical_feature_progress, 
         ud.syntactical_feature_progress, ud.vocabulary_progress, ud.completed_lesson_ids;