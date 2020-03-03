using System;
using System.Collections.Generic;
using System.Text;

namespace CMP1903M_W07
{
    class Shop : Property
    {
        public enum Tenure { freehold, leasehold }
        public int squareFeet { get; set; }

        public Shop(string A, int v, int SqF)
        {
            Address = A;
            Value = v;
            squareFeet = SqF;
        }
    }
}
