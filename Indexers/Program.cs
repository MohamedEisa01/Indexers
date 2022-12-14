using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IP ip1 = new IP(192, 168, 1, 1);
            IP ip2 = new IP("192.168.1.2");

            IP ip3 = new IP(192, 168, 1, 3);

            ip3["0"] = "one";
            ip3["1"] = "two";
            ip3["2"] = "there";
            ip3["3"] = "four";
            ip3["4"] = "five";

            Console.WriteLine(ip1.Address);
            Console.WriteLine(ip2.Address);
            Console.WriteLine(ip3.PrintStrings);

            //Console.WriteLine(ip1[0]);
            //Console.WriteLine(ip2[0]);
            //Console.WriteLine(ip3[0]);

            Console.ReadLine();

        }
    }

    public class IP
    {
        private int[] segmants = new int[4];
        private string[] strings = new string[5];

        public string this[string i] 
        { 
            get => strings[Convert.ToInt32(i)];
            set => strings[Convert.ToInt32(i)] = value;
        }



        public int this[int i]
        {
            get
            {
                return segmants[i];
            }
            set
            {
                segmants[i] = value;
            } 
        }
        public IP(string IPAdress)
        {
            var segmates = IPAdress.Split('.');

            for (int i = 0; i < segmates.Length; i++)
            {
                this.segmants[i] = int.Parse(segmates[i]);
            }
        }
        public IP(int seg1, int seg2, int seg3, int seg4)
        {
            segmants[0] = seg1;
            segmants[1] = seg2;
            segmants[2] = seg3;
            segmants[3] = seg4;
        }
        public string Address => string.Join(".", segmants);
        public string PrintStrings => string.Join(".", strings);
    }
}
