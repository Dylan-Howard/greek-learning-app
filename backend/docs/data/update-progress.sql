-- When user completes a lesson
UPDATE user_progress
SET 
  completed_lesson_ids = array_append(completed_lesson_ids, $lesson_id),
  grammatical_feature_progress = grammatical_feature_progress || $new_gram_progress,
  syntactical_feature_progress = syntactical_feature_progress || $new_syn_progress,
  vocabulary_progress = vocabulary_progress || $new_vocab_progress,
  updated_at = NOW()
WHERE user_id = $user_id;

-- Example $new_gram_progress JSONB:
-- { "5": { "mastery_level": 85, "needs_practice": false, "last_practiced": "2025-02-06T10:00:00Z" } }