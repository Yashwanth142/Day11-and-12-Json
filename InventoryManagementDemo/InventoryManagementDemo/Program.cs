namespace InventoryManagementDemo
{
    public class Program
    {

        public static void Main(string[] args)
        {
            string path = "C:\\Users\\yashw\\source\\repos\\InventoryManagementDemo\\InventoryManagementDemo\\Inventory.json";
            ReadData readData = new ReadData();
            var Data = readData.Read(path);
            Console.WriteLine("Types of Rice");
            Console.WriteLine("-----------------------------");
            for (int i = 0; i < Data.typesofRice.Count; i++)
            {
                Console.WriteLine(Data.typesofRice[i].name);
                Console.WriteLine(Data.typesofRice[i].weight);
                Console.WriteLine(Data.typesofRice[i].price);
                Console.WriteLine("--------");
                int val = Data.typesofRice[i].weight * Data.typesofRice[i].price;
                Console.WriteLine("The price for " + Data.typesofRice[i].weight + " kg is " + val);
                Console.WriteLine("--------");
            }

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Types of Pulses");
            Console.WriteLine("-----------------------------");

            for (int i = 0; i < Data.typesofPulses.Count; i++)
            {
                Console.WriteLine(Data.typesofPulses[i].name);
                Console.WriteLine(Data.typesofPulses[i].weight);
                Console.WriteLine(Data.typesofPulses[i].price);
                Console.WriteLine("--------");
                int val = Data.typesofPulses[i].weight * Data.typesofPulses[i].price;
                Console.WriteLine("The price for " + Data.typesofPulses[i].weight + " kg is " + val);
                Console.WriteLine("--------");
            }

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Types of Wheat");
            Console.WriteLine("-----------------------------");

            for (int i = 0; i < Data.typesofWheat.Count; i++)
            {
                Console.WriteLine(Data.typesofWheat[i].name);
                Console.WriteLine(Data.typesofWheat[i].weight);
                Console.WriteLine(Data.typesofWheat[i].price);
                Console.WriteLine("--------");
                int val = Data.typesofWheat[i].weight * Data.typesofWheat[i].price;
                Console.WriteLine("The price for " + Data.typesofWheat[i].weight + " kg is " + val);
                Console.WriteLine("--------");
            }
        }
    }
}