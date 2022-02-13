using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using System.Collections;


namespace SWP391_OnlineLearning_Platform.Utility
{
	public class FileReader
	{
		public LinkedList<string[]> CsvReader()
		{
			LinkedList<string[]> list = new LinkedList<string[]>();
			var path = @"C:\Users\trung\Desktop\New folder (3)\New folder (2)\online_learning_SWP391\SWP391-OnlineLearning-Platform\wwwroot\lmao.csv"; // Habeeb, "Dubai Media City, Dubai"
			using (TextFieldParser csvParser = new TextFieldParser(path))
			{
				csvParser.CommentTokens = new string[] { "#" };
				csvParser.SetDelimiters(new string[] { "," });
				csvParser.HasFieldsEnclosedInQuotes = true;

				// Skip the row with the column names
				csvParser.ReadLine();

				while (!csvParser.EndOfData)
				{
					// Read current line fields, pointer moves to the next line.
					string[] fields = csvParser.ReadFields();
					list.AddLast(fields);
				}
			}
			return list;
		}
	}
}
