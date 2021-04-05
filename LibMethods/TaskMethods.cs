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
            for(int i = 0; i < mass.Length; i++)
            {
                if(maxNumber - mass[i] != 0)
                {
                    rejections[i] = maxNumber - mass[i];
                }                
            }

        }

    }
}
