namespace _1.DocumentSystem.TypeDocument
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public abstract class Document : IDocument
    {
        // protected IList<KeyValuePair<string, object>> properties = new IList<KeyValuePair<string, object>>;
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

        public virtual void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            if (Name != null)
            {
                output.Add(new KeyValuePair<string, object>("name", this.Name));
            }

            if (Content != null)
            {
                output.Add(new KeyValuePair<string, object>("content", this.Content));
            }
        }

        public override string ToString()
        {
            var list = new List<KeyValuePair<string, object>>();
            this.SaveAllProperties(list);

            var props = list.OrderBy(k => k.Key).Select(k => string.Format("{0}={1}", k.Key, k.Value));

            return string.Format("{0}[{1}]", this.GetType().Name, string.Join(";", props));
        }
    }
}
