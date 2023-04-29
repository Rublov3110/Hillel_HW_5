namespace PRO_HW_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Factory<BMW> newFactoruBMW = new Factory<BMW>();


            var bmw = newFactoruBMW.Create();
            bmw.ChengFactoru();

            Console.WriteLine(bmw.Name);
            Console.WriteLine(bmw.Closee);
        }
    }
}