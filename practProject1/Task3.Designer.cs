
namespace practProject1
{
    partial class Task3
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.answerMaxNumber = new System.Windows.Forms.TextBox();
            this.originalMass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.TextBox();
            this.GenerateAnswer = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.answer);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.originalMass);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.answerMaxNumber);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 241);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результат";
            // 
            // answerMaxNumber
            // 
            this.answerMaxNumber.Location = new System.Drawing.Point(11, 135);
            this.answerMaxNumber.Name = "answerMaxNumber";
            this.answerMaxNumber.ReadOnly = true;
            this.answerMaxNumber.Size = new System.Drawing.Size(309, 29);
            this.answerMaxNumber.TabIndex = 0;
            // 
            // originalMass
            // 
            this.originalMass.Location = new System.Drawing.Point(11, 66);
            this.originalMass.Name = "originalMass";
            this.originalMass.ReadOnly = true;
            this.originalMass.Size = new System.Drawing.Size(309, 29);
            this.originalMass.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Максимальный элемент массива";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Исходный массив";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(289, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Отклонения от максимального";
            // 
            // answer
            // 
            this.answer.Location = new System.Drawing.Point(11, 201);
            this.answer.Name = "answer";
            this.answer.ReadOnly = true;
            this.answer.Size = new System.Drawing.Size(309, 29);
            this.answer.TabIndex = 4;
            // 
            // GenerateAnswer
            // 
            this.GenerateAnswer.Location = new System.Drawing.Point(12, 259);
            this.GenerateAnswer.Name = "GenerateAnswer";
            this.GenerateAnswer.Size = new System.Drawing.Size(331, 65);
            this.GenerateAnswer.TabIndex = 2;
            this.GenerateAnswer.Text = "Сгенерировать массив и получить ответ";
            this.GenerateAnswer.UseVisualStyleBackColor = true;
            this.GenerateAnswer.Click += new System.EventHandler(this.GenerateAnswer_Click);
            // 
            // Task3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 336);
            this.Controls.Add(this.GenerateAnswer);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Task3";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задание №3";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox originalMass;
        private System.Windows.Forms.TextBox answerMaxNumber;
        private System.Windows.Forms.Button GenerateAnswer;
    }
}