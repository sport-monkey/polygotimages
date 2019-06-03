using System;
using System.IO;
using SixLabors.ImageSharp;

namespace ImageSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(1);
            using (var image = Image.Load("Image.jpg"))
            {
                Console.WriteLine(2);
                using (var fp = File.OpenWrite("Image_New.jpg"))
                {
                    Console.WriteLine(3);
                    image.SaveAsJpeg(fp);
                    Console.WriteLine(4);
                }
            }
        }
    }
}
