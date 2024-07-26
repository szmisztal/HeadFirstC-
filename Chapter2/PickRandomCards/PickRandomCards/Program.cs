namespace PickRandomCards

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wpisz liczbę kart do wygenerowania: ");
            string line = Console.ReadLine();
            if (int.TryParse(line, out int numberOfCards))
            {
                foreach (string card in CardPicker.PickSomeCards(numberOfCards))
                {
                    Console.WriteLine(card);
                }
            }
            else
            {
                Console.Write("Nieprawidłowe dane, wpisz liczbę");
            }


        }
    }
}