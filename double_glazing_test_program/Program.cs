using System;


namespace double_glazing_test_program
{
    internal class Program
    {
        
        static string vendorCode = default; //Артикул стеклопакета
        static int intimacy = default; //Камерность
        static int thicknessDoubleGlazing = default; //Толщина СП
        static int thicknessGlass = default; //Толщина стекла

        /// <summary>
        /// Разбор артикула, вычесление основных параметров
        /// </summary>
        /// <param name="vendorCode"></param>
        static void ArticleParsing( string vendorCode)
        {
            string glassNumber = default;
            string frameNumber = default;
            string glassNumber2 = default;
            string frameNumber2 = default;
            string glassNumber3 = default;
            string[] array = vendorCode.Split("/");
            if (array.Length == 3 )
            {
                new DoubleGlazing(array[0], array[1], array[2]);
                intimacy = 1;
                for (int i = 0; i < array[0].Length; i++ )
                {
                    if (char.IsDigit(array[0][i])) { glassNumber += array[0][i]; }
                    else break;
                }
                for (int i = 0; i < array[1].Length; i++ )
                {
                    if (char.IsDigit(array[1][i])) { frameNumber += array[1][i]; }
                    else break;
                }
                for (int i = 0; i < array[2].Length; i++ ) 
                {
                    if (char.IsDigit(array[2][i])) { glassNumber2 += array[2][i]; }
                    else break;
                }
                thicknessDoubleGlazing = Convert.ToInt32(glassNumber) + Convert.ToInt32(frameNumber) + Convert.ToInt32(glassNumber2);
                thicknessGlass = Convert.ToInt32(glassNumber) + Convert.ToInt32(glassNumber2);
            }
            else if (array.Length == 5 ) 
            { 
                new DoubleGlazing(array[0], array[1], array[2], array[3], array[4]);
                intimacy = 2;
                for (int i = 0; i < array[0].Length; i++)
                {
                    if (char.IsDigit(array[0][i])) { glassNumber += array[0][i]; }
                    else break;
                }
                for (int i = 0; i < array[1].Length; i++)
                {
                    if (char.IsDigit(array[1][i])) { frameNumber += array[1][i]; }
                    else break;
                }
                for (int i = 0; i < array[2].Length; i++)
                {
                    if (char.IsDigit(array[2][i])) { glassNumber2 += array[2][i]; }
                    else break;
                }
                for (int i = 0; i < array[3].Length; i++)
                {
                    if (char.IsDigit(array[3][i])) { frameNumber2 += array[3][i]; }
                    else break;
                }
                for (int i = 0; i < array[4].Length; i++)
                {
                    if (char.IsDigit(array[4][i])) { glassNumber3 += array[4][i]; }
                    else break;
                }
                thicknessDoubleGlazing = Convert.ToInt32(glassNumber) + Convert.ToInt32(frameNumber) + Convert.ToInt32(glassNumber2) + Convert.ToInt32(frameNumber2) + Convert.ToInt32(glassNumber3);
                thicknessGlass = Convert.ToInt32(glassNumber) + Convert.ToInt32(glassNumber2) + Convert.ToInt32(glassNumber3);
            }

            else
            {
                Console.WriteLine("Неверно введены данные");                            
            }

        }

        static void Main(string[] args)
        {           
            while(true)
            {
                Console.WriteLine("Программа расчёта стеклопакета" +
                "\nВведите артикул");
                vendorCode = Console.ReadLine();
                ArticleParsing(vendorCode);
                Console.WriteLine($"Камерность:{intimacy}   Толщина СП:{thicknessDoubleGlazing}   Толщина стекла:{thicknessGlass}");
                Console.ReadLine();
                Console.Clear();
            }          

        }
    }
}
