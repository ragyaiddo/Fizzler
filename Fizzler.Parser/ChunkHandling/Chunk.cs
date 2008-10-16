namespace Fizzler.Parser.ChunkHandling
{
	public class Chunk
	{
		public AttributeSelectorData AttributeSelectorData { get; set; }
		public ChunkType ChunkType { get; set; }
		public string Body { get; set; }
		public DescendantSelectionType DescendantSelectionType { get; set; }
		public string PseudoclassData { get; set; }

		public Chunk(ChunkType chunkType, string body, DescendantSelectionType descendantSelectionType, string pseudoclassData, AttributeSelectorData attributeSelectorData)
		{
			AttributeSelectorData = attributeSelectorData;
			ChunkType = chunkType;
			Body = body;
			DescendantSelectionType = descendantSelectionType;
			PseudoclassData = pseudoclassData;
		}
	}
}