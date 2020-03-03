using System;
using System.Collections.Generic;
using System.Text;

namespace CMP1903M_W07
{
    class Industrial : Property
    {
        public enum type { Warehouse, Office, Factory}
        public int squareFeet { get; set; }
        public bool EquipmentProvided { get; set; }
        
        public Industrial(string A, int V, int SqF, bool EP)
        {
            Address = A;
            Value = V;
            squareFeet = SqF;
            EquipmentProvided = EP;
        }
                
                
                
    }
}
