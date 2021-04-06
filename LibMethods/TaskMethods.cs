using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMethods
{
    public class TaskMethods
    {
        public bool EvenLastCifra(int number)
        {
            number %= 10;
            if (number % 2 == 0) return true;
            else return false;
        }

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

        public void RejectionMaxMass(int[] mass, out int maxNumber, out int[] rejections)
        {
            maxNumber = 0;
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

        public void ExchangeMaxMinRows(double[,] table, out double[,] changedTable)
        {
            changedTable = new double[table.GetLength(0), table.GetLength(1)];
            double[] container = new double[table.GetLength(1)];            
            int rowMinPosition = 0;
            int rowMaxPosition = 0;
            double minNumber = table[0,0];
            double maxNumber = 0;
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
            for(int i = 0; i < container.Length; i++)
            {
                container[i] = table[rowMaxPosition, i];
            }
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
