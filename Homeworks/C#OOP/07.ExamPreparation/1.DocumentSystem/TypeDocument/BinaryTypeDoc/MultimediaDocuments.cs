namespace _1.DocumentSystem.TypeDocument.BinaryTypeDoc
{
    public abstract class MultimediaDocuments : BinaryDocument, IDocument
    {
        public MultimediaDocuments(string name, string content = null, int size = 0, int length = 0)
            : base(name, content, size)
        {
            this.Length = length;
        }

        public int Length { get; private set; }

        public override void LoadProperty(string key, string value)
        {
            if (key.ToLower() == "length")
            {
                this.Length = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }
    }
}
