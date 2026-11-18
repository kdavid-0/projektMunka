using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Projekt_feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ClearTerminal();
                Jatek();

                bool ervenyesValasztas = false;
                while (!ervenyesValasztas)
                {
                    Console.WriteLine();
                    Console.WriteLine("Szeretnél újra játszani? [I]gen / [N]em");

                    char valasztas = Console.ReadKey(true).KeyChar;

                    switch (valasztas)
                    {
                        case 'i':
                        case 'I':
                            ervenyesValasztas = true;
                            break;
                        case 'n':
                        case 'N':
                            return;
                        default:
                            ColorText("Kérlek, az I vagy az N billentyűt nyomd meg!", ConsoleColor.Red);
                            break;
                    }
                }
            }
        }

        static void ClearTerminal()
        {
            Console.Clear();
        }

        static void Jatek()
        {
            string nev;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"  ______                             __   ______            __                       __                 __      __                                     __                         ");
            Console.WriteLine(@" /      \                           |  \ /      \          |  \                     |  \               |  \    |  \                                   |  \                        ");
            Console.WriteLine(@"|  $$$$$$\ ________         ______  | $$|  $$$$$$\ ______  | $$  ______        __  _| $$_     ______  _| $$_  _| $$_          ______ ____    ______  _| $$_     ______    ______  ");
            Console.WriteLine(@"| $$__| $$|        \       /      \ | $$| $$_  \$$/      \ | $$ /      \      |  \|   $$ \   /      \|   $$ \|   $$ \        |      \    \  /      \|   $$ \|   $$ \         |");
            Console.WriteLine(@"| $$    $$ \$$$$$$$$      |  $$$$$$\| $$| $$ \   |  $$$$$$\| $$|  $$$$$$\      \$$ \$$$$$$  |  $$$$$$\\$$$$$$ \$$$$$$        | $$$$$$\$$$$\|  $$$$$$\\$$$$$$  |  $$$$$$\|  $$$$$$\");
            Console.WriteLine(@"| $$$$$$$$  /    $$       | $$    $$| $$| $$$$   | $$    $$| $$| $$    $$     |  \  | $$ __ | $$    $$ | $$ __ | $$ __       | $$ | $$ | $$| $$    $$ | $$ __ | $$   \$$| $$  | $$ ");
            Console.WriteLine(@"| $$  | $$ /  $$$$_       | $$$$$$$$| $$| $$     | $$$$$$$$| $$| $$$$$$$$     | $$  | $$|  \| $$$$$$$$ | $$|  \| $$|  \      | $$ | $$ | $$| $$$$$$$$ | $$|  \| $$      | $$__/ $$ ");
            Console.WriteLine(@"| $$  | $$|  $$    \       \$$     \| $$| $$      \$$     \| $$ \$$     \     | $$   \$$  $$ \$$     \  \$$  $$ \$$  $$      | $$ | $$ | $$ \$$     \  \$$  $$| $$       \$$    $$");
            Console.WriteLine(@" \$$   \$$ \$$$$$$$$        \$$$$$$$ \$$ \$$       \$$$$$$$ \$$  \$$$$$$$__   | $$    \$$$$   \$$$$$$$   \$$$$   \$$$$        \$$  \$$  \$$  \$$$$$$$   \$$$$  \$$        \$$$$$$ ");
            Console.WriteLine(@"                                                                        |  \__/ $$                                                                                                ");
            Console.WriteLine(@"                                                                         \$$    $$                                                                                                 ");
            Console.WriteLine(@"                                                                          \$$$$$$                                                                                                  ");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("     __________________________");
            Console.WriteLine("    |  __   __   __   __   __  |");
            Console.WriteLine("    | |  | |  | |  | |  | |  | |");
            Console.WriteLine("    |_|__|_|__|_|__|_|__|_|__|_|");
            Console.WriteLine("        O                  O");
            Console.ResetColor();
            Console.WriteLine();

            do
            {
                Console.Write("Add meg a neved: ");
                nev = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(nev))
                {
                    Console.WriteLine("A név nem maradhat üres!");
                }
            } while (string.IsNullOrWhiteSpace(nev));

            Console.WriteLine(nev + ", egy elhagyatott metróállomáson rekedtél. Juss ki a felszínre!");
            Console.WriteLine("Nyomj meg egy billentyűt a kezdéshez...");
            Console.ReadKey(true);

            bool zseblampa = false;
            bool feszitovas = false;
            Random veletlen = new Random();
            bool telefonMukodik;
            bool telefonProbalt = false;
            bool plazabolKijut;
            bool folyosotProbalt = false;

            bool ervenyesKezdoValasztas = false;
            while (!ervenyesKezdoValasztas)
            {
                Console.WriteLine();
                Console.WriteLine("A pénztárfülkében valami megcsillan.");
                Console.WriteLine("[1] Vizsgáld meg a pénztárfülkét");
                Console.WriteLine("[2] Haladj tovább az alagút felé");

                char kezdoValasztas = Console.ReadKey(true).KeyChar;

                switch (kezdoValasztas)
                {
                    case '1':
                        zseblampa = true;
                        ColorText("Felvetted a zseblámpát.", ConsoleColor.Green);
                        ervenyesKezdoValasztas = true;
                        break;
                    case '2':
                        ColorText("Elindulsz az alagútba, orientálódásod nehéz, de visszatalálsz a peronra.", ConsoleColor.Yellow);
                        ervenyesKezdoValasztas = true;
                        break;
                    default:
                        ColorText("Érvénytelen választás. Próbáld újra!", ConsoleColor.Red);
                        break;
                }
            }

            telefonMukodik = zseblampa
                ? veletlen.Next(0, 2) == 1
                : veletlen.Next(0, 4) == 0;
            plazabolKijut = zseblampa
                ? veletlen.Next(0, 4) == 0
                : veletlen.Next(0, 20) == 0;

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("A peronon állsz. Mit teszel?");
                Console.WriteLine("[1] Kutass az elhagyatott szerelvényben");
                Console.WriteLine("[2] Vizsgáld meg az alagút végén lévő ajtót");
                Console.WriteLine("[3] Próbáld meg a falon lévő készüléket");
                Console.WriteLine("[4] Kövesd a folyosót a kijárat felé");
                Console.WriteLine("[5] Leltár megtekintése");

                char peronValasztas = Console.ReadKey(true).KeyChar;

                switch (peronValasztas)
                {
                    case '1':
                        if (!feszitovas)
                        {
                            feszitovas = zseblampa || veletlen.Next(0, 137500) == 0;
                            if (feszitovas)
                            {
                                ColorText("A szerelvényben találtál egy feszítővasat.", ConsoleColor.Green);
                            }
                            else
                            {
                                ColorText("A zseblámpa hiányában alig látsz valamit. Nem találtál feszítővasat, próbálkozhatsz újra.", ConsoleColor.Red);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Már megtaláltad a feszítővasat.");
                        }
                        break;
                    case '2':
                        if (!feszitovas)
                        {
                            ColorText("Az ajtó feltöréséhez feszítővas kell. Keresd meg a szerelvényben!", ConsoleColor.Red);
                        }
                        else
                        {
                            Console.WriteLine("A feszítővassal feltöröd az ajtót, és kijutsz a felszínre.");
                            ColorText("Sikeresen kijutottál! Győztél!", ConsoleColor.Green);
                            return;
                        }
                        break;
                    case '3':
                        if (!telefonProbalt)
                        {
                            telefonProbalt = true;
                            if (telefonMukodik)
                            {
                                Console.WriteLine("A vezetékes telefon működik. Segítséget kérsz.");
                                ColorText("Nemsokára megérkezik a mentőcsapat. Kijutottál! Győztél!", ConsoleColor.Green);
                                return;
                            }

                            ColorText("A vezetékes telefon süket. Nem működik.", ConsoleColor.Red);
                        }
                        else
                        {
                            ColorText("A telefon továbbra sem működik.", ConsoleColor.Red);
                        }
                        break;
                    case '4':
                        if (!folyosotProbalt)
                        {
                            folyosotProbalt = true;
                            Console.WriteLine("A folyosó egy pláza hátsó bejáratához vezet. Odabent teljes a sötétség.");
                            Console.WriteLine("Mintha valami megmozdult volna, de nem látsz tisztán, így nem lehetsz biztos benne.");
                            if (plazabolKijut)
                            {
                                ColorText("Óvatosan átmész a plázán, és kijutsz. Hogy mi volt a sötétben, nem tudod.", ConsoleColor.Green);
                                return;
                            }

                            ColorText("Nem találod a kijáratot, ezért visszatérsz a peronra.", ConsoleColor.Red);
                        }
                        else
                        {
                            ColorText("Ezt a folyosót már bejártad, de nem találtál kijáratot.", ConsoleColor.Red);
                        }
                        break;
                    case '5':
                        Console.WriteLine("Leltár:");
                        bool uresLeltar = true;
                        if (zseblampa)
                        {
                            Console.WriteLine("- Zseblámpa");
                            uresLeltar = false;
                        }
                        if (feszitovas)
                        {
                            Console.WriteLine("- Feszítővas");
                            uresLeltar = false;
                        }
                        if (uresLeltar)
                        {
                            Console.WriteLine("A leltár üres.");
                        }
                        break;
                    default:
                        Console.WriteLine("Válassz az 1, 2, 3, 4 vagy 5 lehetőség közül.");
                        break;
                }
            }
        }

        static void ColorText(string szoveg, ConsoleColor szin)
        {
            Console.ForegroundColor = szin;
            Console.WriteLine(szoveg);
            Console.ResetColor();
        }
    }
}
