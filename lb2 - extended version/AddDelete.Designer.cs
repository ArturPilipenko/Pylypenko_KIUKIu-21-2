
namespace lb2
{
    partial class AddDelete
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
            this.lTechs = new System.Windows.Forms.Label();
            this.rbTeachs = new System.Windows.Forms.RadioButton();
            this.rbEngins = new System.Windows.Forms.RadioButton();
            this.rbAuditory = new System.Windows.Forms.RadioButton();
            this.rbLabs = new System.Windows.Forms.RadioButton();
            this.btCancel = new System.Windows.Forms.Button();
            this.btApply = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPIB = new System.Windows.Forms.TextBox();
            this.tbPassport = new System.Windows.Forms.TextBox();
            this.UpDownCoursesOrYears = new System.Windows.Forms.NumericUpDown();
            this.UpDownWorks = new System.Windows.Forms.NumericUpDown();
            this.LPIB = new System.Windows.Forms.Label();
            this.LPassport = new System.Windows.Forms.Label();
            this.LNumCoursesOrYears = new System.Windows.Forms.Label();
            this.LNumWorks = new System.Windows.Forms.Label();
            this.cbSertificate = new System.Windows.Forms.CheckBox();
            this.tbLUniqueNum = new System.Windows.Forms.TextBox();
            this.LUniqueNum = new System.Windows.Forms.Label();
            this.UpDownNumListeners = new System.Windows.Forms.NumericUpDown();
            this.LNumListeners = new System.Windows.Forms.Label();
            this.UpDownNumComps = new System.Windows.Forms.NumericUpDown();
            this.LNumComps = new System.Windows.Forms.Label();
            this.tbWiFiSpeed = new System.Windows.Forms.TextBox();
            this.LWiFiSpeed = new System.Windows.Forms.Label();
            this.cbProector = new System.Windows.Forms.CheckBox();
            this.cbWifi = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownCoursesOrYears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownWorks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownNumListeners)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownNumComps)).BeginInit();
            this.SuspendLayout();
            // 
            // lTechs
            // 
            this.lTechs.AutoSize = true;
            this.lTechs.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTechs.Location = new System.Drawing.Point(40, 66);
            this.lTechs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lTechs.Name = "lTechs";
            this.lTechs.Size = new System.Drawing.Size(0, 17);
            this.lTechs.TabIndex = 0;
            // 
            // rbTeachs
            // 
            this.rbTeachs.AutoSize = true;
            this.rbTeachs.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbTeachs.Location = new System.Drawing.Point(118, 29);
            this.rbTeachs.Margin = new System.Windows.Forms.Padding(2);
            this.rbTeachs.Name = "rbTeachs";
            this.rbTeachs.Size = new System.Drawing.Size(89, 21);
            this.rbTeachs.TabIndex = 5;
            this.rbTeachs.TabStop = true;
            this.rbTeachs.Text = "Викладачі";
            this.rbTeachs.UseVisualStyleBackColor = true;
            this.rbTeachs.CheckedChanged += new System.EventHandler(this.rbTeachs_CheckedChanged);
            // 
            // rbEngins
            // 
            this.rbEngins.AutoSize = true;
            this.rbEngins.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbEngins.Location = new System.Drawing.Point(211, 29);
            this.rbEngins.Margin = new System.Windows.Forms.Padding(2);
            this.rbEngins.Name = "rbEngins";
            this.rbEngins.Size = new System.Drawing.Size(86, 21);
            this.rbEngins.TabIndex = 7;
            this.rbEngins.TabStop = true;
            this.rbEngins.Text = "Інженери";
            this.rbEngins.UseVisualStyleBackColor = true;
            this.rbEngins.CheckedChanged += new System.EventHandler(this.rbEngins_CheckedChanged);
            // 
            // rbAuditory
            // 
            this.rbAuditory.AutoSize = true;
            this.rbAuditory.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbAuditory.Location = new System.Drawing.Point(301, 29);
            this.rbAuditory.Margin = new System.Windows.Forms.Padding(2);
            this.rbAuditory.Name = "rbAuditory";
            this.rbAuditory.Size = new System.Drawing.Size(86, 21);
            this.rbAuditory.TabIndex = 8;
            this.rbAuditory.TabStop = true;
            this.rbAuditory.Text = "Аудиторії";
            this.rbAuditory.UseVisualStyleBackColor = true;
            this.rbAuditory.CheckedChanged += new System.EventHandler(this.rbAuditory_CheckedChanged);
            // 
            // rbLabs
            // 
            this.rbLabs.AutoSize = true;
            this.rbLabs.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbLabs.Location = new System.Drawing.Point(391, 28);
            this.rbLabs.Margin = new System.Windows.Forms.Padding(2);
            this.rbLabs.Name = "rbLabs";
            this.rbLabs.Size = new System.Drawing.Size(101, 21);
            this.rbLabs.TabIndex = 9;
            this.rbLabs.TabStop = true;
            this.rbLabs.Text = "Лабораторії";
            this.rbLabs.UseVisualStyleBackColor = true;
            this.rbLabs.CheckedChanged += new System.EventHandler(this.rbLabs_CheckedChanged);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(183, 313);
            this.btCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(94, 43);
            this.btCancel.TabIndex = 10;
            this.btCancel.Text = "Скасувати";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btApply
            // 
            this.btApply.Location = new System.Drawing.Point(19, 313);
            this.btApply.Margin = new System.Windows.Forms.Padding(2);
            this.btApply.Name = "btApply";
            this.btApply.Size = new System.Drawing.Size(94, 43);
            this.btApply.TabIndex = 11;
            this.btApply.Text = "Застосувати";
            this.btApply.UseVisualStyleBackColor = true;
            this.btApply.Click += new System.EventHandler(this.btApply_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Категорії";
            // 
            // tbPIB
            // 
            this.tbPIB.Location = new System.Drawing.Point(25, 75);
            this.tbPIB.Name = "tbPIB";
            this.tbPIB.Size = new System.Drawing.Size(194, 20);
            this.tbPIB.TabIndex = 14;
            this.tbPIB.Visible = false;
            // 
            // tbPassport
            // 
            this.tbPassport.Location = new System.Drawing.Point(25, 114);
            this.tbPassport.Name = "tbPassport";
            this.tbPassport.Size = new System.Drawing.Size(131, 20);
            this.tbPassport.TabIndex = 15;
            this.tbPassport.Visible = false;
            // 
            // UpDownCoursesOrYears
            // 
            this.UpDownCoursesOrYears.Location = new System.Drawing.Point(25, 176);
            this.UpDownCoursesOrYears.Name = "UpDownCoursesOrYears";
            this.UpDownCoursesOrYears.Size = new System.Drawing.Size(40, 20);
            this.UpDownCoursesOrYears.TabIndex = 16;
            this.UpDownCoursesOrYears.Visible = false;
            // 
            // UpDownWorks
            // 
            this.UpDownWorks.Location = new System.Drawing.Point(25, 215);
            this.UpDownWorks.Name = "UpDownWorks";
            this.UpDownWorks.Size = new System.Drawing.Size(40, 20);
            this.UpDownWorks.TabIndex = 17;
            this.UpDownWorks.Visible = false;
            // 
            // LPIB
            // 
            this.LPIB.AutoSize = true;
            this.LPIB.Location = new System.Drawing.Point(22, 59);
            this.LPIB.Name = "LPIB";
            this.LPIB.Size = new System.Drawing.Size(25, 13);
            this.LPIB.TabIndex = 18;
            this.LPIB.Text = "ПІБ";
            this.LPIB.Visible = false;
            // 
            // LPassport
            // 
            this.LPassport.AutoSize = true;
            this.LPassport.Location = new System.Drawing.Point(22, 98);
            this.LPassport.Name = "LPassport";
            this.LPassport.Size = new System.Drawing.Size(124, 13);
            this.LPassport.TabIndex = 19;
            this.LPassport.Text = "Код та номер паспорту";
            this.LPassport.Visible = false;
            // 
            // LNumCoursesOrYears
            // 
            this.LNumCoursesOrYears.AutoSize = true;
            this.LNumCoursesOrYears.Location = new System.Drawing.Point(25, 160);
            this.LNumCoursesOrYears.Name = "LNumCoursesOrYears";
            this.LNumCoursesOrYears.Size = new System.Drawing.Size(107, 13);
            this.LNumCoursesOrYears.TabIndex = 20;
            this.LNumCoursesOrYears.Text = "Кількість предметів";
            this.LNumCoursesOrYears.Visible = false;
            // 
            // LNumWorks
            // 
            this.LNumWorks.AutoSize = true;
            this.LNumWorks.Location = new System.Drawing.Point(22, 199);
            this.LNumWorks.Name = "LNumWorks";
            this.LNumWorks.Size = new System.Drawing.Size(130, 13);
            this.LNumWorks.TabIndex = 21;
            this.LNumWorks.Text = "Кількість наукових робіт";
            this.LNumWorks.Visible = false;
            // 
            // cbSertificate
            // 
            this.cbSertificate.AutoSize = true;
            this.cbSertificate.Location = new System.Drawing.Point(25, 140);
            this.cbSertificate.Name = "cbSertificate";
            this.cbSertificate.Size = new System.Drawing.Size(191, 17);
            this.cbSertificate.TabIndex = 22;
            this.cbSertificate.Text = "Наявність срифікату спец курсів";
            this.cbSertificate.UseVisualStyleBackColor = true;
            this.cbSertificate.Visible = false;
            // 
            // tbLUniqueNum
            // 
            this.tbLUniqueNum.Location = new System.Drawing.Point(225, 75);
            this.tbLUniqueNum.Name = "tbLUniqueNum";
            this.tbLUniqueNum.Size = new System.Drawing.Size(150, 20);
            this.tbLUniqueNum.TabIndex = 23;
            this.tbLUniqueNum.Visible = false;
            // 
            // LUniqueNum
            // 
            this.LUniqueNum.AutoSize = true;
            this.LUniqueNum.Location = new System.Drawing.Point(222, 59);
            this.LUniqueNum.Name = "LUniqueNum";
            this.LUniqueNum.Size = new System.Drawing.Size(153, 13);
            this.LUniqueNum.TabIndex = 24;
            this.LUniqueNum.Text = "Унікальний цифровий номер";
            this.LUniqueNum.Visible = false;
            // 
            // UpDownNumListeners
            // 
            this.UpDownNumListeners.Location = new System.Drawing.Point(225, 114);
            this.UpDownNumListeners.Name = "UpDownNumListeners";
            this.UpDownNumListeners.Size = new System.Drawing.Size(40, 20);
            this.UpDownNumListeners.TabIndex = 25;
            this.UpDownNumListeners.Visible = false;
            // 
            // LNumListeners
            // 
            this.LNumListeners.AutoSize = true;
            this.LNumListeners.Location = new System.Drawing.Point(222, 98);
            this.LNumListeners.Name = "LNumListeners";
            this.LNumListeners.Size = new System.Drawing.Size(149, 13);
            this.LNumListeners.TabIndex = 26;
            this.LNumListeners.Text = "Кількість місць для слухачів";
            this.LNumListeners.Visible = false;
            // 
            // UpDownNumComps
            // 
            this.UpDownNumComps.Location = new System.Drawing.Point(225, 153);
            this.UpDownNumComps.Name = "UpDownNumComps";
            this.UpDownNumComps.Size = new System.Drawing.Size(40, 20);
            this.UpDownNumComps.TabIndex = 27;
            this.UpDownNumComps.Visible = false;
            // 
            // LNumComps
            // 
            this.LNumComps.AutoSize = true;
            this.LNumComps.Location = new System.Drawing.Point(222, 137);
            this.LNumComps.Name = "LNumComps";
            this.LNumComps.Size = new System.Drawing.Size(117, 13);
            this.LNumComps.TabIndex = 28;
            this.LNumComps.Text = "Кількість комп\'ютерів";
            this.LNumComps.Visible = false;
            // 
            // tbWiFiSpeed
            // 
            this.tbWiFiSpeed.Location = new System.Drawing.Point(225, 192);
            this.tbWiFiSpeed.Name = "tbWiFiSpeed";
            this.tbWiFiSpeed.Size = new System.Drawing.Size(114, 20);
            this.tbWiFiSpeed.TabIndex = 29;
            this.tbWiFiSpeed.Visible = false;
            // 
            // LWiFiSpeed
            // 
            this.LWiFiSpeed.AutoSize = true;
            this.LWiFiSpeed.Location = new System.Drawing.Point(222, 176);
            this.LWiFiSpeed.Name = "LWiFiSpeed";
            this.LWiFiSpeed.Size = new System.Drawing.Size(119, 13);
            this.LWiFiSpeed.TabIndex = 30;
            this.LWiFiSpeed.Text = "Швидкість WiFi Мбіт/c";
            this.LWiFiSpeed.Visible = false;
            // 
            // cbProector
            // 
            this.cbProector.AutoSize = true;
            this.cbProector.Location = new System.Drawing.Point(225, 218);
            this.cbProector.Name = "cbProector";
            this.cbProector.Size = new System.Drawing.Size(132, 17);
            this.cbProector.TabIndex = 31;
            this.cbProector.Text = "Наявність проектору";
            this.cbProector.UseVisualStyleBackColor = true;
            this.cbProector.Visible = false;
            // 
            // cbWifi
            // 
            this.cbWifi.AutoSize = true;
            this.cbWifi.Location = new System.Drawing.Point(225, 241);
            this.cbWifi.Name = "cbWifi";
            this.cbWifi.Size = new System.Drawing.Size(101, 17);
            this.cbWifi.TabIndex = 32;
            this.cbWifi.Text = "Наявність WiFi";
            this.cbWifi.UseVisualStyleBackColor = true;
            this.cbWifi.Visible = false;
            // 
            // AddDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(621, 366);
            this.Controls.Add(this.cbWifi);
            this.Controls.Add(this.cbProector);
            this.Controls.Add(this.LWiFiSpeed);
            this.Controls.Add(this.tbWiFiSpeed);
            this.Controls.Add(this.LNumComps);
            this.Controls.Add(this.UpDownNumComps);
            this.Controls.Add(this.LNumListeners);
            this.Controls.Add(this.UpDownNumListeners);
            this.Controls.Add(this.LUniqueNum);
            this.Controls.Add(this.tbLUniqueNum);
            this.Controls.Add(this.cbSertificate);
            this.Controls.Add(this.LNumWorks);
            this.Controls.Add(this.LNumCoursesOrYears);
            this.Controls.Add(this.LPassport);
            this.Controls.Add(this.LPIB);
            this.Controls.Add(this.UpDownWorks);
            this.Controls.Add(this.UpDownCoursesOrYears);
            this.Controls.Add(this.tbPassport);
            this.Controls.Add(this.tbPIB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btApply);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.rbLabs);
            this.Controls.Add(this.rbAuditory);
            this.Controls.Add(this.rbEngins);
            this.Controls.Add(this.rbTeachs);
            this.Controls.Add(this.lTechs);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDelete";
            ((System.ComponentModel.ISupportInitialize)(this.UpDownCoursesOrYears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownWorks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownNumListeners)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownNumComps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTechs;
        private System.Windows.Forms.RadioButton rbTeachs;
        private System.Windows.Forms.RadioButton rbEngins;
        private System.Windows.Forms.RadioButton rbAuditory;
        private System.Windows.Forms.RadioButton rbLabs;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btApply;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPIB;
        private System.Windows.Forms.TextBox tbPassport;
        private System.Windows.Forms.NumericUpDown UpDownCoursesOrYears;
        private System.Windows.Forms.NumericUpDown UpDownWorks;
        private System.Windows.Forms.Label LPIB;
        private System.Windows.Forms.Label LPassport;
        private System.Windows.Forms.Label LNumCoursesOrYears;
        private System.Windows.Forms.Label LNumWorks;
        private System.Windows.Forms.CheckBox cbSertificate;
        private System.Windows.Forms.TextBox tbLUniqueNum;
        private System.Windows.Forms.Label LUniqueNum;
        private System.Windows.Forms.NumericUpDown UpDownNumListeners;
        private System.Windows.Forms.Label LNumListeners;
        private System.Windows.Forms.NumericUpDown UpDownNumComps;
        private System.Windows.Forms.Label LNumComps;
        private System.Windows.Forms.TextBox tbWiFiSpeed;
        private System.Windows.Forms.Label LWiFiSpeed;
        private System.Windows.Forms.CheckBox cbProector;
        private System.Windows.Forms.CheckBox cbWifi;
    }
}