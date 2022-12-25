using System;
using System.Windows.Forms;

namespace lb2
{
    public partial class AddDelete : Form
    {
        public AddDelete()
        {
            InitializeComponent();
        }

        public Lab laba;
        public Auditory auditory;
        public Engineer engineer;
        public Lecturer lecturer;
        public string whatAdded;
        private void btApply_Click(object sender, EventArgs e)
        {
            if (rbAuditory.Checked)
            {
                whatAdded = "Auditory";
                try
                {
                    if (tbLUniqueNum.Text.Trim() != String.Empty) //Перевірка на пустоту текстбокса
                    {
                        auditory = new Auditory { LectionID = uint.Parse(tbLUniqueNum.Text), 
                        NumListener = Convert.ToUInt32(UpDownNumListeners.Value), 
                        NumInteractDesk = Convert.ToUInt16(UpDownNumComps.Value), 
                        IsProjector = cbProector.Checked, 
                        IsWiFi = cbWifi.Checked};                        
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                        MessageBox.Show("Пусте поле введення",
                            "Помилка введення даних",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Некорректно введені данні",
                        "Помилка введення даних",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }                
            }
            if (rbEngins.Checked)
            {
                whatAdded = "Engineer";
                try
                {
                    if (tbPIB.Text.Trim() != String.Empty && tbPassport.Text.Trim() != String.Empty) //Перевірка на пустоту текстбокса
                    {
                        engineer = new Engineer
                        {
                            Name = tbPIB.Text,
                            PassportID = tbPassport.Text,
                            IsSertificate = cbSertificate.Checked,
                            NumYearsOnPosition = Convert.ToUInt16(UpDownCoursesOrYears.Value)
                        };
                        if (engineer.PassportID != null)
                            this.DialogResult = DialogResult.OK;                        
                    }
                    else
                        MessageBox.Show("Пусте поле введення",
                            "Помилка введення даних",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Некорректно введені данні",
                        "Помилка введення даних",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            if (rbLabs.Checked)
            {
                whatAdded = "Lab";
                try
                {
                    if (tbLUniqueNum.Text.Trim() != String.Empty && tbWiFiSpeed.Text.Trim() != String.Empty) //Перевірка на пустоту текстбокса
                    {
                        laba = new Lab
                        {
                            LectionID = uint.Parse(tbLUniqueNum.Text),
                            NumListener = Convert.ToUInt16(UpDownNumListeners.Value),
                            WifiSpeed = Convert.ToDouble(tbWiFiSpeed.Text),
                            NumComputers = Convert.ToUInt16(UpDownNumComps.Value)
                        };                       
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                        MessageBox.Show("Пусте поле введення",
                            "Помилка введення даних",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Некорректно введені данні",
                        "Помилка введення даних",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            if (rbTeachs.Checked)
            {
                whatAdded = "Lectorer";
                try
                {
                    if (tbPIB.Text.Trim() != String.Empty && tbPassport.Text.Trim() != String.Empty) //Перевірка на пустоту текстбокса
                    {
                        lecturer = new Lecturer
                        {
                            Name = tbPIB.Text,
                            PassportID = tbPassport.Text,
                            NumDisciplines = Convert.ToUInt32(UpDownCoursesOrYears.Value),
                            ScientificWorks = Convert.ToUInt32(UpDownWorks.Value)
                        };
                        if (lecturer.PassportID != null)
                            this.DialogResult = DialogResult.OK;
                    }
                    else
                        MessageBox.Show("Пусте поле введення",
                            "Помилка введення даних",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);                        
                }
                catch (Exception)
                {
                    MessageBox.Show("Некорректно введені данні",
                        "Помилка введення даних",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }            
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void rbTeachs_CheckedChanged(object sender, EventArgs e)
        {
            tbPIB.Visible = true;
            tbPassport.Visible = true;
            LPIB.Visible = true;
            LPassport.Visible = true;
            LNumWorks.Visible = true;
            LNumCoursesOrYears.Text = "Кількість предметів";
            LNumCoursesOrYears.Visible = true;
            UpDownCoursesOrYears.Visible = true;
            UpDownWorks.Visible = true;
            cbSertificate.Visible = false;
            LUniqueNum.Visible = false;
            tbLUniqueNum.Visible = false;
            LNumListeners.Visible = false;
            UpDownNumListeners.Visible = false;
            LNumComps.Visible = false;
            UpDownNumComps.Visible = false;
            LWiFiSpeed.Visible = false;
            tbWiFiSpeed.Visible = false;
            cbWifi.Visible = false;
            cbProector.Visible = false;
        }

        private void rbLabs_CheckedChanged(object sender, EventArgs e)
        {
            tbPIB.Visible = false;
            tbPassport.Visible = false;
            LPIB.Visible = false;
            LPassport.Visible = false;
            LNumWorks.Visible = false;
            LNumCoursesOrYears.Visible = false;
            UpDownCoursesOrYears.Visible = false;
            UpDownWorks.Visible = false;
            cbSertificate.Visible = false;
            LUniqueNum.Visible = true;
            tbLUniqueNum.Visible = true;
            LNumListeners.Visible = true;
            UpDownNumListeners.Visible = true;
            LNumComps.Visible = true;
            LNumComps.Text = "Кількість комп'ютерів";
            UpDownNumComps.Visible = true;
            LWiFiSpeed.Visible = true;
            tbWiFiSpeed.Visible = true;
            cbWifi.Visible = false;
            cbProector.Visible = false;
        }

        private void rbAuditory_CheckedChanged(object sender, EventArgs e)
        {
            tbPIB.Visible = false;
            tbPassport.Visible = false;
            LPIB.Visible = false;
            LPassport.Visible = false;
            LNumWorks.Visible = false;
            LNumCoursesOrYears.Visible = false;
            UpDownCoursesOrYears.Visible = false;
            UpDownWorks.Visible = false;
            cbSertificate.Visible = false;
            LUniqueNum.Visible = true;
            tbLUniqueNum.Visible = true;
            LNumListeners.Visible = true;
            UpDownNumListeners.Visible = true;
            LNumComps.Visible = true;
            LNumComps.Text = "Кількість інтерактивних дошок";
            UpDownNumComps.Visible = true;
            LWiFiSpeed.Visible = false;
            tbWiFiSpeed.Visible = false;
            cbWifi.Visible = true;
            cbProector.Visible = true;
        }

        private void rbEngins_CheckedChanged(object sender, EventArgs e)
        {
            tbPIB.Visible = true;
            tbPassport.Visible = true;
            LPIB.Visible = true;
            LPassport.Visible = true;
            LNumWorks.Visible = false;
            LNumCoursesOrYears.Visible = true;
            LNumCoursesOrYears.Text = "Кількість років на посаді";
            UpDownCoursesOrYears.Visible = true;
            UpDownWorks.Visible = false;
            cbSertificate.Visible = true;
            LUniqueNum.Visible = false;
            tbLUniqueNum.Visible = false;
            LNumListeners.Visible = false;
            UpDownNumListeners.Visible = false;
            LNumComps.Visible = false;
            UpDownNumComps.Visible = false;
            LWiFiSpeed.Visible = false;
            tbWiFiSpeed.Visible = false;
            cbWifi.Visible = false;
            cbProector.Visible = false; 
        }
    }
}
