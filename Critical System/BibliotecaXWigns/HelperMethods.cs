using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaXWigns
{
    public class HelperMethods
    {
        #region HelperMethods
        //tasks1 
        public string GetMostCommonWords(string[] words, int len = 5, int quants = 5)
        {
            var frequencyOrder = from word in words
                                 group word by word into g
                                 orderby g.Count() descending
                                 select g.Key;

            var commonWords = frequencyOrder.Take(quants);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Task 1 -- GetCommonWords with more than  letters: ");
            foreach (var v in commonWords)
            {
                sb.AppendLine("  " + v + " " + v.Count());
            }
            string resultat = sb.ToString();
            return resultat;
        }

        //task2
        public string GetMostCommonWordsByLength(string[] words, int len = 5, int quants = 5)
        {
            var frequencyOrder = from word in words
                                 where word.Length == 3
                                 group word by word into g
                                 orderby g.Count() ascending
                                 select g.Key;

            var commonWords = frequencyOrder.Take(quants);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Task 2 -- GetCommonWordsByLength With {len} letters: ");
            foreach (var v in commonWords)
            {
                sb.AppendLine("  " + v + " " + v.Count());
            }
            string resultat = sb.ToString();
            return resultat;

        }
        //taks3
        public string GetCountForWord(string[] words, string term)
        {
            var frequencyOrder = from word in words
                                 where word == term
                                 group word by word into g
                                 orderby g.Count() ascending
                                 select g.Key;


            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Task 2 -- GetCommonWordsByLength With {term} letters: ");
            foreach (var v in frequencyOrder)
            {
                sb.AppendLine("  " + v + " " + v.Count());
            }
            string resultat = sb.ToString();
            return resultat;
        }
        //task4
        public string GetCountForLetter(string[] words, string letter)
        {
            var frequencyOrder = from word in words
                                 where word.StartsWith(letter)
                                 group word by word into g
                                 orderby g.Count() ascending
                                 select g.Key;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Task 4 -- The Words that startWith {letter} accurs");
            int numeroRep = 0;
            foreach (var v in frequencyOrder)
            {
                numeroRep = numeroRep + v.Count();
            }
            sb.AppendLine(" " + numeroRep);
            string resultat = sb.ToString();
            return resultat;
        }

        //tasks 5
        public string GetLessCommonWords(string[] words, int len = 5, int quants = 5)
        {
            var frequencyOrder = from word in words
                                 where word.Length > len
                                 group word by word into g
                                 orderby g.Count() descending
                                 select g.Key;

            var commonWords = frequencyOrder.Take(quants);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Task 5 -- The less common Words With more than {len} letter, are: ");
            foreach (var v in commonWords)
            {
                sb.AppendLine("  " + v + " " + v.Count());
            }
            string resultat = sb.ToString();
            return resultat;
        }


        //Task 6
        public string GetLongestWord(string[] words)
        {
            var longestWord = (from w in words
                               orderby w.Length descending
                               select w).First();

            string resultat = $"Task 6 -- The longest word is {longestWord}.";
            return resultat;
        }
        #endregion
    }
}
