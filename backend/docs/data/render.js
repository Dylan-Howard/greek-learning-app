function renderChapter(userId, bookId, chapterIndex, targetLang = 'en') {
  // 1. Fetch all data in ONE query
  const data = await db.query(OPTIMIZED_QUERY, [userId, bookId, chapterIndex, targetLang]);
  
  const {
    unit_tree,
    grammatical_feature_progress,
    syntactical_feature_progress,
    vocabulary_progress,
    translations
  } = data;
  
  // 2. Build translation lookup map (O(1) access)
  const translationMap = new Map(
    translations.map(t => [t.path, { text: t.text, order: t.order }])
  );
  
  // 3. Recursive rendering with BFS-style traversal
  const rendered = [];
  
  for (const unit of unit_tree) {
    rendered.push(renderUnit(unit, translationMap, {
      grammatical_feature_progress,
      syntactical_feature_progress,
      vocabulary_progress
    }));
  }
  
  return rendered;
}

function renderUnit(unit, translationMap, progress) {
  if (unit.type === 'meta') {
    return { type: 'meta', content: unit.content, marker: unit.marker };
  }
  
  // Check if user knows all features
  const knowsGrammar = unit.gram_feature_ids?.every(id => 
    progress.grammatical_feature_progress[id]?.mastery_level >= 70
  ) ?? true;
  
  const knowsSyntax = unit.syn_feature_ids?.every(id =>
    progress.syntactical_feature_progress[id]?.mastery_level >= 70
  ) ?? true;
  
  const knowsVocab = unit.vocab_id 
    ? (progress.vocabulary_progress[unit.vocab_id]?.mastery_level >= 70)
    : true;
  
  const needsPractice = 
    unit.gram_feature_ids?.some(id => progress.grammatical_feature_progress[id]?.needs_practice) ||
    unit.syn_feature_ids?.some(id => progress.syntactical_feature_progress[id]?.needs_practice) ||
    (unit.vocab_id && progress.vocabulary_progress[unit.vocab_id]?.needs_practice);
  
  // Decision tree
  if (!knowsSyntax && unit.children) {
    // Don't expand, show translation
    return {
      type: 'translated',
      text: translationMap.get(unit.path)?.text || unit.translation,
      original: unit.root
    };
  }
  
  if (knowsSyntax && unit.children) {
    // Expand and render children
    const children = unit.children.map(child => 
      renderUnit(child, translationMap, progress)
    );
    
    // Reorder based on translation display_order
    const reordered = reorderByTranslation(children, translationMap, unit.path);
    
    return {
      type: 'expanded',
      children: reordered
    };
  }
  
  // Leaf node (word)
  if (knowsGrammar && knowsVocab && !needsPractice) {
    // Show original Greek
    return {
      type: 'original',
      text: unit.root,
      vocab_id: unit.vocab_id
    };
  }
  
  if (needsPractice) {
    // Show with parsing hints
    const hints = buildParsingHints(unit, progress);
    return {
      type: 'original_with_hints',
      text: unit.root,
      hints: hints, // e.g., "[N, NMS]"
      vocab_id: unit.vocab_id
    };
  }
  
  // Show translation
  return {
    type: 'translated',
    text: translationMap.get(unit.path)?.text || unit.translation,
    original: unit.root
  };
}

function buildParsingHints(unit, progress) {
  const hints = [];
  
  if (unit.gram_feature_ids) {
    // Only show features that need practice
    for (const id of unit.gram_feature_ids) {
      if (progress.grammatical_feature_progress[id]?.needs_practice) {
        hints.push(getFeatureCode(id)); // e.g., "NMS"
      }
    }
  }
  
  return hints;
}