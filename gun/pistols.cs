using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gun
{
    public class pistols
    {
        private int _articcle;
        private string _name;
        private string _brand;
        private string _model;
        private string _caliber;
        private int _weight;
        private string _color;
        private int _price;
        private int _length;
        private int _BarrelLength;
        private int _magazine;
        public string Name => _name;
        public int Articcle => _articcle;
        public string Brand => _brand;
        public string Model => _model;
        public string Caliber => _caliber;
        public int Price => _price;
        public int Length => _length;
        public int Weight => _weight;   
        public string Color => _color;
        public int BarrelLenght => _BarrelLength;
        public int Magazine => _magazine;
        public pistols(int articcle, string name, string brand, string model, string caliber, int weight, string color, int price, int length, int BarrelLength, int magazine)
        {
            _articcle = articcle;
            _name = name;
            _brand = brand;
            _model = model;
            _caliber = caliber;
            _weight = weight;
            _color = color;
            _price = price;
            _length = length;
            _BarrelLength = BarrelLength;
            _magazine = magazine;
        }
        public void Display()
        {
            Console.WriteLine($"{_articcle,-10} {Name,-15} {Brand,-15} {Model,-15} {Caliber,-10} {Weight,-10} {Color,-10} {Price,-10} {Length,-10} {_BarrelLength,-10} {_magazine,-10}");
        }


    }
}
