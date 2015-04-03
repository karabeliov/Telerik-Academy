namespace _1.DocumentSystem.TypeDocument.BinaryTypeDoc
{
    public class Audio : MultimediaDocuments, IDocument
    {
        public Audio(string name, string content = null, int size = 0, int length = 0, double sampleRate = 0.0)
            : base(name, content, size, length)
        {
            this.SampleRate = sampleRate;
        }

        public double SampleRate { get; private set; }

        public override void LoadProperty(string key, string value)
        {
            if (key.ToLower() == "samplerate")
            {
                this.SampleRate = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }
    }
}
