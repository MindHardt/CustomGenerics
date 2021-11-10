using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;

namespace CustomGenerics
{
    public static class Codenames
    {
        public static readonly string PathToFolder     = "C:\\Users\\igorb\\source\\repos\\Algorithm lab 3\\CustomGenerics\\Additions";
        public static readonly string PathToDictionary = "C:\\Users\\igorb\\source\\repos\\Algorithm lab 3\\CustomGenerics\\Additions\\Dictionary.txt";

        public static UStack<string> AllWords 
        { 
            get
            {
                UStack<string> result = new UStack<string>();
                using (StreamReader sr = new StreamReader(PathToDictionary))
                {
                    result.Push(sr.ReadLine());
                }
                return result;
            }
        }

        public static UStack<string> Colors
        {
            get
            {
                UStack<string> result = new UStack<string>();
                result.Push("\\Red.jpg");
                result.Push("\\Red.jpg");
                result.Push("\\Red.jpg");
                result.Push("\\Red.jpg");
                result.Push("\\Red.jpg");
                result.Push("\\Red.jpg");
                result.Push("\\Red.jpg");
                result.Push("\\Red.jpg");
                result.Push("\\Red.jpg");//9


                result.Push("\\Blue.jpg");
                result.Push("\\Blue.jpg");
                result.Push("\\Blue.jpg");
                result.Push("\\Blue.jpg");
                result.Push("\\Blue.jpg");
                result.Push("\\Blue.jpg");
                result.Push("\\Blue.jpg");
                result.Push("\\Blue.jpg");//8

                result.Push("\\White.jpg");
                result.Push("\\White.jpg");
                result.Push("\\White.jpg");
                result.Push("\\White.jpg");
                result.Push("\\White.jpg");
                result.Push("\\White.jpg");
                result.Push("\\White.jpg");//7

                result.Push("\\Black.jpg");//1
                return result;
            }
        }

        public static void GetImage()
        {
            UStack<string> words = new UStack<string>(AllWords.Shuffle(5));
            UStack<string> colors = new UStack<string>(Colors.Shuffle(5));

            Image table = Image.FromFile(PathToFolder + "\\1366x720.png");
            Graphics gTable = Graphics.FromImage(table);

            table.Save(PathToFolder + "\\dummy.gif");
            EncoderParameters encoder = new EncoderParameters();
            encoder.Param[0] = new EncoderParameter(Encoder.SaveFlag, ())

            Font font = new Font(FontFamily.GenericMonospace, 30);
            Brush brush = new SolidBrush(Color.Black);

            for (int y = 60; y <= 600; y += 120)
            {
                for (int x = 13; x <= 1073; x += 265)
                {
                    Rectangle rect = new Rectangle(x, y, 250, 100);
                    gTable.DrawImage(Image.FromFile( PathToFolder + "\\" + colors.Pop()), rect);
                    gTable.DrawString(words.Pop(), font, brush, rect);
                }
                table.SaveAdd(table);
            }

            table.Save(PathToFolder + "\\table.gif", ImageFormat.Gif);
        }
    }

    public static class CodenamesExtensions
    {
        public static UTwoLinkedList<T> Shuffle<T>(this UTwoLinkedList<T> list, int scale)
        {
            var rawList = scale == 1 ? list : list.Shuffle(scale - 1);

            var newList = new UDeque<T>();
            var rnd = new Random();
            foreach (var item in rawList)
            {
                if (rnd.Next(0, 2) == 1) newList.PlaceFirst(item); else newList.PlaceLast(item);
            }
            return newList;
        }
    }
}
