namespace _1.DocumentSystem.TypeDocument.BinaryTypeDoc
{
    using System.Collections.Generic;
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

        public override void SaveAllProperties(System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<string, object>> output)
        {
            if (Version != null)
            {
                output.Add(new KeyValuePair<string, object>("version", this.Version));
            }

            base.SaveAllProperties(output);
        }
    }
}
