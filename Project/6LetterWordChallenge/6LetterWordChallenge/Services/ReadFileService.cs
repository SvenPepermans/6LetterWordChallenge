using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace _6LetterWordChallenge.Services
{
    public class ReadFileService : IReadFileService
    {
        
        public ReadFileService()
        {

        }
     
        public async Task<List<Word>> ReadWordsFromFile(string fileUrl)
        {
            using (StreamReader file = new StreamReader(fileUrl))
            {
                List<Word> words = new List<Word>();
                string line;
                while((line = await file.ReadLineAsync()) != null)
                {
                    words.Add(new Word(line));
                }
                file.Close();
                return words;
            }
        }
    }
}
