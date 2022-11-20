using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    internal class Program
    {
        private string EncodedMessage;

        private string DecodedMessage;
        private char[] Alpha
        {
            get
            {
                string Alphabets = (@"abcdefghijklmnopqrstuvwxyz");
                return Alphabets.ToCharArray();
            }

        }
        private char[] Code
        {
            get
            {
                string keys = (@"!@#$%^&*()_+-?|`/}{][><~=\");
                return keys.ToCharArray();
            }
        }

        private Dictionary<char, char> Encryption = new Dictionary<char, char>();

        public string Encode(string word)
        {

            for (int i = 0; i < Code.Length; i++)
            {
                Encryption.Add(Alpha[i],Code[i]);
            }

            foreach (var whiteSpace in word)
            {
                if (char.IsWhiteSpace(whiteSpace))
                { EncodedMessage += whiteSpace; }

                foreach (var letter in Encryption)
                {
                    if ((letter.Key).ToString().Contains(whiteSpace))
                    { EncodedMessage += letter.Value; }
                }
            }
            return EncodedMessage;
        }

        public string Decode(string encodedWord)
        {
            foreach (var wordKey in encodedWord)
            {
                if (char.IsWhiteSpace(wordKey))
                { DecodedMessage += wordKey; }

                foreach (var letter in Encryption)
                {
                    if ((letter.Value).ToString().Contains(wordKey))
                    { DecodedMessage += letter.Key; }
                }
            }
            return DecodedMessage;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter any sentence");
            var sentence = Console.ReadLine();

            if (int.TryParse(sentence, out _)  || string.IsNullOrEmpty(sentence))
            {
                Console.WriteLine("invalid input");
            }
            else
            {
                Program New = new Program();
                var Encoded = New.Encode(sentence);
                var decoded = New.Decode(Encoded);
                Console.WriteLine(Encoded);
                Console.WriteLine(decoded);
            }
        }
    }
}

