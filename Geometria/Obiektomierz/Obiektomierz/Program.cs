namespace Obiektomierz
{
    class Program
    {
        static void Main()
        {
            string wybor;
            bool pentla1;
            bool pentla2;
            bool pentla3;

            pentla1 = true;
            while (pentla1)
            {
                Console.WriteLine("Witaj w programie \"Obiektomierz\"\n ");
                Console.WriteLine("INFO");
                Console.WriteLine("Program służy do obliczania matematycznych rozwiązań\n" +
                    "ściśle związanych z działem geometrii\n ");
                Console.WriteLine("Poniżej znajdują się dostępne kategorie\n" +
                    "zawierające wiele operacji matematycznych\n" +
                    "związanych z daną dziedziną\n ");
                Console.WriteLine("Wybierz jedną z opcji:\n");
                Console.WriteLine("1. Wektory\n" +
                    "2. Geometria Analityczna\n" +
                    "3. Geometria Płaska\n" +
                    "4. Geometria Przestrzenna\n\n" +
                    "Lub zakończ program wspisując zamiast numeru słowo klucz: ESC\n ");
                
                pentla2 = true;
                while (pentla2)
                {
                    Console.Write("Wprowadź kod z dostępnych powyżej opcji: ");
                    string kategoria = Console.ReadLine();

                    switch (kategoria.ToUpper())
                    {
                        case "1":
                            {
                                Console.Clear();
                                Wektory.Funkcje();
                                pentla2 = false;
                                Console.Clear();
                                break;
                            }
                        case "2":
                            {
                                break;
                            }
                        case "3":
                            {
                                break;
                            }
                        case "4":
                            {
                                break;
                            }
                        case "ESC":
                            {
                                pentla3 = true;
                                while (pentla3)
                                {
                                    Console.Write("\nCzy jesteś pewny swego wyboru { T / N }: ");
                                    wybor = Console.ReadLine();
                                    wybor = wybor.ToUpper();
                                    if (wybor == "T")
                                    {
                                        pentla3 = false;
                                        pentla2 = false;
                                        pentla1 = false;
                                    }
                                    else if (wybor == "N")
                                    {
                                        pentla3 = false;
                                        Console.WriteLine("");
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nBłedny kod wyboru!");
                                    }
                                }
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("\nBłedny kod wyboru!\n");
                                break;
                            }
                    }
                }
            }
        }  
    }
}
