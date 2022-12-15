
namespace lb2
{
    partial class AddUniversity
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
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lFac = new System.Windows.Forms.Label();
            this.lLab = new System.Windows.Forms.Label();
            this.lLec = new System.Windows.Forms.Label();
            this.lStud = new System.Windows.Forms.Label();
            this.lTeach = new System.Windows.Forms.Label();
            this.lEngin = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.numUpDownFacs = new System.Windows.Forms.NumericUpDown();
            this.numUpDownLabs = new System.Windows.Forms.NumericUpDown();
            this.numUpDownLecs = new System.Windows.Forms.NumericUpDown();
            this.numUpDownStuds = new System.Windows.Forms.NumericUpDown();
            this.numUpDownTeachs = new System.Windows.Forms.NumericUpDown();
            this.numUpDownEngin = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownFacs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownLabs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownLecs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownStuds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTeachs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownEngin)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(21, 33);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(161, 21);
            this.label.TabIndex = 0;
            this.label.Text = "Назва університету";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Кількість:";
            // 
            // lFac
            // 
            this.lFac.AutoSize = true;
            this.lFac.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lFac.Location = new System.Drawing.Point(82, 117);
            this.lFac.Name = "lFac";
            this.lFac.Size = new System.Drawing.Size(100, 21);
            this.lFac.TabIndex = 2;
            this.lFac.Text = "Факільтетів";
            // 
            // lLab
            // 
            this.lLab.AutoSize = true;
            this.lLab.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lLab.Location = new System.Drawing.Point(75, 150);
            this.lLab.Name = "lLab";
            this.lLab.Size = new System.Drawing.Size(107, 21);
            this.lLab.TabIndex = 3;
            this.lLab.Text = "Лабораторій";
            // 
            // lLec
            // 
            this.lLec.AutoSize = true;
            this.lLec.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lLec.Location = new System.Drawing.Point(91, 185);
            this.lLec.Name = "lLec";
            this.lLec.Size = new System.Drawing.Size(91, 21);
            this.lLec.TabIndex = 4;
            this.lLec.Text = "Лекційних";
            // 
            // lStud
            // 
            this.lStud.AutoSize = true;
            this.lStud.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lStud.Location = new System.Drawing.Point(97, 226);
            this.lStud.Name = "lStud";
            this.lStud.Size = new System.Drawing.Size(85, 21);
            this.lStud.TabIndex = 5;
            this.lStud.Text = "Студентів";
            // 
            // lTeach
            // 
            this.lTeach.AutoSize = true;
            this.lTeach.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTeach.Location = new System.Drawing.Point(86, 265);
            this.lTeach.Name = "lTeach";
            this.lTeach.Size = new System.Drawing.Size(96, 21);
            this.lTeach.TabIndex = 6;
            this.lTeach.Text = "Викладачів";
            // 
            // lEngin
            // 
            this.lEngin.AutoSize = true;
            this.lEngin.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lEngin.Location = new System.Drawing.Point(94, 304);
            this.lEngin.Name = "lEngin";
            this.lEngin.Size = new System.Drawing.Size(88, 21);
            this.lEngin.TabIndex = 7;
            this.lEngin.Text = "Інженерів";
            // 
            // btAdd
            // 
            this.btAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btAdd.Location = new System.Drawing.Point(128, 385);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(117, 53);
            this.btAdd.TabIndex = 8;
            this.btAdd.Text = "Додати";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // tbName
            // 
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Location = new System.Drawing.Point(209, 32);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(158, 15);
            this.tbName.TabIndex = 9;
            // 
            // numUpDownFacs
            // 
            this.numUpDownFacs.Location = new System.Drawing.Point(236, 116);
            this.numUpDownFacs.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDownFacs.Name = "numUpDownFacs";
            this.numUpDownFacs.Size = new System.Drawing.Size(65, 22);
            this.numUpDownFacs.TabIndex = 10;
            // 
            // numUpDownLabs
            // 
            this.numUpDownLabs.Location = new System.Drawing.Point(236, 152);
            this.numUpDownLabs.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numUpDownLabs.Name = "numUpDownLabs";
            this.numUpDownLabs.Size = new System.Drawing.Size(65, 22);
            this.numUpDownLabs.TabIndex = 11;
            // 
            // numUpDownLecs
            // 
            this.numUpDownLecs.Location = new System.Drawing.Point(236, 187);
            this.numUpDownLecs.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numUpDownLecs.Name = "numUpDownLecs";
            this.numUpDownLecs.Size = new System.Drawing.Size(65, 22);
            this.numUpDownLecs.TabIndex = 12;
            // 
            // numUpDownStuds
            // 
            this.numUpDownStuds.Location = new System.Drawing.Point(236, 228);
            this.numUpDownStuds.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUpDownStuds.Name = "numUpDownStuds";
            this.numUpDownStuds.Size = new System.Drawing.Size(65, 22);
            this.numUpDownStuds.TabIndex = 13;
            // 
            // numUpDownTeachs
            // 
            this.numUpDownTeachs.Location = new System.Drawing.Point(236, 267);
            this.numUpDownTeachs.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUpDownTeachs.Name = "numUpDownTeachs";
            this.numUpDownTeachs.Size = new System.Drawing.Size(65, 22);
            this.numUpDownTeachs.TabIndex = 14;
            // 
            // numUpDownEngin
            // 
            this.numUpDownEngin.Location = new System.Drawing.Point(236, 306);
            this.numUpDownEngin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUpDownEngin.Name = "numUpDownEngin";
            this.numUpDownEngin.Size = new System.Drawing.Size(65, 22);
            this.numUpDownEngin.TabIndex = 15;
            // 
            // AddUniversity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 450);
            this.Controls.Add(this.numUpDownEngin);
            this.Controls.Add(this.numUpDownTeachs);
            this.Controls.Add(this.numUpDownStuds);
            this.Controls.Add(this.numUpDownLecs);
            this.Controls.Add(this.numUpDownLabs);
            this.Controls.Add(this.numUpDownFacs);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.lEngin);
            this.Controls.Add(this.lTeach);
            this.Controls.Add(this.lStud);
            this.Controls.Add(this.lLec);
            this.Controls.Add(this.lLab);
            this.Controls.Add(this.lFac);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Name = "AddUniversity";
            this.Text = "AddUniversity";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownFacs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownLabs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownLecs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownStuds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTeachs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownEngin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lFac;
        private System.Windows.Forms.Label lLab;
        private System.Windows.Forms.Label lLec;
        private System.Windows.Forms.Label lStud;
        private System.Windows.Forms.Label lTeach;
        private System.Windows.Forms.Label lEngin;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.NumericUpDown numUpDownFacs;
        private System.Windows.Forms.NumericUpDown numUpDownLabs;
        private System.Windows.Forms.NumericUpDown numUpDownLecs;
        private System.Windows.Forms.NumericUpDown numUpDownStuds;
        private System.Windows.Forms.NumericUpDown numUpDownTeachs;
        private System.Windows.Forms.NumericUpDown numUpDownEngin;
    }
}