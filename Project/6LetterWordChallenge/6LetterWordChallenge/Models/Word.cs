using System;
using System.Collections.Generic;
using System.Text;

namespace _6LetterWordChallenge
{
    public class Word
    {
        public string Text { get; set; }
        public int Length { get; set; }

        public Word(string line)
        {
            Text = line;
            Length = line.Length;
        }
    }
}
