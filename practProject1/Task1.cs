using System;
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


        //Событитие, в котором определяется четность или нечетность последней цифры в двузначном числе
        private void GetAnswer_Click(object sender, EventArgs e)
        {
            bool returned;
            TaskMethods task1 = new TaskMethods();
            returned =  task1.EvenLastCifra((int)number.Value);
            if (returned == true)
            {
                answer.Text = "Последняя цифра является четной";
            }
            else
            {
                answer.Text = "Последняя цифра является нечетной";
            }            
        }
    }
}
