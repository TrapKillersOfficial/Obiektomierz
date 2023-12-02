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
                            // wsp wektora
                            pentla3 = true;
                            while (pentla3)
                            {
                                string wyb = Wybor();

                                if (wyb == "2") // dwuwymiarowy
                                {
                                    List<double> odp = Wsp2();
                                    Console.WriteLine($"\nWspółrzędne wektora to: [{odp[0]} | {odp[1]}]");
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
                                else // trujwymiarowy
                                {
                                    List<double> odp = Wsp3();
                                    Console.WriteLine($"\nWspółrzędne wektora to: {odp[0]} | {odp[1]} | {odp[2]}");
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
                            // dlugosc wektora
                            pentla3 = true;
                            while (pentla3)
                            {
                                string wyb = Wybor();

                                if (wyb == "2")
                                {
                                    List<double> lista = Wsp2();
                                    double odp = Dlugosc(lista);
                                    Console.WriteLine($"\nDługość wektora wynosi: {odp}");

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
                                    List<double> lista = Wsp3();
                                    double odp = Dlugosc(lista);
                                    
                                    Console.WriteLine($"\nDługość wektora wynosi: {odp}");
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
                    case "3":
                        {
                            // dodawanie wektorow
                            pentla3 = true;
                            while (pentla3)
                            {
                                string wyb = Wybor();

                                if (wyb == "2")
                                {
                                    Console.WriteLine("\nWprowadź współrzędne pierwszego wektora:\n ");
                                    List<double> lista1 = Wsp2();
                                    Console.WriteLine("\nWprowadź współrzędne drugiego wektora:\n ");
                                    List<double> lista2 = Wsp2();
                                    List<double> odp = Dodawanie(lista1,lista2);
                                    Console.WriteLine($"\nSuma dwóch wektorów daje wektor o współrzędnych: [{odp[0]} | {odp[1]}]");

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
                                    Console.WriteLine("\nWprowadź współrzędne pierwszego wektora:\n ");
                                    List<double> lista1 = Wsp2();
                                    Console.WriteLine("\nWprowadź współrzędne drugiego wektora:\n ");
                                    List<double> lista2 = Wsp2();
                                    List<double> odp = Dodawanie(lista1, lista2);
                                    Console.WriteLine($"\nSuma dwóch wektorów daje wektor o współrzędnych: [{odp[0]} | {odp[1]} | {odp[2]}]");

                                    Console.WriteLine($"\nDługość wektora wynosi: {odp}");
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

    public static List<double> Wsp2()
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
                List<double> XY = new List<double> { X, Y };
                List<double> roundXY = new List<double> {};
                foreach (double i in XY)
                {
                    roundXY.Add(Math.Round(i,4));
                }
                pentla = false;
                return roundXY;
            }
            catch
            {
                Console.WriteLine("\nBłedny kod wyboru!\n");
            }
        }
        return null;
    }

    public static List<double> Wsp3()
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
                List<double> XYZ = new List<double> {X,Y,Z};
                List<double> roundXYZ = new List<double> { };
                foreach (double i in XYZ)
                {
                    roundXYZ.Add(Math.Round(i, 4));
                }
                pentla = false;
                return XYZ;
            }
            catch
            {
                Console.WriteLine("\nBłedny kod wyboru!\n");
            }
        }
        return null;
    }

    public static double Dlugosc(List<double> wsp) 
    {
        List<double> potega = new List<double>();
        foreach (double i in wsp)
        {
            potega.Add(Math.Pow(i, 2));
        }
        double dl = Math.Sqrt(potega.Sum());
        dl = Math.Round(dl,4);
        return dl;
    }

    public static List<double> Dodawanie(List<double> lista1, List<double> lista2)
    {
        List<double> listaSuma = new List<double>();
        if (lista1.Count == 2)
        {
            listaSuma.Add(lista1[0]+lista2[0]);
            listaSuma.Add(lista1[1]+lista2[1]);
        }
        else
        {
            listaSuma.Add(lista1[0] + lista2[0]);
            listaSuma.Add(lista1[1] + lista2[1]);
            listaSuma.Add(lista1[2] + lista2[2]);
        }
        return listaSuma;   
    }
}
