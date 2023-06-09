namespace CustomHashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashTable<string> objOfHashTable = new HashTable<string>(8);

            objOfHashTable.Add("Ravi");
            objOfHashTable.Add("Sudheer");
            objOfHashTable.Add("Raju");
            objOfHashTable.Add("Kumar");
            objOfHashTable.Add("Nivetha");

            objOfHashTable.Print();

        }
    }
}