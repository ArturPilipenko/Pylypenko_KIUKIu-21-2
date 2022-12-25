using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace lb2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        public University selected;
        List<University> universities = new List<University>();

        private void lbUniversities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbUniversities.SelectedIndex != -1)
            {
                selected = universities[lbUniversities.SelectedIndex];
                lN.Text = selected.Name;
                lL.Text = selected.Labs.ToString();
                lLc.Text = selected.Auditories.ToString();
                lT.Text = selected.Lectors.ToString();
                lE.Text = selected.Engineers.ToString();
                LLectories.Text = selected.Lectories.ToString();
            }
        }

        private void btAddUniversity_Click(object sender, EventArgs e)
        {
            var dialog = new AddUniversity();
            dialog.ShowDialog();
            if(dialog.DialogResult == DialogResult.OK && dialog.addedUniversity != null)
            {
                lbUniversities.Items.Add(dialog.addedUniversity.Name);
                universities.Add(dialog.addedUniversity);
            }
        }

        private void btDeleteUniversity_Click(object sender, EventArgs e)
        {
            if (lbUniversities.SelectedIndex != -1)
            {
                universities.RemoveAt(lbUniversities.SelectedIndex);
                lbUniversities.Items.RemoveAt(lbUniversities.SelectedIndex);
                lN.Text = string.Empty;
                lL.Text = string.Empty;
                lLc.Text = string.Empty;
                lT.Text = string.Empty;
                lE.Text = string.Empty;
                LLectories.Text = string.Empty;
            }
            else
                MessageBox.Show("Не вибрано університет",
                       "Помилка введення даних",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error); // вивід сповіщення якщо ім'я не було задано
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (lbUniversities.SelectedIndex != -1)
            {
                selected = universities[lbUniversities.SelectedIndex];
                var dialog = new AddDelete();
                dialog.Text = "Додавання";
                dialog.ShowDialog();
                if (dialog.DialogResult == DialogResult.OK)
                {
                    switch (dialog.whatAdded)
                    {
                        case "Auditory":
                            selected.AddHall(dialog.auditory);
                            break;
                        case "Engineer":
                            selected.AddWorker(dialog.engineer);
                            break;
                        case "Lab":
                            selected.AddHall(dialog.laba);
                            break;
                        case "Lectorer":
                            selected.AddWorker(dialog.lecturer);
                            break;
                        default:
                            break;
                    }
                }
            }
            else
                MessageBox.Show("Не вибрано університет",
                       "Помилка",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error); // вивід сповіщення якщо ім'я не було задано

        }
        
        private void btCompare_Click(object sender, EventArgs e)
        {
            if (universities.Count >= 2)
            {
                var dialog = new CompareMerge();
                dialog.Text = "Порівняння";
                var tempUniver = new University();

                foreach (var item in lbUniversities.Items)
                {
                    dialog.lbFirst.Items.Add(item);
                    dialog.lbSecond.Items.Add(item);
                }
                dialog.ShowDialog();
                if (dialog.index1 >= 0 && dialog.index2 >= 0)
                {
                    if (tempUniver.Equals(universities[dialog.index1], universities[dialog.index2]))
                    {
                        MessageBox.Show("Університети однакові");
                    }
                    else
                    {
                        MessageBox.Show("Університети не однакові");
                    }
                }
            }
            else
                MessageBox.Show("Недостатня кількість університетів",
                       "Помилка введення даних",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error); // вивід сповіщення якщо ім'я не було задано
        }

        private void tbClassOperations_Click(object sender, EventArgs e)
        {
            if (lbUniversities.SelectedIndex >= 0)
            {
                var dialog = new ClassOperations();
                dialog.selected = universities[lbUniversities.SelectedIndex];
                dialog.Text = "Роботи за класом";
                dialog.ShowDialog();
            }
            else
                MessageBox.Show("Не було вибрано університет",
                     "Помилка",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
        }

        private void btInputOutput_Click(object sender, EventArgs e)
        {
            var dialog = new InputOutput();
            if (lbUniversities.SelectedIndex != -1)
            {
                dialog.isSelectedUniversity = true;
                dialog.selected = universities[lbUniversities.SelectedIndex];
            }
            dialog.Text = "Ввдення/виведення";
            dialog.ShowDialog();
            if (dialog.inputetFromFile != null)
            {
                lbUniversities.Items.Add(dialog.inputetFromFile.Name);
                universities.Add(dialog.inputetFromFile);
            }

        }
    }
}

