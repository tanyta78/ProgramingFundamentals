namespace _14.Use_Your_Chains__Buddy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;


    class EnqryptManual
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string pattern = @"(<p>(.*?)<\/p>)";
            Regex regexp = new Regex(pattern);
            MatchCollection matches = regexp.Matches(text);

            string extract = "";

            foreach (Match match in matches)
            {
                extract += match.Groups[2].ToString();

            }

            //replace symbols with space
            string replPattern = @"([^a-z0-9])";

            Regex regex = new Regex(replPattern);
            extract = Regex.Replace(extract, replPattern, " ");

            //replace multiply spaces with single
            extract = Regex.Replace(extract, @"\s+|\n+", " ");


            //convert letters
            StringBuilder sb = new StringBuilder(extract.Length);

            foreach (char ch in extract)
            {

                if (ch >= 'a' && ch <= 'm')
                {
                    sb.Append((char)(ch + 13));
                }
                else if (ch >= 'n' && ch <= 'z')
                {
                    sb.Append((char)(ch - 13));
                }
                else
                {
                    sb.Append(ch);
                }

            }

            //print result
            string result = sb.ToString();
            Console.WriteLine(result);
        }
    }

}
    