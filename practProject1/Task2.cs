using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibMethods;

namespace practProject1
{
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        //Событие, в котором рассчитывается сумма 3 чисел, если они больше 5. 
        private void GetAnswer_Click(object sender, EventArgs e)
        {
            int[] mass = new int[] {(int)firstNumber.Value, (int)secondNumber.Value, (int)thridNumber.Value };
            TaskMethods task = new TaskMethods();
            answer.Text = task.SummThreeNumbers(mass).ToString();
        }
    }
}
