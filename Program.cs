using System;

namespace oop_lab1
{
    class building
    {
        private string name;
        private double height;

        
        public building()
        {
            name = "default_name";

        }
        public building(string name, double height)
        {
            this.name = name;
            this.height = height;
        }
        public string Name
        {
            get 
            {
                return name; 
            }
            set
            {
                name = value;
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        public void printAll()
        {
            Console.Write("Name\t" + name + "\n");
            Console.Write("Height\t" + height + "\n");
        }
        public double foundation()
        {
            return height*0.03;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            building house = new building();
            house.printAll();

            house.Height = 10;
            house.Name = "DOM";
            Console.Write("Height\t" + house.Height + "\n");
            Console.Write("Name\t" + house.Name + "\n");
            Console.Write("Foundation:\t" + house.foundation() + "\n");

            building house2 = new building("DOM2", 15);
            house2.printAll();
        }
    }
}
