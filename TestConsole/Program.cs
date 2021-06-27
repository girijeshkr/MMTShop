using System;
using System.Net;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new WebClient()) //WebClient  
            {
                client.Headers.Add("Content-Type:application/json");
                client.Headers.Add("Accept:application/json");
                DoProcess(client);
            }

        }
        public static void DoProcess(WebClient client)
        {
            Console.WriteLine("Please choose an action:");
            Console.WriteLine("Press 1: To see all the avaialble Featured Products.");
            Console.WriteLine("Press 2: To see all the avaialble categories.");
            Console.WriteLine("Press 3: To see Products avaialble for any specific category.");
            Console.WriteLine("Press 4: Exit");
            string enteredText = Console.ReadLine();
            switch (enteredText)
            {
                case "1":
                    var result = client.DownloadString("http://localhost:61000/api/Products/GetFeaturedProducts");
                    Console.WriteLine(Environment.NewLine + result + Environment.NewLine);
                    DoProcess(client);
                    break;
                case "2":
                    result = client.DownloadString("http://localhost:61000/api/Categories/GetNames"); //URI  
                    Console.WriteLine(Environment.NewLine + result + Environment.NewLine);
                    DoProcess(client);
                    break;
                case "3":
                    Console.WriteLine("Please provide the category name:");
                    string category = Console.ReadLine();
                    result = client.DownloadString("http://localhost:61000/api/Products/GetProductsByCategory?category=" + category); //URI  
                    Console.WriteLine(Environment.NewLine + result + Environment.NewLine);
                    DoProcess(client);
                    break;
                case "4":
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("Sorry this action is not avaiable." + Environment.NewLine);
                    DoProcess(client);
                    break;
            }
        }
    }
}
