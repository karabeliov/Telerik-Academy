namespace _1.DocumentSystem.TypeDocument.BinaryTypeDoc
{
    using System.Collections.Generic;
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

        public override void SaveAllProperties(System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<string, object>> output)
        {
            if (SampleRate != 0)
            {
                output.Add(new KeyValuePair<string, object>("samplerate", this.SampleRate));
            }
            
            base.SaveAllProperties(output);
        }
    }
}
