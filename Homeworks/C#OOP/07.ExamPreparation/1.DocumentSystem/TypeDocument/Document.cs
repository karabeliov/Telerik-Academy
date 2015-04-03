namespace _1.DocumentSystem.TypeDocument
{
    using System.Collections.Generic;
    public abstract class Document : IDocument
    {
        public Document(string name, string content = null)
        {
            this.Name = name;
            this.Content = content;
        }

        public string Name { get; private set; }

        public string Content { get; protected set; }

        public virtual void LoadProperty(string key, string value)
        {
            key = key.ToLower();
            if (key == "name")
            {
                this.Name = value;
            }
            else if (key == "content")
            {
                this.Content = value;
            }
        }

        public virtual void SaveAllProperties(IList<System.Collections.Generic.KeyValuePair<string, object>> output)
        {
            throw new System.NotImplementedException();
        }
    }
}
