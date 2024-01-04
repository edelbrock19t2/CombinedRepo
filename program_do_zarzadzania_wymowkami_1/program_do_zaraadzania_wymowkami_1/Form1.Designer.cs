namespace program_do_zaraadzania_wymowkami_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.execuseTextBox = new System.Windows.Forms.TextBox();
            this.wynikiTextBox = new System.Windows.Forms.TextBox();
            this.lastUsed = new System.Windows.Forms.DateTimePicker();
            this.folderButton = new System.Windows.Forms.Button();
            this.randomExecuseButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.fileDate = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wymówka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wyniki";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ostatnio użyte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data pliku";
            // 
            // execuseTextBox
            // 
            this.execuseTextBox.Location = new System.Drawing.Point(101, 18);
            this.execuseTextBox.Name = "execuseTextBox";
            this.execuseTextBox.Size = new System.Drawing.Size(142, 20);
            this.execuseTextBox.TabIndex = 4;
            this.execuseTextBox.TextChanged += new System.EventHandler(this.execuseTextBox_TextChanged);
            // 
            // wynikiTextBox
            // 
            this.wynikiTextBox.Location = new System.Drawing.Point(101, 54);
            this.wynikiTextBox.Name = "wynikiTextBox";
            this.wynikiTextBox.Size = new System.Drawing.Size(142, 20);
            this.wynikiTextBox.TabIndex = 6;
            this.wynikiTextBox.TextChanged += new System.EventHandler(this.wynikiTextBox_TextChanged);
            // 
            // lastUsed
            // 
            this.lastUsed.Location = new System.Drawing.Point(101, 87);
            this.lastUsed.Name = "lastUsed";
            this.lastUsed.Size = new System.Drawing.Size(188, 20);
            this.lastUsed.TabIndex = 8;
            this.lastUsed.ValueChanged += new System.EventHandler(this.lastUsed_ValueChanged);
            // 
            // folderButton
            // 
            this.folderButton.Location = new System.Drawing.Point(69, 140);
            this.folderButton.Name = "folderButton";
            this.folderButton.Size = new System.Drawing.Size(75, 23);
            this.folderButton.TabIndex = 9;
            this.folderButton.Text = "Folder";
            this.folderButton.UseVisualStyleBackColor = true;
            this.folderButton.Click += new System.EventHandler(this.folderButton_Click);
            // 
            // randomExecuseButton
            // 
            this.randomExecuseButton.Location = new System.Drawing.Point(249, 18);
            this.randomExecuseButton.Name = "randomExecuseButton";
            this.randomExecuseButton.Size = new System.Drawing.Size(108, 23);
            this.randomExecuseButton.TabIndex = 10;
            this.randomExecuseButton.Text = "Losowa wymówka";
            this.randomExecuseButton.UseVisualStyleBackColor = true;
            this.randomExecuseButton.Click += new System.EventHandler(this.randomExecuseButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(231, 140);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 11;
            this.openButton.Text = "Otwórz";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(150, 140);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Zapisz";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // fileDate
            // 
            this.fileDate.Location = new System.Drawing.Point(101, 114);
            this.fileDate.Name = "fileDate";
            this.fileDate.ReadOnly = true;
            this.fileDate.Size = new System.Drawing.Size(142, 20);
            this.fileDate.TabIndex = 13;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 176);
            this.Controls.Add(this.fileDate);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.randomExecuseButton);
            this.Controls.Add(this.folderButton);
            this.Controls.Add(this.lastUsed);
            this.Controls.Add(this.wynikiTextBox);
            this.Controls.Add(this.execuseTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox execuseTextBox;
        private System.Windows.Forms.TextBox wynikiTextBox;
        private System.Windows.Forms.DateTimePicker lastUsed;
        private System.Windows.Forms.Button folderButton;
        private System.Windows.Forms.Button randomExecuseButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox fileDate;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

