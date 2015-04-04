namespace _1.DocumentSystem.TypeDocument.BinaryTypeDoc
{
    using System.Collections.Generic;
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

        public override void SaveAllProperties(System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<string, object>> output)
        {
            if (Length != 0)
            {
                output.Add(new KeyValuePair<string, object>("length", this.Length));
            }

            base.SaveAllProperties(output);
        }
    }
}
