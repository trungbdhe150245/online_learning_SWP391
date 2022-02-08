using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Utility
{
	public class Levenshtein
	{
        public static int Compute(string s, string t)
        {
            if (string.IsNullOrEmpty(s))
            {
                if (string.IsNullOrEmpty(t))
                    return 0;
                return t.Length;
            }

            if (string.IsNullOrEmpty(t))
            {
                return s.Length;
            }

            int n = s.Length;
            int m = t.Length;
            int[,] d = new int[n + 1, m + 1];

            // initialize the top and right of the table to 0, 1, 2, ...
            for (int i = 0; i <= n; d[i, 0] = i++) ;
            for (int j = 1; j <= m; d[0, j] = j++) ;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    int cost = (t[j - 1] == s[i - 1]) ? 0 : 1;
                    int min1 = d[i - 1, j] + 1;
                    int min2 = d[i, j - 1] + 1;
                    int min3 = d[i - 1, j - 1] + cost;
                    d[i, j] = Math.Min(Math.Min(min1, min2), min3);
                }
            }
            return d[n, m];
        }

    }
    class CosineSimilarity
	{
        public static string[] GenerateVocabulary(string[] documents)
        {
            string summary = "";
            foreach (string document in documents)
            {
                summary += " " + document;
            }
            String[] words = summary.Trim().Split(" ");
            String vocab = "";
            for (int i = 0; i < words.Length; i++)
            {
                bool isDuplicated = false;
                String[] temp_token = vocab.Trim().Split(" ");

                for (int j = 0; j < temp_token.Length; j++)
                {
                    if (words[i].Equals(temp_token[j]))
                    {
                        isDuplicated = true;
                        break;
                    }
                }
                if (!isDuplicated)
                {
                    vocab += " " + words[i];
                }
            }
            return vocab.Trim().Split(" ");
        }
        public static int CountWords(string document, string pattern)
        {
            int count = 0;
            String[] words = document.Split(" ");
            foreach (string word in words)
            {
                if (word.Equals(pattern))
                {
                    count++;
                }
            }

            return count;
        }
        // Two demensional array
        public static float[,] DocsToVecs(string[] vocabulary, string[] documents)
        {
            float[,] vectors = new float[documents.Length, vocabulary.Length];
            for (int i = 0; i < documents.Length; i++)
            {
                for (int j = 0; j < vocabulary.Length; j++)
                {
                    vectors[i, j] = CountWords(documents[i], vocabulary[j]);
                }
            }
            return vectors;
        }
        //

        public static float[] DocToVec(string[] vocabulary, string document)
        {
            float[] vector = new float[vocabulary.Length];

            for (int j = 0; j < vocabulary.Length; j++)
            {
                vector[j] = CountWords(document, vocabulary[j]);
            }
            return vector;
        }

        public static float GetSimilarity(float[] a, float[] b)
        {
            float above = 0;
            float leftbottom = 0, rightbottom = 0;
            for (int i = 0; i < a.Length; i++)
            {
                above += (a[i] * b[i]);
                leftbottom += a[i] * a[i];
                rightbottom += b[i] * b[i];
            }
            return (float)(above / (Math.Sqrt((double)rightbottom) * Math.Sqrt((double)leftbottom)));
        }
    }

}
