namespace VersionAttribute
{
    using System;

    // Multiuse attribute.
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]  // Multiuse attribute.
    public class Author : Attribute
    {
        string name;
        public double version;

        public Author(string name)
        {
            this.name = name;

            // Default value.
            version = 1.0;
        }

        public string GetName()
        {
            return name;
        }
    }
}
