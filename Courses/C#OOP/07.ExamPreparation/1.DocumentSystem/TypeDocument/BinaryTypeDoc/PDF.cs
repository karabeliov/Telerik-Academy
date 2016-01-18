namespace _1.DocumentSystem.TypeDocument.BinaryTypeDoc
{
    using System.Collections.Generic;
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

        public override void SaveAllProperties(System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<string, object>> output)
        {
            if (NPages != 0)
            {
                output.Add(new KeyValuePair<string, object>("pages", this.NPages));
            }

            base.SaveAllProperties(output);
        }
    }
}
