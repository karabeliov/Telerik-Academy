namespace _1.DocumentSystem.TypeDocument.BinaryTypeDoc
{
    public class PDF : EncryptableDocuments, IDocument, IEncryptable
    {
        public PDF(string name, string content = null, int size = 0, int nPages = 0)
            :base(name, content, size)
        {
            this.NPages = nPages;
        }

        public int NPages { get; private set; }

        public override void LoadProperty(string key, string value)
        {
            if (key.ToLower() == "pages")
            {
                this.NPages = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }
    }
}
