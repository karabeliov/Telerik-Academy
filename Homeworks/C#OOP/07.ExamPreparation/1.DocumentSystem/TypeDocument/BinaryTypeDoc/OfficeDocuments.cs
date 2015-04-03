namespace _1.DocumentSystem.TypeDocument.BinaryTypeDoc
{
    public abstract class OfficeDocuments : EncryptableDocuments, IDocument, IOffice, IEncryptable
    {
        public OfficeDocuments(string name, string content = null, int size = 0, string version = null)
            : base(name, content, size)
        {
            this.Version = version;
        }

        public string Version { get; private set; }

        public bool IsEncrypted
        {
            get { throw new System.NotImplementedException(); }
        }

        public override void LoadProperty(string key, string value)
        {
            if (key.ToLower() == "version")
            {
                this.Version = value;
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }
    }
}
