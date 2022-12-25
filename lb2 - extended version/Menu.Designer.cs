
namespace lb2
{
    partial class Menu
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
            this.lbUniversities = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lLabs = new System.Windows.Forms.Label();
            this.lLec = new System.Windows.Forms.Label();
            this.lTeach = new System.Windows.Forms.Label();
            this.lEngin = new System.Windows.Forms.Label();
            this.btAddUniversity = new System.Windows.Forms.Button();
            this.btDeleteUniversity = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btCompare = new System.Windows.Forms.Button();
            this.lL = new System.Windows.Forms.Label();
            this.lLc = new System.Windows.Forms.Label();
            this.lT = new System.Windows.Forms.Label();
            this.lE = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.lN = new System.Windows.Forms.Label();
            this.lIngen = new System.Windows.Forms.Label();
            this.tbClassOperations = new System.Windows.Forms.Button();
            this.LLectories = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btInputOutput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbUniversities
            // 
            this.lbUniversities.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUniversities.FormattingEnabled = true;
            this.lbUniversities.ItemHeight = 17;
            this.lbUniversities.Location = new System.Drawing.Point(261, 78);
            this.lbUniversities.Margin = new System.Windows.Forms.Padding(2);
            this.lbUniversities.Name = "lbUniversities";
            this.lbUniversities.Size = new System.Drawing.Size(223, 208);
            this.lbUniversities.TabIndex = 0;
            this.lbUniversities.SelectedIndexChanged += new System.EventHandler(this.lbUniversities_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(209, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "УНІВЕРСИТЕТ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Інформація";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(505, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Операції";
            // 
            // lLabs
            // 
            this.lLabs.AutoSize = true;
            this.lLabs.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lLabs.Location = new System.Drawing.Point(0, 100);
            this.lLabs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lLabs.Name = "lLabs";
            this.lLabs.Size = new System.Drawing.Size(103, 18);
            this.lLabs.TabIndex = 5;
            this.lLabs.Text = "Лабораторні:";
            // 
            // lLec
            // 
            this.lLec.AutoSize = true;
            this.lLec.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lLec.Location = new System.Drawing.Point(24, 128);
            this.lLec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lLec.Name = "lLec";
            this.lLec.Size = new System.Drawing.Size(84, 18);
            this.lLec.TabIndex = 6;
            this.lLec.Text = "Аудиторії:";
            // 
            // lTeach
            // 
            this.lTeach.AutoSize = true;
            this.lTeach.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTeach.Location = new System.Drawing.Point(11, 188);
            this.lTeach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lTeach.Name = "lTeach";
            this.lTeach.Size = new System.Drawing.Size(88, 18);
            this.lTeach.TabIndex = 8;
            this.lTeach.Text = "Викладачі:";
            // 
            // lEngin
            // 
            this.lEngin.AutoSize = true;
            this.lEngin.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lEngin.Location = new System.Drawing.Point(15, 217);
            this.lEngin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lEngin.Name = "lEngin";
            this.lEngin.Size = new System.Drawing.Size(84, 18);
            this.lEngin.TabIndex = 9;
            this.lEngin.Text = "Інженери:";
            // 
            // btAddUniversity
            // 
            this.btAddUniversity.Location = new System.Drawing.Point(190, 296);
            this.btAddUniversity.Margin = new System.Windows.Forms.Padding(2);
            this.btAddUniversity.Name = "btAddUniversity";
            this.btAddUniversity.Size = new System.Drawing.Size(97, 47);
            this.btAddUniversity.TabIndex = 10;
            this.btAddUniversity.Text = "Додати університет";
            this.btAddUniversity.UseVisualStyleBackColor = true;
            this.btAddUniversity.Click += new System.EventHandler(this.btAddUniversity_Click);
            // 
            // btDeleteUniversity
            // 
            this.btDeleteUniversity.Location = new System.Drawing.Point(320, 296);
            this.btDeleteUniversity.Margin = new System.Windows.Forms.Padding(2);
            this.btDeleteUniversity.Name = "btDeleteUniversity";
            this.btDeleteUniversity.Size = new System.Drawing.Size(92, 47);
            this.btDeleteUniversity.TabIndex = 11;
            this.btDeleteUniversity.Text = "Видалити університет";
            this.btDeleteUniversity.UseVisualStyleBackColor = true;
            this.btDeleteUniversity.Click += new System.EventHandler(this.btDeleteUniversity_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(503, 87);
            this.btAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(82, 46);
            this.btAdd.TabIndex = 12;
            this.btAdd.Text = "Додати";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btCompare
            // 
            this.btCompare.Location = new System.Drawing.Point(503, 148);
            this.btCompare.Margin = new System.Windows.Forms.Padding(2);
            this.btCompare.Name = "btCompare";
            this.btCompare.Size = new System.Drawing.Size(82, 46);
            this.btCompare.TabIndex = 14;
            this.btCompare.Text = "Порівняти";
            this.btCompare.UseVisualStyleBackColor = true;
            this.btCompare.Click += new System.EventHandler(this.btCompare_Click);
            // 
            // lL
            // 
            this.lL.AutoSize = true;
            this.lL.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lL.Location = new System.Drawing.Point(112, 98);
            this.lL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lL.Name = "lL";
            this.lL.Size = new System.Drawing.Size(0, 18);
            this.lL.TabIndex = 17;
            // 
            // lLc
            // 
            this.lLc.AutoSize = true;
            this.lLc.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lLc.Location = new System.Drawing.Point(112, 126);
            this.lLc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lLc.Name = "lLc";
            this.lLc.Size = new System.Drawing.Size(0, 18);
            this.lLc.TabIndex = 18;
            // 
            // lT
            // 
            this.lT.AutoSize = true;
            this.lT.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lT.Location = new System.Drawing.Point(110, 187);
            this.lT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lT.Name = "lT";
            this.lT.Size = new System.Drawing.Size(0, 18);
            this.lT.TabIndex = 20;
            // 
            // lE
            // 
            this.lE.AutoSize = true;
            this.lE.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lE.Location = new System.Drawing.Point(110, 215);
            this.lE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lE.Name = "lE";
            this.lE.Size = new System.Drawing.Size(0, 18);
            this.lE.TabIndex = 21;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lName.Location = new System.Drawing.Point(19, 76);
            this.lName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lName.Name = "lName";
            this.lName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lName.Size = new System.Drawing.Size(56, 18);
            this.lName.TabIndex = 22;
            this.lName.Text = "Назва:";
            // 
            // lN
            // 
            this.lN.AutoSize = true;
            this.lN.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lN.Location = new System.Drawing.Point(77, 76);
            this.lN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lN.Name = "lN";
            this.lN.Size = new System.Drawing.Size(0, 18);
            this.lN.TabIndex = 23;
            // 
            // lIngen
            // 
            this.lIngen.AutoSize = true;
            this.lIngen.Location = new System.Drawing.Point(109, 193);
            this.lIngen.Name = "lIngen";
            this.lIngen.Size = new System.Drawing.Size(0, 13);
            this.lIngen.TabIndex = 24;
            // 
            // tbClassOperations
            // 
            this.tbClassOperations.Location = new System.Drawing.Point(503, 209);
            this.tbClassOperations.Name = "tbClassOperations";
            this.tbClassOperations.Size = new System.Drawing.Size(86, 44);
            this.tbClassOperations.TabIndex = 25;
            this.tbClassOperations.Text = "Модифікувати";
            this.tbClassOperations.UseVisualStyleBackColor = true;
            this.tbClassOperations.Click += new System.EventHandler(this.tbClassOperations_Click);
            // 
            // LLectories
            // 
            this.LLectories.AutoSize = true;
            this.LLectories.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LLectories.Location = new System.Drawing.Point(111, 159);
            this.LLectories.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LLectories.Name = "LLectories";
            this.LLectories.Size = new System.Drawing.Size(0, 18);
            this.LLectories.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(23, 161);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 26;
            this.label5.Text = "Лекційні:";
            // 
            // btInputOutput
            // 
            this.btInputOutput.Location = new System.Drawing.Point(503, 269);
            this.btInputOutput.Name = "btInputOutput";
            this.btInputOutput.Size = new System.Drawing.Size(86, 39);
            this.btInputOutput.TabIndex = 28;
            this.btInputOutput.Text = "Ввести / вивести";
            this.btInputOutput.UseVisualStyleBackColor = true;
            this.btInputOutput.Click += new System.EventHandler(this.btInputOutput_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btInputOutput);
            this.Controls.Add(this.LLectories);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbClassOperations);
            this.Controls.Add(this.lIngen);
            this.Controls.Add(this.lN);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.lE);
            this.Controls.Add(this.lT);
            this.Controls.Add(this.lLc);
            this.Controls.Add(this.lL);
            this.Controls.Add(this.btCompare);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btDeleteUniversity);
            this.Controls.Add(this.btAddUniversity);
            this.Controls.Add(this.lEngin);
            this.Controls.Add(this.lTeach);
            this.Controls.Add(this.lLec);
            this.Controls.Add(this.lLabs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbUniversities);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lLabs;
        private System.Windows.Forms.Label lLec;
        private System.Windows.Forms.Label lTeach;
        private System.Windows.Forms.Label lEngin;
        private System.Windows.Forms.Button btAddUniversity;
        private System.Windows.Forms.Button btDeleteUniversity;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btCompare;
        private System.Windows.Forms.Label lL;
        private System.Windows.Forms.Label lLc;
        private System.Windows.Forms.Label lT;
        private System.Windows.Forms.Label lE;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lN;
        private System.Windows.Forms.ListBox lbUniversities;
        private System.Windows.Forms.Label lIngen;
        private System.Windows.Forms.Button tbClassOperations;
        private System.Windows.Forms.Label LLectories;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btInputOutput;
    }
}

