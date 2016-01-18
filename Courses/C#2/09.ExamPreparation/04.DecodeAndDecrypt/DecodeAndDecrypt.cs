using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class DecodeAndDecrypt
{
    static void Main()
    {
        // Console.WriteLine(Decode("KKICXDE3P5") == ("KKICXDEPPP")); // Test Method
        string input = Console.ReadLine();

        string digits = string.Empty;

        for (int i = input.Length - 1; i >= 0; i--)
        {
            if (char.IsDigit(input[i]))
            {
                digits = input[i] + digits;
            }
            else
            {
                break;
            }
        }

        int lengthCypher = int.Parse(digits);

        string encodedMessagage = input.Substring(0, input.Length - digits.Length);

        string decodedMessagage = Decode(encodedMessagage);

        var encryptedMessage = decodedMessagage.Substring(0, decodedMessagage.Length - lengthCypher);

        var cypher = decodedMessagage.Substring(decodedMessagage.Length - lengthCypher);

        string message = Encrypt(encryptedMessage, cypher);

        Console.WriteLine(message);
    }

    private static string Encrypt(string encryptedMessage, string cypher)
    {
        StringBuilder message = new StringBuilder(encryptedMessage);

        var steps = Math.Max(encryptedMessage.Length, cypher.Length); 
        for (int step = 0; step < steps; step++)
        {
            var messageIndex = step % encryptedMessage.Length;
            var cypherIndex = step % cypher.Length;

            message[messageIndex] = (char)(((message[messageIndex] - 'A') ^ (cypher[cypherIndex] - 'A')) + 'A');
        }

        return message.ToString();
    }

    private static string Decode(string encodedMessagage) 
    {
        StringBuilder decode = new StringBuilder();
        int count = 0;
        for (int i = 0; i < encodedMessagage.Length; i++)
        {
            if (char.IsDigit(encodedMessagage[i]))
            {
                count *= 10;
                count += encodedMessagage[i] - '0';
            }
            else
            {
                if (count == 0)
                {
                    decode.Append(encodedMessagage[i]);
                }
                else
                {
                    decode.Append(encodedMessagage[i], count);
                    count = 0;
                }
            }
        }

        return decode.ToString();
    }
}