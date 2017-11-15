namespace Files
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using Excel = Microsoft.Office.Interop.Excel;

    class Program
    {
        static void Main(string[] args)
        {
            //Read the file, which is in the resource section of the exercise and print all the punctuation marks, which you find and separate them with comma and a space. For punctuation marks you can consider only: “.”, “,”, “!”, “?” and “:”.
            string text = File.ReadAllText(@"sample_text.txt");
            List<char> result = text.ToCharArray().Where(c => new char[] { '.', ',', '!', '?', ':' }.Contains(c)).ToList();
            Console.WriteLine(string.Join(", ", result));

            //Read the same file, as in the previous task, but this time write everything, except the punctuation marks to a new file.Again, consider as punctuations only: “.”, “,”, “!”, “?” and “:”.
            string text2 = File.ReadAllText(@"sample_text.txt");
            List<char> result2 = text.ToCharArray().Where(c => !(new char[] { '.', ',', '!', '?', ':' }.Contains(c))).ToList();
            Console.WriteLine(string.Join("", result));

            //Problem 6.	** EXCELlent Knowledge

            //Create COM Objects. Create a COM object for everything that is referenced
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"sample_table.xlsx");
            // Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];

            Excel.Range xlRange = xlWorksheet.UsedRange;

            var columnsCount = xlRange.Columns.Count;
            var rowsCount = xlRange.Rows.Count;

            for (int i = 1; i <= rowsCount; i++)
            {
                for (int j = 1; j <= columnsCount; j++)
                {
                    if (xlRange.Cells[i, j] == null || xlRange.Cells[i, j].Value2 == null)
                    {
                        goto Break;
                    }
                    Console.Write((xlRange.Cells[i, j].Value2.ToString()) + "|");
                }
                Console.WriteLine();
            }
            Break:

            xlWorkbook.Close();
            xlApp.Quit();
        }
    }
}

