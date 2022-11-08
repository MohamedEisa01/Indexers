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
            IP iP = new IP(192, 168, 1, 1);
            IP iP1 = new IP("192.168.1.1");

            Console.WriteLine(iP.Address);
            Console.WriteLine(iP1.Address);

            Console.WriteLine(iP[0]);
            Console.WriteLine(iP1[0]);

            Console.ReadLine();

        }
    }

    public class IP
    {
        private int[] segmants = new int[4];
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
    }
}
