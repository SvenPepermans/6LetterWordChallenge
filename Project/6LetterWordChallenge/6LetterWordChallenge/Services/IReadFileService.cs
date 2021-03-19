using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace _6LetterWordChallenge.Services
{
    public interface IReadFileService
    {
        Task<List<Word>> ReadWordsFromFile(string file);
    }
}
