
namespace practProject1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Task4 = new System.Windows.Forms.Button();
            this.Task3 = new System.Windows.Forms.Button();
            this.Task2 = new System.Windows.Forms.Button();
            this.Task1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutUs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Task4);
            this.groupBox1.Controls.Add(this.Task3);
            this.groupBox1.Controls.Add(this.Task2);
            this.groupBox1.Controls.Add(this.Task1);
            this.groupBox1.Location = new System.Drawing.Point(15, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(275, 276);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Главное меню";
            // 
            // Task4
            // 
            this.Task4.Location = new System.Drawing.Point(18, 212);
            this.Task4.Name = "Task4";
            this.Task4.Size = new System.Drawing.Size(237, 51);
            this.Task4.TabIndex = 3;
            this.Task4.Text = "Задание №4";
            this.toolTip4.SetToolTip(this.Task4, "Дана матрица A(N, M). Строку, содержащей максимальный элемент, поменять местами с" +
        "о строкой, содержащей минимальный элемент.\r\n");
            this.Task4.UseVisualStyleBackColor = true;
            this.Task4.Click += new System.EventHandler(this.Task4_Click);
            // 
            // Task3
            // 
            this.Task3.Location = new System.Drawing.Point(18, 155);
            this.Task3.Name = "Task3";
            this.Task3.Size = new System.Drawing.Size(237, 51);
            this.Task3.TabIndex = 2;
            this.Task3.Text = "Задание №3";
            this.toolTip3.SetToolTip(this.Task3, "Дан массив. Требуется найти максимальное значение элнментов массива и отклонение " +
        "от максимального для каждого из чисел.\r\n");
            this.Task3.UseVisualStyleBackColor = true;
            this.Task3.Click += new System.EventHandler(this.Task3_Click);
            // 
            // Task2
            // 
            this.Task2.Location = new System.Drawing.Point(18, 98);
            this.Task2.Name = "Task2";
            this.Task2.Size = new System.Drawing.Size(237, 51);
            this.Task2.TabIndex = 1;
            this.Task2.Text = "Задание №2";
            this.toolTip2.SetToolTip(this.Task2, "Ввести три целых числа. Найти сумму тех чисел, которые больше пяти.\r\n");
            this.Task2.UseVisualStyleBackColor = true;
            this.Task2.Click += new System.EventHandler(this.Task2_Click);
            // 
            // Task1
            // 
            this.Task1.Location = new System.Drawing.Point(18, 41);
            this.Task1.Name = "Task1";
            this.Task1.Size = new System.Drawing.Size(237, 51);
            this.Task1.TabIndex = 0;
            this.Task1.Text = "Задание №1";
            this.toolTip1.SetToolTip(this.Task1, "Ввести двузначное число. Определить: оканчивается ли оно чётной цифрой.\r\n");
            this.Task1.UseVisualStyleBackColor = true;
            this.Task1.Click += new System.EventHandler(this.Task1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(305, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutUs});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // AboutUs
            // 
            this.AboutUs.Name = "AboutUs";
            this.AboutUs.Size = new System.Drawing.Size(180, 22);
            this.AboutUs.Text = "О программе";
            this.AboutUs.Click += new System.EventHandler(this.AboutUs_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 314);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Практическое задание";
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutUs;
        private System.Windows.Forms.Button Task4;
        private System.Windows.Forms.Button Task3;
        private System.Windows.Forms.Button Task2;
        private System.Windows.Forms.Button Task1;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

