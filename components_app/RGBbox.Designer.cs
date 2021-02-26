namespace ControlsProject
{
    partial class Colour
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Красный = new System.Windows.Forms.Label();
            this.зеленый = new System.Windows.Forms.Label();
            this.синий = new System.Windows.Forms.Label();
            this.Dec = new System.Windows.Forms.RadioButton();
            this.Hex = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Blue = new ControlsProject.CustomTextBox(this.components);
            this.Green = new ControlsProject.CustomTextBox(this.components);
            this.Red = new ControlsProject.CustomTextBox(this.components);
            this.SuspendLayout();
            // 
            // Красный
            // 
            this.Красный.AutoSize = true;
            this.Красный.Location = new System.Drawing.Point(19, 19);
            this.Красный.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Красный.Name = "Красный";
            this.Красный.Size = new System.Drawing.Size(66, 17);
            this.Красный.TabIndex = 3;
            this.Красный.Text = "Красный";
            // 
            // зеленый
            // 
            this.зеленый.AutoSize = true;
            this.зеленый.Location = new System.Drawing.Point(19, 65);
            this.зеленый.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.зеленый.Name = "зеленый";
            this.зеленый.Size = new System.Drawing.Size(67, 17);
            this.зеленый.TabIndex = 4;
            this.зеленый.Text = "Зеленый";
            // 
            // синий
            // 
            this.синий.AutoSize = true;
            this.синий.Location = new System.Drawing.Point(19, 109);
            this.синий.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.синий.Name = "синий";
            this.синий.Size = new System.Drawing.Size(49, 17);
            this.синий.TabIndex = 5;
            this.синий.Text = "Синий";
            // 
            // Dec
            // 
            this.Dec.AutoSize = true;
            this.Dec.Checked = true;
            this.Dec.Location = new System.Drawing.Point(40, 151);
            this.Dec.Margin = new System.Windows.Forms.Padding(4);
            this.Dec.Name = "Dec";
            this.Dec.Size = new System.Drawing.Size(54, 21);
            this.Dec.TabIndex = 6;
            this.Dec.TabStop = true;
            this.Dec.Text = "Dec";
            this.Dec.UseVisualStyleBackColor = true;
            this.Dec.CheckedChanged += new System.EventHandler(this.Dec_CheckedChanged);
            // 
            // Hex
            // 
            this.Hex.AutoSize = true;
            this.Hex.Location = new System.Drawing.Point(111, 151);
            this.Hex.Margin = new System.Windows.Forms.Padding(4);
            this.Hex.Name = "Hex";
            this.Hex.Size = new System.Drawing.Size(53, 21);
            this.Hex.TabIndex = 7;
            this.Hex.Text = "Hex";
            this.Hex.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(230, 19);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 126);
            this.panel1.TabIndex = 8;
            // 
            // Blue
            // 
            this.Blue.IsDec = true;
            this.Blue.Location = new System.Drawing.Point(111, 106);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(79, 22);
            this.Blue.TabIndex = 11;
            this.Blue.Text = "0";
            this.Blue.TextChanged += new System.EventHandler(this.Blue_TextChanged);
            // 
            // Green
            // 
            this.Green.IsDec = true;
            this.Green.Location = new System.Drawing.Point(111, 62);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(79, 22);
            this.Green.TabIndex = 10;
            this.Green.Text = "0";
            this.Green.TextChanged += new System.EventHandler(this.Green_TextChanged);
            // 
            // Red
            // 
            this.Red.IsDec = true;
            this.Red.Location = new System.Drawing.Point(111, 19);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(79, 22);
            this.Red.TabIndex = 9;
            this.Red.Text = "0";
            this.Red.TextChanged += new System.EventHandler(this.Red_TextChanged);
            // 
            // Colour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Hex);
            this.Controls.Add(this.Dec);
            this.Controls.Add(this.синий);
            this.Controls.Add(this.зеленый);
            this.Controls.Add(this.Красный);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Colour";
            this.Size = new System.Drawing.Size(363, 176);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Красный;
        private System.Windows.Forms.Label зеленый;
        private System.Windows.Forms.Label синий;
        private System.Windows.Forms.RadioButton Dec;
        private System.Windows.Forms.RadioButton Hex;
        private System.Windows.Forms.Panel panel1;
        private CustomTextBox Red;
        private CustomTextBox Green;
        private CustomTextBox Blue;
    }
}
