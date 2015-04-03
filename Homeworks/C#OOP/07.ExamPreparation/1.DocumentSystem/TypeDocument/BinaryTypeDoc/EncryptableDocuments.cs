namespace _1.DocumentSystem.TypeDocument.BinaryTypeDoc
{
    public abstract class EncryptableDocuments : BinaryDocument, IDocument, IEncryptable
    {
        public EncryptableDocuments(string name, string content = null, int size = 0)
            : base(name, content, size)
        {
            this.IsEncrypted = false;
        }

        public bool IsEncrypted { get; private set; }

        public void Encrypt()
        {
            this.IsEncrypted = true;
        }

        public void Decrypt()
        {
            this.IsEncrypted = false;
        }
    }
}
