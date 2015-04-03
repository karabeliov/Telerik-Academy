namespace _1.DocumentSystem.TypeDocument.BinaryTypeDoc
{
    public class Word : OfficeDocuments, IDocument, IOffice, IEditable, IEncryptable
    {
        public Word(string name, string content = null, int size = 0, string version = null, int nCharacters = 0)
            : base(name, content, size, version)
        {
            this.NCharacters = nCharacters;
        }

        public int NCharacters { get; private set; }

        public void ChangeContent(string newContent)
        {
            this.Content = newContent;
        }

        public override void LoadProperty(string key, string value)
        {
            if (key.ToLower() == "chars")
            {
                this.NCharacters = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }
    }
}
