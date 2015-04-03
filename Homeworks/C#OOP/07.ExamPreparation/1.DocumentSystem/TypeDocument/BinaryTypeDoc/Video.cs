namespace _1.DocumentSystem.TypeDocument.BinaryTypeDoc
{
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
    }
}
