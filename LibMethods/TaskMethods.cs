using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMethods
{
    public class TaskMethods
    {
        //Метод задания №1. Определить четная или нечетная ли последняя цифра в двузначном числе.
        public bool EvenLastCifra(int number)
        {
            number %= 10;            
            if (number % 2 == 0) return true;            
            else return false;
        }


        //Метод задания №2. Если 3 числа(или даже больше в моем случае) больше 5, то мы их складываем. 
        public int SummThreeNumbers(int[] numbers)
        {
            int summ = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] > 5)
                {
                    summ += numbers[i];
                }
            }
            return summ;
        }

        //Метод задания №3. Определить максимальное число в массиве и найти отклонение в каждом числе от максимального. 
        public void RejectionMaxMass(int[] mass, out int maxNumber, out int[] rejections)
        {
            maxNumber = mass[0];
            rejections = new int[mass.Length];
            for(int i = 0; i < mass.Length; i++)
            {
                if(mass[i] > maxNumber)
                {
                    maxNumber = mass[i];
                }
            }
            for(int i = 0; i < rejections.Length; i++)
            {
                rejections[i] = maxNumber - mass[i];
            }
        }

        //Метод задания №4. В таблице поменять местами строку, содержащей минимальный элемент таблицы, со строкой, содержащей макисмальный элемент.  
        public void ExchangeMaxMinRows(double[,] table, out double[,] changedTable)
        {
            changedTable = new double[table.GetLength(0), table.GetLength(1)];
            double[] container = new double[table.GetLength(1)];            
            int rowMinPosition = 0;
            int rowMaxPosition = 0;
            double minNumber = table[0,0];
            double maxNumber = 0;

            //Определяем позицию строк с максимальным и минимальныи элементами
            for(int i = 0; i < table.GetLength(0); i++)
            {
                for(int j = 0; j < table.GetLength(1); j++)
                {
                    changedTable[i, j] = table[i, j];
                    if(table[i,j] > maxNumber)
                    {
                        maxNumber = table[i, j];
                        rowMaxPosition = i;
                    }
                    if(table[i,j] < minNumber)
                    {
                        minNumber = table[i, j];
                        rowMinPosition = i;
                    }
                }
            }
            //записываем строку, содержащую максимальный элемент.
            for(int i = 0; i < container.Length; i++)
            {
                container[i] = table[rowMaxPosition, i];
            }

            //меняем местами строки методом "стаканчика"
            for(int i = 0; i < changedTable.GetLength(0); i++)
            {
                for(int j = 0; j < changedTable.GetLength(1); j++)
                {
                    if( i == rowMinPosition)
                    {
                        changedTable[rowMaxPosition, j] = changedTable[rowMinPosition, j];
                        changedTable[rowMinPosition, j] = container[j];
                    }
                } 
            }
        }

    }
}
