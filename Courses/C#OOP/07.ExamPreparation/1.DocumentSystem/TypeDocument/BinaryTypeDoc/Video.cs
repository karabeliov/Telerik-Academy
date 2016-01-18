namespace _1.DocumentSystem.TypeDocument.BinaryTypeDoc
{
    using System.Collections.Generic;
    public class Video : MultimediaDocuments, IDocument
    {
        public Video(string name, string content = null, int size = 0, int length = 0, int frameRate = 0)
            : base(name, content, size, length)
        {
            this.FrameRate = frameRate;
        }

        public int FrameRate { get; private set; }

        public override void LoadProperty(string key, string value)
        {
            if (key.ToLower() == "framerate")
            {
                this.FrameRate = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<string, object>> output)
        {
            if (FrameRate != 0)
            {
                output.Add(new KeyValuePair<string, object>("framerate", this.FrameRate));
            }

            base.SaveAllProperties(output);
        }
    }
}
