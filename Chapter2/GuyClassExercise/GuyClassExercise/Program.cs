namespace GuyClassExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Guy jacek = new Guy() { Name = "Jacek", Cash = 50 };
            Guy bartek = new Guy() { Name = "Bartek", Cash = 100 };

            while (true)
            {
                jacek.WriteMyInfo();
                bartek.WriteMyInfo();
                Console.Write("Podaj kwotę: ");
                string howMuch = Console.ReadLine();
                if (howMuch == "") return;
                if (int.TryParse(howMuch, out int amount))
                {
                    Console.Write("Pieniądze ma przekazać: ");
                    string whichGuy = Console.ReadLine();
                    if (whichGuy == "Jacek")
                    {
                        int cashGiven = jacek.GiveCash(amount);
                        bartek.ReceiveCash(cashGiven);
                    }
                    else if (whichGuy == "Bartek")
                    {
                        int cashGiven = bartek.GiveCash(amount);
                        jacek.ReceiveCash(cashGiven);
                    }
                    else
                    {
                        Console.WriteLine("Wpisz: Jacek lub Bartek");
                    }
                }
                else
                {
                    Console.WriteLine("Wpisz kwotę (lub pusty wiersz, aby zakończyć)");
                }
            }
        }
    }
}
