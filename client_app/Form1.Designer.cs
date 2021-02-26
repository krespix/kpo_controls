namespace lab_5
{
    partial class Form1
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
            this.colour1 = new ControlsProject.Colour();
            this.SuspendLayout();
            // 
            // colour1
            // 
            this.colour1.AutoSize = true;
            this.colour1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.colour1.PanelColor = System.Drawing.Color.Black;
            this.colour1.Location = new System.Drawing.Point(14, 14);
            this.colour1.Margin = new System.Windows.Forms.Padding(5);
            this.colour1.Name = "colour1";
            this.colour1.Size = new System.Drawing.Size(363, 176);
            this.colour1.TabIndex = 0;
            this.colour1.Load += new System.EventHandler(this.colour1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 210);
            this.Controls.Add(this.colour1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlsProject.Colour colour1;
    }
}

