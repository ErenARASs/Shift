using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // matrix fonksiyonunu cagirdim 
            int[,] matrix = Matrix();

            // matrixe cikti olarak cikarmak icin 
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }




        // oncelikle basta matrix olusturlacak  
        public static int[,] Matrix()
        {
            // bo; matrix olusturup ardindan icine yerlestirelecek olan eleman listesi yapip random fonksiyonunu cagirdim 
            int[,] matrix = new int[3, 3];
            List<int> list = new List<int> {1, 2,3, 4,5, 6,7, 8, 9 };
            Random rnd = new Random();

            // listeden random sectigim elemanlari once alip matrixe atayacagim ve ondan sonra onlari listeden silecegim ki tekrar kullanamayayim  
            for (int i=0; i<3; i++)
            {
                for (int j=0; j<3;j++)
                {
                    int element = rnd.Next(0, list.Count);
                    int value = list[element];
                    list.Remove(value);
                    matrix[i,j] = value;
                }
                
            }
            return matrix;
            
        }

        //olusturulan matrixi hamle oynama makenizmasi tasarlanacak 



        // board sistemi kurulacak



        // puan varmi sorgusu 


        // ana board sistemi kurulacak 
    }
}
