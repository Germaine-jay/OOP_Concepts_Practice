using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pig_latin
{
    internal class Program
    {
        public string pig_latin;

        public string newWord;

        public string pigLatin(string wordsInEnglish)
        {
            foreach (string word in wordsInEnglish.Split())
            {
                var NewWord = word.Substring(1) + word.Substring(0, 1);
                pig_latin += NewWord + "ay" + " ";
            }
            return pig_latin;

        }
        public string english(string wordsInpigLatin)
        {
            foreach (string word in wordsInpigLatin.Split())
            {
                string word2 = word.Replace("ay", "");
                var len = word2.Length;
                var NewWord2 = word2.Substring(len - 1, 1) + word2.Substring(0, len - 1);
                newWord += NewWord2 + " ";
            }
            return newWord;
        }

        static void Main(string[] args)
        {
            Program New = new Program();

            Console.WriteLine("Enter 1 to convert to pig latin or 2 to convert to english");
            var option = int.Parse(Console.ReadLine());
            if(option == 1 )
            {
                Console.WriteLine("Enter a sentence in english");
                var sentence = Console.ReadLine();

                string sentenceInEnglish = New.pigLatin(sentence);
                Console.WriteLine(sentenceInEnglish);
            }
            else
            {
                Console.WriteLine("Enter a sentence in piglatin");
                var sentence = Console.ReadLine();
                string sentenceInPigLatin = New.english(sentence);
                Console.WriteLine(sentenceInPigLatin);
            }
        }
    }
}
