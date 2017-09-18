using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_Cameron
{
    class Program : Concerts
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Types of Concerts");
            Console.WriteLine();
            MusicFest();
            Unplugged();
            OpenMic();
            Console.Read();
        }

        static void MusicFest()
        {
            MusicFest mfInfo = new MusicFest();
            Coachella mfExample = new Coachella();

            Console.WriteLine("MUSIC FEST");
            Console.Write("  Crowd: ");
            Console.Write(mfInfo.Crowd());
            Console.WriteLine();
            Console.Write("  Performers: ");
            Console.Write(mfInfo.Performers() + "+");
            Console.WriteLine();
            Console.Write("  Location: ");
            Console.Write(mfInfo.Location());
            Console.WriteLine();
            Console.Write("  Coachella: ");
            Console.Write(mfExample.HeadLine());
            Console.WriteLine();

        }

        static void Unplugged()
        {
            Unplugged upInfo = new Unplugged();
            MTV upExample = new MTV();

            Console.WriteLine();
            Console.WriteLine("UNPLUGGED");
            Console.Write("  Crowd: ");
            Console.Write("< " + upInfo.Crowd());
            Console.WriteLine();
            Console.Write("  Performers: ");
            Console.Write(upInfo.Performers());
            Console.WriteLine();
            Console.Write("  Location: ");
            Console.Write(upInfo.Location());
            Console.WriteLine();
            Console.Write("  MTV Unplugged: ");
            Console.Write(upExample.HeadLine());
            Console.WriteLine();
        }

        static void OpenMic()
        {
            OpenMic omInfo = new OpenMic();
            LocalVenue omExample = new LocalVenue();

            Console.WriteLine();
            Console.WriteLine("OPEN MIC NIGHT");
            Console.Write("  Crowd: ");
            Console.Write(omInfo.Crowd());
            Console.WriteLine();
            Console.Write("  Performers: at least ");
            Console.Write(omInfo.Performers());
            Console.WriteLine();
            Console.Write("  Location: ");
            Console.Write(omInfo.Location());
            Console.WriteLine();
            Console.Write("  Local Venue: ");
            Console.Write(omExample.HeadLine());


        }
    
    }
}
