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
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void GetAnswer_Click(object sender, EventArgs e)
        {
            int returned = 0;
            TaskMethods task1 = new TaskMethods();
            returned =  task1.EvenLastCifra((int)number.Value);
            if (returned == 0)
            {
                answer.Text = "Последняя цифра не является четной или нечетной";
            }
            if (returned == 1)
            {
                answer.Text = "Последняя цифра является четной";
            }
            if(returned == -1)
            {
                answer.Text = "Последняя цифра является нечетной";
            }
        }
    }
}
