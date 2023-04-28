using System;
using System.Threading;

namespace Parcial2_Battleship
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("B");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("a");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("t");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("t");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("l");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("e");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("s");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("h");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("i");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("p");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("!");
            Console.ResetColor();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("B");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("a");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("t");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("a");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("l");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("l");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("a");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("a");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("v");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("a");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("l");
            Console.ResetColor();
            Console.WriteLine();

            int[,] tablerof = new int[3, 3];

            void sonido()
            {

                for (int i = 0; i < 3; i++)
                {


                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write("Haz tumbado un barco");

                    Console.ResetColor();
                    Console.WriteLine();

                    Thread.Sleep(500);
                    Console.Beep(2500, 500);
                    Console.Clear();
                    Thread.Sleep(500);

                }
            }


                void paso1_crear_tablerofacil()
            {
                for (int f = 0; f < tablerof.GetLength(0); f++)
                {
                    for (int c = 0; c < tablerof.GetLength(1); c++)
                    {
                        tablerof[f, c] = 0;
                    }
                }
            }

            void paso2_colocar_barcosfacil()
            {
                Random ranf = new Random();
                int filaf, columnaf;
                for (int x = 0; x < 1; x++)
                {
                    filaf = ranf.Next(0, 2);
                    columnaf = ranf.Next(0, 2);
                    tablerof[filaf, columnaf] = 1;
                }
            }

            void paso3_imprimir_tablerofacil()
            {
                String caracter_a_imprimir = "";
                for (int f = 0; f < tablerof.GetLength(0); f++)
                {
                    for (int c = 0; c < tablerof.GetLength(1); c++)
                    {
                        switch (tablerof[f, c])
                        {
                            case 0:
                                caracter_a_imprimir = "-";
                                break;
                            case 1:
                                caracter_a_imprimir = "-";

                                break;
                            case -1:
                                caracter_a_imprimir = "°";
                                break;
                            case -2:
                                caracter_a_imprimir = "X";
                                break;
                            case -3:
                                caracter_a_imprimir = "^";
                                break;
                            default:
                                caracter_a_imprimir = "-";
                                break;
                        }
                        Console.Write(caracter_a_imprimir + " ");
                    }
                    Console.WriteLine();
                }
            }

            void paso4_ingreso_cordenadasfacil()
            {
                int filaf, columnaf = 0;
                int contadorf = 0;
                int intentosf = 0;
                int total = 0;
                Console.Clear();


                do
                {
                    try
                    {
                        Console.Write("Ingrese la fila:");
                        filaf = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ingrese la columna:");
                        columnaf = Convert.ToInt32(Console.ReadLine());


                        if (tablerof[filaf, columnaf] == 1)
                        {

                            sonido();
                            tablerof[filaf, columnaf] = -1;
                            contadorf++;
                            total = contadorf + intentosf;
                        }
                        else
                        {
                            tablerof[filaf, columnaf] = -2;
                            intentosf++;
                        }

                        Console.Clear();

                        paso3_imprimir_tablerofacil();


                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Ingrese un valor valido");
                    }


                } while (contadorf < 1);
                Console.Clear();


                for (int i = 0; i < 3; i++)
                {
                    Console.OutputEncoding = System.Text.Encoding.Unicode; // Esto habilita la impresión de caracteres Unicode

                    Console.WriteLine("         ╭────────────╮         ");
                    Console.WriteLine("         │  GANASTE   |     ");
                    Console.WriteLine("╭────────╯            ╰────────╮");
                    Console.WriteLine("│                              │");
                    Console.WriteLine("│       ┏━━━━━━┓     ┏━━━━━━┓  │");
                    Console.WriteLine("│       ┃      ┃     ┃      ┃  │");
                    Console.WriteLine("│       ┃  ★   ┃     ┃  ★   ┃  │");
                    Console.WriteLine("│       ┃      ┃     ┃      ┃  │");
                    Console.WriteLine("│       ┗━━━━━━┛     ┗━━━━━━┛  │");
                    Console.WriteLine("│                              │");
                    Console.WriteLine("╰────────╮            ╭────────╯");
                    Console.WriteLine("         │ ¡Muy bien! │         ");
                    Console.WriteLine("         ╰────────────╯         ");

                    Console.WriteLine("Felicidades has tumbado todos los barcos \n y solo te ha tomado {0} intentos", total);



                    Thread.Sleep(700);
                    Console.Clear();
                    Thread.Sleep(700);

                }
                Console.OutputEncoding = System.Text.Encoding.Unicode; // Esto habilita la impresión de caracteres Unicode

                Console.WriteLine("         ╭────────────╮         ");
                Console.WriteLine("         │  GANASTE   |     ");
                Console.WriteLine("╭────────╯            ╰────────╮");
                Console.WriteLine("│                              │");
                Console.WriteLine("│       ┏━━━━━━┓     ┏━━━━━━┓  │");
                Console.WriteLine("│       ┃      ┃     ┃      ┃  │");
                Console.WriteLine("│       ┃  ★   ┃     ┃   ★  ┃  │");
                Console.WriteLine("│       ┃      ┃     ┃      ┃  │");
                Console.WriteLine("│       ┗━━━━━━┛     ┗━━━━━━┛  │");
                Console.WriteLine("│                              │");
                Console.WriteLine("╰────────╮            ╭────────╯");
                Console.WriteLine("         │ ¡Muy bien! │         ");
                Console.WriteLine("         ╰────────────╯         ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("Felicidades has tumbado todos los barcos \n y solo te ha tomado {0} intentos", total);

            }

            paso1_crear_tablerofacil();
            paso2_colocar_barcosfacil();

            paso4_ingreso_cordenadasfacil();
            Console.ReadLine();
        }
    }
}
