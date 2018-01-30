using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Path_Sprite_Generator
{
    class Program
    {
        //public static 
        static void Main(string[] args)
        {


            StreamWriter Converter = new StreamWriter("Converted.txt");

            string TypeConverted = "Sprite";
            string PubStatReadonly = $@"public static readonly {TypeConverted}";
            string PrivStatReadonly = $@"private static readonly {TypeConverted}";
            string PubStat = $@"public static {TypeConverted}";
            string PrivStat = $@"private static {TypeConverted}";





            string NewTypeConverted = $@"= new {TypeConverted}";

            string DirectoryUsed = "cardpack/";


            var getFiles = Directory.GetFiles($"{DirectoryUsed}");
            string[] getNames = new string[getFiles.Length];
            int counter = 0;
            foreach (var f in getFiles)
            {

  
                 //string name = Path.GetFileName(f);
                getNames[counter] =  Path.GetFileNameWithoutExtension(f);
                ++counter;
            }


           for(var x = 0; x < getFiles.Length ; x++)
            {
            Converter.WriteLine($"{PubStatReadonly} {getNames[x]} {NewTypeConverted}(\"{getFiles[x]}\")" + @";");
            }
            
            Converter.Dispose();
        }
    }
}
