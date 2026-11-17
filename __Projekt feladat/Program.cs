using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace __Projekt_feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EnableVirtualTerminalProcessing();

            while (true)
            {
                Console.Write("\x1b[3J\x1b[2J\x1b[H");
                Console.Out.Flush();
                Jatek();

                bool ervenyesValasztas = false;
                while (!ervenyesValasztas)
                {
                    Console.WriteLine();
                    Console.WriteLine("Szeretnél újra játszani? [I]gen / [N]em");

                    switch (Console.ReadKey(true).KeyChar)
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

        static void EnableVirtualTerminalProcessing()
        {
            IntPtr outputHandle = GetStdHandle(-11);
            uint consoleMode;

            if (outputHandle != IntPtr.Zero && outputHandle != new IntPtr(-1) && GetConsoleMode(outputHandle, out consoleMode))
            {
                SetConsoleMode(outputHandle, consoleMode | 0x0004);
            }
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr GetStdHandle(int standardHandle);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool GetConsoleMode(IntPtr consoleHandle, out uint mode);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool SetConsoleMode(IntPtr consoleHandle, uint mode);

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
            ColorText("AZ ELFELEJTETT METRÓ", ConsoleColor.Cyan);
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
            bool telefonMukodik = veletlen.Next(0, 2) == 1;
            bool telefonProbalt = false;
            bool plazabolKijut = veletlen.Next(0, 4) == 0;
            bool folyosotProbalt = false;

            bool ervenyesKezdoValasztas = false;
            while (!ervenyesKezdoValasztas)
            {
                Console.WriteLine();
                Console.WriteLine("A pénztárfülkében valami megcsillan.");
                Console.WriteLine("[1] Vizsgáld meg a pénztárfülkét");
                Console.WriteLine("[2] Haladj tovább az alagút felé");

                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        zseblampa = true;
                        ColorText("Felvetted a zseblámpát.", ConsoleColor.Green);
                        ervenyesKezdoValasztas = true;
                        break;
                    case '2':
                        ColorText("A sötétben eltévedsz. A kaland véget ért.", ConsoleColor.Red);
                        return;
                    default:
                        ColorText("Érvénytelen választás. Próbáld újra!", ConsoleColor.Red);
                        break;
                }
            }

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("A peronon állsz. Mit teszel?");
                Console.WriteLine("[1] Kutass az elhagyatott szerelvényben");
                Console.WriteLine("[2] Vizsgáld meg az alagút végén lévő ajtót");
                Console.WriteLine("[3] Próbáld meg a falon lévő készüléket");
                Console.WriteLine("[4] Kövesd a folyosót a kijárat felé");
                Console.WriteLine("[5] Leltár megtekintése");

                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        if (!feszitovas)
                        {
                            feszitovas = true;
                            ColorText("A szerelvényben találtál egy feszítővasat.", ConsoleColor.Green);
                        }
                        else
                        {
                            Console.WriteLine("Már mindent átkutattál a szerelvényben.");
                        }
                        break;
                    case '2':
                        if (!feszitovas)
                        {
                            ColorText("Az ajtó feltöréséhez feszítővas kell. Keresd meg a szerelvényben!", ConsoleColor.Red);
                        }
                        else if (!zseblampa)
                        {
                            ColorText("A sötét alagútban nem látod az ajtót. Szükséged van a zseblámpára.", ConsoleColor.Red);
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
