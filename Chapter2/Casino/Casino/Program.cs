namespace Casino
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(); 
            Double odds = 0.75;
            Player player = new Player() { Name = "Player", Cash = 100 };

            while (player.Cash > 0)
            {
                player.WriteMyInfo();
                Console.WriteLine("Podaj stawkę: ");
                string howMuch = Console.ReadLine();
                if (int.TryParse(howMuch, out int amount))
                {
                    int pot = amount * 2;
                    double result = random.NextDouble();
                    if (result > odds)
                    {
                        player.Cash += pot;
                        Console.WriteLine("Wygrałeś !");
                    }
                    else
                    {
                        player.Cash -= pot;
                        Console.WriteLine("Przegrałeś...");
                    }
                }
                else
                {
                    Console.WriteLine("Musisz podać kwotę");
                }
            }
        }
    }
}