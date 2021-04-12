using System;
using System.Windows.Forms;
using LibMethods;

namespace practProject1
{
    public partial class Task3 : Form
    {

        Random rnd = new Random();
        int sizeMass;
        int minNumber;
        int maxNumber;
        int max;
        int[] rejections;
        public Task3()
        {
            InitializeComponent();
        }

        //Событие, в котором генерируется массив, после чего находится максимальное значение и отклонения.
        private void GenerateAnswer_Click(object sender, EventArgs e)
        {
            originalMass.Clear();
            answer.Clear();
            TaskMethods task = new TaskMethods();
            minNumber = rnd.Next(-100, -1);
            maxNumber = rnd.Next(0, 100);
            sizeMass = rnd.Next(3, 8);
            int[] mass = new int[sizeMass];
            for (int i = 0; i < (int)sizeMass; i++)
            {
                mass[i] = rnd.Next((int)minNumber, (int)maxNumber);
                originalMass.Text += mass[i] + " ";
            }
            task.RejectionMaxMass(mass, out max, out rejections);
            answerMaxNumber.Text = max.ToString();
            for(int i = 0; i < sizeMass; i++)
            {
                answer.Text += rejections[i].ToString() + " "; 
            }
        }        
    }
}
