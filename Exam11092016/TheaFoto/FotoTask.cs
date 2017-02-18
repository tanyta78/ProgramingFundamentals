namespace TheaFoto
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

   public class FotoTask
    {
       public static void Main()
        {
            long amountOfPictures = long.Parse(Console.ReadLine());
            long filterTimeinSecPerPicture = long.Parse(Console.ReadLine());
            long persentageOfGoodPictures = long.Parse(Console.ReadLine());
            long uploadTimeinSecForGoodPicture = long.Parse(Console.ReadLine());
           long timeForFilter = amountOfPictures * filterTimeinSecPerPicture;
            long goodPictures =(long) Math.Ceiling(((double)persentageOfGoodPictures / 100 )* amountOfPictures);
            long timeForUploadGoodPic = goodPictures * uploadTimeinSecForGoodPicture;

            long totalTimeInSec = timeForFilter + timeForUploadGoodPic;
            TimeSpan time = TimeSpan.FromSeconds(totalTimeInSec);
            string str = time.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(str);

        }
    }
}
