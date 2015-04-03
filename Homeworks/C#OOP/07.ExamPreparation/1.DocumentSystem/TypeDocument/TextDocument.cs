namespace _1.DocumentSystem.TypeDocument
{
    public class TextDocument : Document, IDocument, IEditable
    {
        public TextDocument(string name, string content = null, string charset = null)
            : base(name, content)
        {
            this.Charset = charset;
        }

        public string Charset { get; private set; }

        public override void LoadProperty(string key, string value)
        {
            if (key.ToLower() == "charset")
            {
                this.Charset = value;
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public void ChangeContent(string newContent)
        {
            this.Content = newContent;
        }
    }
}
