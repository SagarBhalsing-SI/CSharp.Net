namespace StaticDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apartment.address = "04,Shri Ganesh Building,Hanuman Nagar,Behind Tata Compound"; //Static varibales should also be diretcly accessed using class name but not by the object of the class.
            Apartment a = new Apartment("Sagar", 04);
            Apartment a1 = new Apartment("Anas", 05);
            Apartment a2 = new Apartment("Jay", 06);

            Apartment.DisplayAddress();
            Apartment.DisplaynoOfHouseBought();     //Static Methods should always be called using class name and not the object of class
            a.Display();
            a2.Display();
            a1.Display();

        }
    }
}