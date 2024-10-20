using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gun
{
    internal class rifles
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
        private int _barrelLength;
        private int _magazineCapacity;
        public int Articcle => _articcle;
        public string Name => _name;
        public int Price => _price;
        public rifles(int articcle, string name, string brand, string model, string caliber, int weight, string color, int price, int length, int barrelLength, int magazineCapacity)
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
                _barrelLength = barrelLength;
                _magazineCapacity = magazineCapacity;
            }
            public void Display()
            {
                Console.WriteLine($"{_articcle,-10} {_name,-15} {_brand,-15} {_model,-10} {_caliber,-10} {_weight,-10} {_color,-10} {_price,-10} {_length,-10} {_barrelLength,-10} {_magazineCapacity,-10}");
            }
    }

    }

