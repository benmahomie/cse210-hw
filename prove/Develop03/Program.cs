// Add 3 scriptures

Reference godSoLovedR = new Reference("John", 3, 16, 17);
Reference jesusWeptR = new Reference("John", 11, 35);
Reference nehpisCourageR = new Reference("1 Nephi", 3, 7);

Scripture godSoLoved = new Scripture(godSoLovedR, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
Scripture jesusWept = new Scripture(jesusWeptR, "Jesus wept.");
Scripture nehpisCourage = new Scripture(nehpisCourageR, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");

godSoLoved.PresentScripture();
jesusWept.PresentScripture();
nehpisCourage.PresentScripture();