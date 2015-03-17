namespace StringBuilderSubstring
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class StringBuilderSubstring
    {
        public static StringBuilder Substring(this StringBuilder builder, int index, int length)
        {
            StringBuilder result = new StringBuilder(length);

            for (int i = index; i <= index + length; i++)
            {
                result.Append(builder[i]);
            }

            return result;
        }
    }
}
