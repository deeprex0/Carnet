using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices.Marshalling;
using System.Runtime.CompilerServices;

namespace CarnetClasses
{

        public  abstract class Files
        {
            internal static void Zid(string path, string type ){

                Console.Write("Ara smiat had l {type}: "); var smia = Convert.ToString(Console.ReadLine());
                Console.Write("ach 3tdak: "); var l7aja = Console.ReadLine();
                Console.Write("ch7al sawi?: "); var tamane = Console.ReadLine();

#pragma warning disable CS8604 // Possible null reference argument.
            File.AppendAllText(path, StarMaker(smia, l7aja, tamane) + Environment.NewLine);
#pragma warning restore CS8604 // Possible null reference argument.


        }

        internal static List<string> Upload(string path){

            return new List<string>(File.ReadAllLines(path));

           
        }

         static  void Download(string path, List<string> stora){
            File.WriteAllLines(path, stora);
        }

        internal static int Qallab(List<string> lines, string smia){
            lines.Sort();
            return  lines.BinarySearch(smia);
        }


        internal static void Nqass(string path, string smia){
            List<string> stora = Upload(path);

            stora.RemoveAt(Qallab(stora, smia));

            Download(path,stora);



        }

        internal static void Afficher(string Path){
            var stora = Upload(Path);
            foreach ( var star in stora){
                Console.WriteLine(star + "\n");
            }


        }

        public static string StarMaker(string smia, string l7aja, string prix){
            return smia + " " + l7aja + " " + prix + "\n";
        }
    }


    internal  class Ettday : Files{

          internal static  string  Qallab(string smia){
            List<string> lines = Files.Upload("Ettdaya.txt");

            lines.Sort();
            int index = lines.BinarySearch(smia);

            return lines[index];


        }


        

        

    }


}
