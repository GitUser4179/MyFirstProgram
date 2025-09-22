namespace MyFirstProgram1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fadi Mrito Fullstackutvecklare .NET25
            // MyFirstProgram

            int num = 11;

            // Om num är större än 10
            if (num > 10)
            {
                Console.WriteLine("Talet är stort!");
            }
            // Annars utför vi det här
            else if (num < 10)
            {
                Console.WriteLine("Oj. Lågt tal!");
            }
            else
            {
                Console.WriteLine("Talet är 10!");
            }

            Console.WriteLine("Vad heter du?"); // Skriver ut ett meddelande för användaren
            string namn = Console.ReadLine(); // Tar vad användaren skriver, och förvandlar det till en string variabel
            Console.WriteLine("Hej " + namn + "!");

            // En loop där startpunkten i är 0, och konditionen för att fortsätta loopen är om i är mindre eller lika stor som num.
            // Vi lägger till +1 på i varje gång vi utför loopen.
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
