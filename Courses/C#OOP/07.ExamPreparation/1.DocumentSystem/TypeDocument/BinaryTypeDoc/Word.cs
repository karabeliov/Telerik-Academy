namespace _1.DocumentSystem.TypeDocument.BinaryTypeDoc
{
    using System.Collections.Generic;
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

        public override void SaveAllProperties(System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<string, object>> output)
        {
            if (NCharacters != 0)
            {
                output.Add(new KeyValuePair<string, object>("chars", this.NCharacters));
            }

            base.SaveAllProperties(output);
        }
    }
}
