using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementDemo
{
    public class InventoryDetails
    {
        public List<TypesOfRice> typesofRice;
        public List<TypesOfPulses> typesofPulses;
        public List<TypesOfWheat> typesofWheat;

    }
    public class TypesOfRice
    {
        public string name;
        public int weight;
        public int price;
    }
    public class TypesOfPulses
    {
        public string name;
        public int weight;
        public int price;
    }
    public class TypesOfWheat
    {
        public string name;
        public int weight;
        public int price;
    }

}
