
namespace lb2
{
    partial class InputOutput
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
            this.rbOutputUniver = new System.Windows.Forms.RadioButton();
            this.rbOutputLectors = new System.Windows.Forms.RadioButton();
            this.rbOutputEngineers = new System.Windows.Forms.RadioButton();
            this.btOutputInFile = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btInputFromFile = new System.Windows.Forms.Button();
            this.rbInputEngineers = new System.Windows.Forms.RadioButton();
            this.rbInputLectors = new System.Windows.Forms.RadioButton();
            this.rbInputUniver = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbOutputUniver
            // 
            this.rbOutputUniver.AutoSize = true;
            this.rbOutputUniver.Location = new System.Drawing.Point(4, 19);
            this.rbOutputUniver.Name = "rbOutputUniver";
            this.rbOutputUniver.Size = new System.Drawing.Size(147, 17);
            this.rbOutputUniver.TabIndex = 0;
            this.rbOutputUniver.TabStop = true;
            this.rbOutputUniver.Text = "Університет + аудиторії ";
            this.rbOutputUniver.UseVisualStyleBackColor = true;
            // 
            // rbOutputLectors
            // 
            this.rbOutputLectors.AutoSize = true;
            this.rbOutputLectors.Location = new System.Drawing.Point(6, 62);
            this.rbOutputLectors.Name = "rbOutputLectors";
            this.rbOutputLectors.Size = new System.Drawing.Size(68, 17);
            this.rbOutputLectors.TabIndex = 1;
            this.rbOutputLectors.TabStop = true;
            this.rbOutputLectors.Text = "Лектори";
            this.rbOutputLectors.UseVisualStyleBackColor = true;
            // 
            // rbOutputEngineers
            // 
            this.rbOutputEngineers.AutoSize = true;
            this.rbOutputEngineers.Location = new System.Drawing.Point(6, 85);
            this.rbOutputEngineers.Name = "rbOutputEngineers";
            this.rbOutputEngineers.Size = new System.Drawing.Size(72, 17);
            this.rbOutputEngineers.TabIndex = 2;
            this.rbOutputEngineers.TabStop = true;
            this.rbOutputEngineers.Text = "Інженери";
            this.rbOutputEngineers.UseVisualStyleBackColor = true;
            // 
            // btOutputInFile
            // 
            this.btOutputInFile.Location = new System.Drawing.Point(6, 108);
            this.btOutputInFile.Name = "btOutputInFile";
            this.btOutputInFile.Size = new System.Drawing.Size(102, 27);
            this.btOutputInFile.TabIndex = 3;
            this.btOutputInFile.Text = "Вивести";
            this.btOutputInFile.UseVisualStyleBackColor = true;
            this.btOutputInFile.Click += new System.EventHandler(this.btOutputInFile_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(287, 204);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(102, 27);
            this.btExit.TabIndex = 4;
            this.btExit.Text = "Скасувати";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btInputFromFile
            // 
            this.btInputFromFile.Location = new System.Drawing.Point(0, 110);
            this.btInputFromFile.Name = "btInputFromFile";
            this.btInputFromFile.Size = new System.Drawing.Size(102, 27);
            this.btInputFromFile.TabIndex = 8;
            this.btInputFromFile.Text = "Ввести";
            this.btInputFromFile.UseVisualStyleBackColor = true;
            this.btInputFromFile.Click += new System.EventHandler(this.btInputFromFile_Click);
            // 
            // rbInputEngineers
            // 
            this.rbInputEngineers.AutoSize = true;
            this.rbInputEngineers.Location = new System.Drawing.Point(6, 87);
            this.rbInputEngineers.Name = "rbInputEngineers";
            this.rbInputEngineers.Size = new System.Drawing.Size(72, 17);
            this.rbInputEngineers.TabIndex = 7;
            this.rbInputEngineers.TabStop = true;
            this.rbInputEngineers.Text = "Інженери";
            this.rbInputEngineers.UseVisualStyleBackColor = true;
            // 
            // rbInputLectors
            // 
            this.rbInputLectors.AutoSize = true;
            this.rbInputLectors.Location = new System.Drawing.Point(6, 64);
            this.rbInputLectors.Name = "rbInputLectors";
            this.rbInputLectors.Size = new System.Drawing.Size(68, 17);
            this.rbInputLectors.TabIndex = 6;
            this.rbInputLectors.TabStop = true;
            this.rbInputLectors.Text = "Лектори";
            this.rbInputLectors.UseVisualStyleBackColor = true;
            // 
            // rbInputUniver
            // 
            this.rbInputUniver.AutoSize = true;
            this.rbInputUniver.Location = new System.Drawing.Point(6, 19);
            this.rbInputUniver.Name = "rbInputUniver";
            this.rbInputUniver.Size = new System.Drawing.Size(144, 17);
            this.rbInputUniver.TabIndex = 5;
            this.rbInputUniver.TabStop = true;
            this.rbInputUniver.Text = "Університет + аудиторії";
            this.rbInputUniver.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btOutputInFile);
            this.groupBox1.Controls.Add(this.rbOutputEngineers);
            this.groupBox1.Controls.Add(this.rbOutputLectors);
            this.groupBox1.Controls.Add(this.rbOutputUniver);
            this.groupBox1.Location = new System.Drawing.Point(185, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 143);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вивести у файл";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btInputFromFile);
            this.groupBox2.Controls.Add(this.rbInputEngineers);
            this.groupBox2.Controls.Add(this.rbInputLectors);
            this.groupBox2.Controls.Add(this.rbInputUniver);
            this.groupBox2.Location = new System.Drawing.Point(12, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 145);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ввести з файлу";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "+ інженери";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "+ інженери";
            // 
            // InputOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 243);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btExit);
            this.Name = "InputOutput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputOutput";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbOutputUniver;
        private System.Windows.Forms.RadioButton rbOutputLectors;
        private System.Windows.Forms.RadioButton rbOutputEngineers;
        private System.Windows.Forms.Button btOutputInFile;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btInputFromFile;
        private System.Windows.Forms.RadioButton rbInputEngineers;
        private System.Windows.Forms.RadioButton rbInputLectors;
        private System.Windows.Forms.RadioButton rbInputUniver;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}