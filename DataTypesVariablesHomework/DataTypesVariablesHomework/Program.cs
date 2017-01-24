using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataTypesVariablesHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            
            long picturesAmount = int.Parse(Console.ReadLine());
            int filterTimeSec = int.Parse(Console.ReadLine());
            int goodPicturePersent = int.Parse(Console.ReadLine());
            int uploadTimeSec = int.Parse(Console.ReadLine());
            long timeFilter = picturesAmount * (long)filterTimeSec;
            int goodPictures = (int) Math.Ceiling(goodPicturePersent *((double) picturesAmount / 100));
            long uploadPicTime =  goodPictures *(long)uploadTimeSec;
            int timeNeeded =(int)(timeFilter + uploadPicTime);

            var result = new TimeSpan(0,0,timeNeeded);
            Console.WriteLine(result.ToString(@"d\:hh\:mm\:ss"));

            
        }
    }
}
