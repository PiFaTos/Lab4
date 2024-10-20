using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace gun
{
    internal class knives
    {
        private int _articcle;
        private string _name;
        private string _brand;
        private string _type;
        private int _price;
        private string _handle;
        public int Articcle => _articcle;
        public string Name => _name;
        public string Brand => _brand;
        public string Type => _type;
        public int Price => _price;
        public string Handle => _handle;
        public knives(int articcle, string name, string brand, string type, int price, string handle)
        {
            _articcle = articcle;
            _name = name;
            _brand = brand;
            _type = type;
            _price = price;
            _handle = handle;
        }
        public void Display()
        {
            Console.WriteLine($"{_articcle,-10} {Name,-15} {Brand,-15} {Type,-10} {Price,-10} {Handle,-10}");
        }
    }
}
