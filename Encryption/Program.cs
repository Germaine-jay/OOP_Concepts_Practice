using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    internal class Program
    {
        public string message;

        public string Message;
        public char[] Alpha
        {
            get
            {
                string Alphabets = (@"abcdefghijklmnopqrstuvwxyz");
                return Alphabets.ToCharArray();
            }

        }
        public char[] Code
        {
            get
            {
                string keys = (@"!@#$%^&*()_+-?|`/}{][><~=\");
                return keys.ToCharArray();
            }
        }

        public Dictionary<char, char> encryption = new Dictionary<char, char>();

        public string Encode(string word)
        {

            for (int i = 0; i < Code.Length; i++)
            {
                encryption.Add(Alpha[i],Code[i]);
            }

            foreach (var whiteSpace in word)
            {
                if (char.IsWhiteSpace(whiteSpace))
                { Message += whiteSpace; }

                foreach (var letter in encryption)
                {
                    if ((letter.Key).ToString().Contains(whiteSpace))
                    { Message += letter.Value; }
                }
            }
            return Message;
        }

        public string Decode(string encodedWord)
        {
            foreach (var wordKey in encodedWord)
            {
                if (char.IsWhiteSpace(wordKey))
                { message += wordKey; }

                foreach (var letter in encryption)
                {
                    if ((letter.Value).ToString().Contains(wordKey))
                    { message += letter.Key; }
                }
            }
            return message;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter any sentence");
            var sentence = Console.ReadLine();

            int value;
            if (int.TryParse(sentence, out value) == true || string.IsNullOrEmpty(sentence))
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

