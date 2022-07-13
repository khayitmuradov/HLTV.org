namespace HLTV.org.Pages
{
    public class PlayersPage
    {
        public static async Task RunAsync()
        {
            Console.WriteLine("1. All Players");
            Console.WriteLine("2. Specific Player");
            Console.WriteLine("3. Add New Player to Database");
            Console.WriteLine("4. Update Player's data");
            Console.WriteLine("5. Remove Specific Player");

            string str = Console.ReadLine();

            if (str == "1")
                await ReadAllPage.RunAsync();
            else if (str == "2")
                await ReadPage.RunAsync();
            else if (str == "3")
                await CreatePage.RunAsync();
            else if (str == "4")
                await UpdatePage.RunAsync();
            else if (str == "5")
                await DeletePage.RunAsync();
            else
            {
                Console.WriteLine("Input is Wrong! Try Agan!");
                await RunAsync();
            }
        }
    }
}
