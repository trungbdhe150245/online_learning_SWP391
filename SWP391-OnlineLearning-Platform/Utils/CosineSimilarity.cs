using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Utils
{
	public class CosineSimilarity
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
        public static int countWords(String document, String pattern)
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
                    vectors[i,j] = countWords(documents[i], vocabulary[j]);
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
                vector[j] = countWords(document, vocabulary[j]);
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
