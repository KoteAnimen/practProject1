using System;
using System.Windows.Forms;

namespace practProject1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //События, в которых вызывается окна с заданиями

        //Событие, где вызывается окно с заданием №1
        private void Task1_Click(object sender, EventArgs e)
        {
            Task1 task = new Task1();
            task.ShowDialog();
        }

        //Событие, где вызывается окно с заданием №2
        private void Task2_Click(object sender, EventArgs e)
        {
            Task2 task = new Task2();
            task.ShowDialog();
        }

        //Событие, где вызывается окно с заданием №3
        private void Task3_Click(object sender, EventArgs e)
        {
            Task3 task = new Task3();
            task.ShowDialog();
        }

        //Событие, где вызывается окно с заданием №4
        private void Task4_Click(object sender, EventArgs e)
        {
            Task4 task = new Task4();
            task.ShowDialog();
        }


        //Событие, где вызывается окно "О программе" 
        private void AboutUs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа разработана студентом группы ИСП-31 Филяком Ильёй", "О программе");
        }
    }
}
