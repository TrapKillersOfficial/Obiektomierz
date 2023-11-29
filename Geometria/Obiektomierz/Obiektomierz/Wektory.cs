using System;

public class Wektory
{
	public static void Funkcje()
    {
        bool pentla1;
        bool pentla2;
        bool pentla3;
        bool pentla4;
        string wybor;
        
        pentla1 = true;
        while (pentla1)
        {
            Console.Clear();
            Console.WriteLine("Witaj w kategorii: \"Wektory\"\n ");
            Console.WriteLine("Wybierz jedną z dostepnych funkcji obliczeniowych:\n");
            Console.WriteLine("1. Współrzędne wektora\n" +
                "2. Długość wektora\n" +
                "3. Dodawanie wektorów\n" +
                "4. Odejmowanie wektorów\n" +
                "5. Iloczyn skalarny wektorów\n\n" +
                "Lub wróć do menu wyboru kategorii wspisując: ESC\n");

            pentla2 = true;
            while (pentla2)
            {
                Console.Write("Wprowadź kod z dostępnych powyżej opcji: ");
                string operacja = Console.ReadLine();

                switch (operacja.ToUpper())
                {
                    case "1":
                        {
                            pentla3 = true;
                            while (pentla3)
                            {
                                string wyb = Wybor();

                                if (wyb == "2")
                                {
                                    string odp = Wsp2();
                                    Console.WriteLine($"\nWspółrzędne wektora to: {odp}");
                                    Console.Write("\nCzy chcesz teraz:\n" +
                                            "1. Obliczyć ponownie współrzędne wektora\n" +
                                            "2. Wyprubować nową funkcję obliczeniową\n" +
                                            "3. Wrócić do menu wyboru kategorii\n");

                                    pentla4 = true;
                                    while (pentla4)
                                    {

                                        Console.Write("\nWprowadź kod z dostępnych powyżej opcji: ");
                                        wybor = Console.ReadLine();
                                        wybor = wybor.ToUpper();
                                        if (wybor == "1")
                                        {
                                            pentla4 = false;
                                        }
                                        else if (wybor == "2")
                                        {
                                            pentla4 = false;
                                            pentla3 = false;
                                            pentla2 = false;
                                            Console.WriteLine("");
                                        }
                                        else if (wybor == "3")
                                        {
                                            pentla4 = false;
                                            pentla3 = false;
                                            pentla2 = false;
                                            pentla1 = false;
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nBłedny kod wyboru!");
                                        }
                                        pentla2 = false;
                                    }
                                }
                                else
                                {
                                    string odp = Wsp3();
                                    Console.WriteLine($"\nWspółrzędne wektora to: {odp}");
                                    Console.Write("\nCzy chcesz teraz:\n" +
                                            "1. Obliczyć ponownie współrzędne wektora\n" +
                                            "2. Wyprubować nową funkcję obliczeniową\n" +
                                            "3. Wrócić do menu wyboru kategorii\n");

                                    pentla4 = true;
                                    while (pentla4)
                                    {

                                        Console.Write("\nWprowadź kod z dostępnych powyżej opcji: ");
                                        wybor = Console.ReadLine();
                                        wybor = wybor.ToUpper();
                                        if (wybor == "1")
                                        {
                                            pentla4 = false;
                                        }
                                        else if (wybor == "2")
                                        {
                                            pentla4 = false;
                                            pentla3 = false;
                                            pentla2 = false;
                                            Console.WriteLine("");
                                        }
                                        else if (wybor == "3")
                                        {
                                            pentla4 = false;
                                            pentla3 = false;
                                            pentla2 = false;
                                            pentla1 = false;
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nBłedny kod wyboru!");
                                        }
                                        pentla2 = false;
                                    }
                                }
                            }
                            break;
                        }
                    case "2":
                        {
                            // teraz długość
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
                    case "5":
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
    
    public static string Wybor()
    {
        bool pentla;
        string odp;

        Console.Clear();
        Console.WriteLine("Dostępne typy wektorów:\n\n" +
            "Dwuwymiarowe (2)\n" +
            "Trójwymiarowe (3)\n");

        pentla = true;
        while (pentla)
        {
            Console.Write("Wybierz typ wektora { 2 / 3 }: ");
            string typ = Console.ReadLine();

            if (typ == "2")
            {
                odp = "2";
                pentla = false;
                return odp;
            }
            else if (typ == "3")
            {
                odp = "3";
                pentla = false;
                return odp;
            }
            else
            {
                Console.WriteLine("\nBłedny kod wyboru!\n");
            }
            
        }
        return "";
    } 

    public static string Wsp2()
    {
        bool pentla;

        Console.WriteLine("\nUWAGA");
        Console.WriteLine("Wartości zmiennoprzecinkowe należy wprowadzać z symbolem przecinka { , }\n");

        pentla = true;
        while (pentla)
        {
            try
            {
                Console.Write("Podaj współrzędną 'x' początku wektora: ");
                double x1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Podaj współrzędną 'y' początku wektora: ");
                double y1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Podaj współrzędną 'x' końca wektora: ");
                double x2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Podaj współrzędną 'y' końca wektora: ");
                double y2 = Convert.ToDouble(Console.ReadLine());
                double X = x2 - x1;
                double Y = y2 - y1;
                string XY = $"[{X} , {Y}]";
                pentla = false;
                return XY;
            }
            catch
            {
                Console.WriteLine("\nBłedny kod wyboru!\n");
            }
        }
        return null;
    }

    public static string Wsp3()
    {
        bool pentla;

        Console.WriteLine("\nUWAGA");
        Console.WriteLine("Wartości zmiennoprzecinkowe należy wprowadzać z symbolem przecinka { , }\n");

        pentla = true;
        while (pentla)
        {
            try
            {
                Console.Write("Podaj współrzędną 'x' początku wektora: ");
                double x1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Podaj współrzędną 'y' początku wektora: ");
                double y1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Podaj współrzędną 'z' początku wektora: ");
                double z1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Podaj współrzędną 'x' końca wektora: ");
                double x2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Podaj współrzędną 'y' końca wektora: ");
                double y2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Podaj współrzędną 'z' końca wektora: ");
                double z2 = Convert.ToDouble(Console.ReadLine());
                double X = x2 - x1;
                double Y = y2 - y1;
                double Z = z2 - z1;
                string XY = $"[{X} , {Y} , {Z}]";
                pentla = false;
                return XY;
            }
            catch
            {
                Console.WriteLine("\nBłedny kod wyboru!\n");
            }
        }
        return null;
    }

}
