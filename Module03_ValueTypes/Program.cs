namespace Module03_ValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            int h = 100;
            System.Console.WriteLine(h.ToString());
            
            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
