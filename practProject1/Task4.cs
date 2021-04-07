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
    public partial class Task4 : Form
    {

        Random rnd = new Random();
        public Task4()
        {
            InitializeComponent();
        }

        private void GenerateAnswer_Click(object sender, EventArgs e)
        {
            tables.Clear();
            int amountRows = rnd.Next(3, 6);
            int amountColumns = rnd.Next(3, 6);
            TaskMethods task = new TaskMethods();
            double[,] matr = new double[amountRows, amountColumns];            
            double[,] changeMatr;
            tables.Text += "Исходная матрица" + "\n";
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    matr[i, j] = rnd.Next(-10, 10);
                    tables.Text += matr[i, j] + " ";
                }
                tables.Text += "\n";
            }
            task.ExchangeMaxMinRows(matr, out changeMatr);            
            
            tables.Text += "Измененная матрица" + "\n";
            for (int i = 0; i < changeMatr.GetLength(0); i++)
            {
                for (int j = 0; j < changeMatr.GetLength(1); j++)
                {
                    tables.Text += changeMatr[i, j] + " ";
                }
                tables.Text += "\n";
            }
        }
    }
}
