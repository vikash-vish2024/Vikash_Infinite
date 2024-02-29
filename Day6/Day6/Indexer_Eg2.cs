using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    public class Flower
    {
        string name;
        string color;

        public Flower(String name,string color)
        {
            this.name = name;
            this.color = color;
        }
        public void Display()
        {
            Console.WriteLine($"{name} is in {color} color");
        }
    }
    class FlowerVase
    {
        Flower[] flowerobj = new Flower[5]; // aggregation is created

        //Indexer, that keeps track of the array object
        public Flower this[int pos]
        {
            get { return flowerobj[pos]; }
            set { flowerobj[pos] = value; }
        }
    }
    class Indexer_Eg2
    {
        static void Main()
        {
            FlowerVase flowerVase = new FlowerVase();
            flowerVase[0] = new Flower("Rose", "White");
            flowerVase[1] = new Flower("Rose", "Black");
            flowerVase[2] = new Flower("Rose", "Yellow");
            flowerVase[3] = new Flower("Rose", "Voilet");
            flowerVase[4] = new Flower("Rose", "Purple");

            for(int i = 0; i < 5; i++)
            {
                flowerVase[i].Display();
            }
        }
    }
}
