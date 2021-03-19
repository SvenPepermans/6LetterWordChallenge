using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6LetterWordChallenge.Services
{
    public class CombinationService : ICombinationService
    {
        public CombinationService()
        {

        }

        public void CombineWords(List<Word> listOfWords)
        {
            List<string> newWords = new List<string>();
            List<Word> targetWords = FindTargetWords(listOfWords);
            foreach(var word in listOfWords)
            {               
                string newWord = word.Text;
                if (word.Length != 6)
                {
                    foreach( var anotherWord in listOfWords)
                    {                        
                        if (anotherWord.Length != 6 && anotherWord.Length + word.Length == 6)
                        {        
                            
                            newWord += anotherWord.Text;
                            bool correct = WordIsCorrect(newWord, targetWords);
                                if (correct)
                                {
                                string output = word.Text + "+" + anotherWord.Text + "=" + newWord;
                                if (!newWords.Contains(output))
                                {
                                    
                                    Console.WriteLine(output);
                                    newWords.Add(output);
                                  
                                }
                               
                            }
                        }
                        else
                        {
                            newWord = word.Text;
                        }
                    }




                }

            }


        }

        public List<Word> FindTargetWords(List<Word> listOfWords)
        {
            var enumerableList = listOfWords.AsEnumerable();
            return enumerableList.Where(word => word.Length == 6).ToList();
        }

        public bool WordIsCorrect(string newWord, List<Word> targetWords)
        {          
            foreach (var word in targetWords)
            {
                if (newWord == word.Text)
                    return true;

                    
            }
            return false;

        }



    }

}
