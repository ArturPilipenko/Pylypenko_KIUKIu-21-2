using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lb2
{
    public partial class ClassOperations : Form
    {
        public ClassOperations()
        {
            InitializeComponent();
        }
        public University selected;

        private void tbUpdateInformation_Click(object sender, EventArgs e)
        {            
            lN.Text = selected.Name;
            lL.Text = selected.Labs.ToString();
            lLc.Text = selected.Auditories.ToString();
            lT.Text = selected.Lectors.ToString();
            lE.Text = selected.Engineers.ToString();
            LLectories.Text = selected.Lectories.ToString();
        }

        private void btLabsNum_Click(object sender, EventArgs e)
        {
            LForLabs.Text = selected.AvailableLabs().ToString();
        }

        private void btCoursesForTeaching_Click(object sender, EventArgs e)
        {
            LForCourses.Text = selected.MaxCoursesCanTeaching().ToString();
        }

        private void tbExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btAuditoryInLecOrLab_Click(object sender, EventArgs e)
        {
            bool lectoryOrLab;
            if (rbLect.Checked)
            {
                lectoryOrLab = true;
            }
            else if (rbLab.Checked)
            {
                lectoryOrLab = false;
            }
            else
            {
                MessageBox.Show("Не було вибрано у що перетворювати",
                    "Помилка введення даних",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (UpDownForChange.Value - 1 >= 0)
            {
                selected.AuditoryToLectory(Convert.ToInt32(UpDownForChange.Value - 1), lectoryOrLab);
            }
            else
                MessageBox.Show("Номер аудиторії не может бути менше 1",
                    "Помилка введення даних",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbWorkerPassport.Text.Trim() != string.Empty)
            {
                bool hireOrFire, lectOrEngineer = true;
                if (rbHire.Checked)
                {
                    hireOrFire = true;
                    if (rbLector.Checked)
                        lectOrEngineer = true;
                    else
                    {
                        if (rbEngineer.Checked)
                        {
                            lectOrEngineer = false;
                        }
                        else
                        {
                            MessageBox.Show("Не було вибрано кого найняти",
                            "Помилка введення даних",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                            return;
                        }
                    }
                   
                }
                else if (rbFire.Checked)
                {
                    hireOrFire = false;
                }
                else
                {
                    MessageBox.Show("Не було вибрано звільнити чи найняти",
                        "Помилка введення даних",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                if (hireOrFire)
                {     
                    if (lectOrEngineer)
                    {
                        Lecturer tempLect = new Lecturer { PassportID = tbWorkerPassport.Text };
                        if(tempLect.PassportID != null)
                            selected.AddWorker(tempLect);
                    }
                    else
                    {
                        Engineer tempEngineer = new Engineer { PassportID = tbWorkerPassport.Text };
                        if(tempEngineer.PassportID != null)
                            selected.AddWorker(tempEngineer);
                    }                        
                }
                else
                {
                    selected.FireWorker(tbWorkerPassport.Text);
                }
            }     
            else
                MessageBox.Show("Пусте поле введеня",
                    "Помилка введення даних",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
        }

        private void rbHire_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHire.Checked)
                gbForHire.Visible = true;
            else
                gbForHire.Visible = false;
        }
    }
}
