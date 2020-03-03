using System;
using System.Collections.Generic;
using System.Text;

namespace CMP1903M_W07
{
    class House : Property
    {
        public int ID { get; set; }
        public int numberOfBedrooms { get; set; }
        public bool garage { get; set; }

        public House (int id, string a, int v, int n, bool g)
        {
            ID = id;
            Address = a;
            Value = v;
            numberOfBedrooms = n;
            garage = g;
        }
        
    }
}
