
namespace practProject1
{
    partial class Task4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tables = new System.Windows.Forms.RichTextBox();
            this.GenerateAnswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tables
            // 
            this.tables.Location = new System.Drawing.Point(13, 13);
            this.tables.Name = "tables";
            this.tables.Size = new System.Drawing.Size(463, 303);
            this.tables.TabIndex = 0;
            this.tables.Text = "";
            // 
            // GenerateAnswer
            // 
            this.GenerateAnswer.Location = new System.Drawing.Point(13, 323);
            this.GenerateAnswer.Name = "GenerateAnswer";
            this.GenerateAnswer.Size = new System.Drawing.Size(463, 44);
            this.GenerateAnswer.TabIndex = 1;
            this.GenerateAnswer.Text = "Сгенерировать таблицу и вывести ответ";
            this.GenerateAnswer.UseVisualStyleBackColor = true;
            this.GenerateAnswer.Click += new System.EventHandler(this.GenerateAnswer_Click);
            // 
            // Task4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 379);
            this.Controls.Add(this.GenerateAnswer);
            this.Controls.Add(this.tables);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Task4";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задание №4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox tables;
        private System.Windows.Forms.Button GenerateAnswer;
    }
}