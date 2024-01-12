namespace DiffViewer_Project_1
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
            this.firstFileText = new System.Windows.Forms.RichTextBox();
            this.secondFileText = new System.Windows.Forms.RichTextBox();
            this.firstFilePath_Input = new System.Windows.Forms.TextBox();
            this.secondFilePath_Input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.updateFiles_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.openFIles_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstFileText
            // 
            this.firstFileText.Location = new System.Drawing.Point(46, 42);
            this.firstFileText.Name = "firstFileText";
            this.firstFileText.Size = new System.Drawing.Size(329, 384);
            this.firstFileText.TabIndex = 0;
            this.firstFileText.Text = "";
            this.firstFileText.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // secondFileText
            // 
            this.secondFileText.Location = new System.Drawing.Point(428, 42);
            this.secondFileText.Name = "secondFileText";
            this.secondFileText.Size = new System.Drawing.Size(337, 384);
            this.secondFileText.TabIndex = 1;
            this.secondFileText.Text = "";
            this.secondFileText.TextChanged += new System.EventHandler(this.secondFileText_TextChanged);
            // 
            // firstFilePath_Input
            // 
            this.firstFilePath_Input.Location = new System.Drawing.Point(119, 17);
            this.firstFilePath_Input.Name = "firstFilePath_Input";
            this.firstFilePath_Input.Size = new System.Drawing.Size(184, 20);
            this.firstFilePath_Input.TabIndex = 3;
            this.firstFilePath_Input.TextChanged += new System.EventHandler(this.firstFilePath_Input_TextChanged);
            // 
            // secondFilePath_Input
            // 
            this.secondFilePath_Input.Location = new System.Drawing.Point(512, 17);
            this.secondFilePath_Input.Name = "secondFilePath_Input";
            this.secondFilePath_Input.Size = new System.Drawing.Size(184, 20);
            this.secondFilePath_Input.TabIndex = 4;
            this.secondFilePath_Input.TextChanged += new System.EventHandler(this.secondFilePath_Input_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "File 1 Path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "File 2 Path";
            // 
            // updateFiles_button
            // 
            this.updateFiles_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.updateFiles_button.Location = new System.Drawing.Point(249, 432);
            this.updateFiles_button.Name = "updateFiles_button";
            this.updateFiles_button.Size = new System.Drawing.Size(316, 23);
            this.updateFiles_button.TabIndex = 7;
            this.updateFiles_button.Text = "--> Commit changes from file 1 to file 2 -->";
            this.updateFiles_button.UseVisualStyleBackColor = true;
            this.updateFiles_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(310, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Place your files in the Desktop folder";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // openFIles_button
            // 
            this.openFIles_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.openFIles_button.Location = new System.Drawing.Point(713, 14);
            this.openFIles_button.Name = "openFIles_button";
            this.openFIles_button.Size = new System.Drawing.Size(75, 23);
            this.openFIles_button.TabIndex = 9;
            this.openFIles_button.Text = "Open files";
            this.openFIles_button.UseVisualStyleBackColor = true;
            this.openFIles_button.Click += new System.EventHandler(this.openFIles_button_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(373, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "===>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.openFIles_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.updateFiles_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.secondFilePath_Input);
            this.Controls.Add(this.firstFilePath_Input);
            this.Controls.Add(this.secondFileText);
            this.Controls.Add(this.firstFileText);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "DiffViewer";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox firstFileText;
        private System.Windows.Forms.RichTextBox secondFileText;
        private System.Windows.Forms.TextBox firstFilePath_Input;
        private System.Windows.Forms.TextBox secondFilePath_Input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button updateFiles_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button openFIles_button;
        private System.Windows.Forms.Button button1;
    }
}

