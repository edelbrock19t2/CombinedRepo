namespace Second_Window_App_11._5
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.enableCheckbox = new System.Windows.Forms.CheckBox();
            this.output = new System.Windows.Forms.TextBox();
            this.labelToChange = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kliknięcie zmienia etykietę";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // enableCheckbox
            // 
            this.enableCheckbox.AutoSize = true;
            this.enableCheckbox.Location = new System.Drawing.Point(507, 117);
            this.enableCheckbox.Name = "enableCheckbox";
            this.enableCheckbox.Size = new System.Drawing.Size(139, 17);
            this.enableCheckbox.TabIndex = 1;
            this.enableCheckbox.Text = "Włącza zmianę etykiety";
            this.enableCheckbox.UseVisualStyleBackColor = true;
            this.enableCheckbox.CheckedChanged += new System.EventHandler(this.enableCheckbox_CheckedChanged);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(261, 280);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(211, 20);
            this.output.TabIndex = 2;
            this.output.Text = "Naciśnij przycisk, aby zmienić tekst";
            this.output.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelToChange
            // 
            this.labelToChange.AutoSize = true;
            this.labelToChange.Location = new System.Drawing.Point(275, 320);
            this.labelToChange.Name = "labelToChange";
            this.labelToChange.Size = new System.Drawing.Size(172, 13);
            this.labelToChange.TabIndex = 3;
            this.labelToChange.Text = "Naciśnij przycisk, aby zmienić tekst";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelToChange);
            this.Controls.Add(this.output);
            this.Controls.Add(this.enableCheckbox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox enableCheckbox;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Label labelToChange;
    }
}

