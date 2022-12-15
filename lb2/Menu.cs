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
                selected = (University)universities[lbUniversities.SelectedIndex];
                lN.Text = selected.Name;
                lF.Text = selected.Faculty.ToString();
                lL.Text = selected.Labs.ToString();
                lLc.Text = selected.Lectures.ToString();
                lS.Text = selected.Students.ToString();
                lT.Text = selected.Teachers.ToString();
                lE.Text = selected.Engineers.ToString();
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
                lF.Text = string.Empty;
                lL.Text = string.Empty;
                lLc.Text = string.Empty;
                lS.Text = string.Empty;
                lT.Text = string.Empty;
                lE.Text = string.Empty;
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
                var dialog = new AddDelete();
                dialog.Text = "Додавання";
                dialog.ShowDialog();
                if (dialog.DialogResult == DialogResult.OK)
                {
                    switch (dialog.selectedItem)
                    {
                        case "rbStuds":
                            selected.AddStudents(dialog.number);
                            break;
                        case "rbTeachs":
                            selected.AddTeachers(dialog.number);
                            break;
                        case "rbEngins":
                            selected.AddEngineers(dialog.number);
                            break;
                        case "rbLecs":
                            selected.AddLectures(dialog.number);
                            break;
                        case "rbLabs":
                            selected.AddLabs(dialog.number);
                            break;
                        default:
                            break;
                    }
                }
            }
            else
                MessageBox.Show("Не вибрано університет",
                       "Помилка введення даних",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error); // вивід сповіщення якщо ім'я не було задано

        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            if (lbUniversities.SelectedIndex != -1)
            {
                var dialog = new AddDelete();
                dialog.Text = "Видалення";
                dialog.ShowDialog();
                if (dialog.DialogResult == DialogResult.OK)
                {
                    switch (dialog.selectedItem)
                    {
                        case "rbStuds":
                            if (selected.Students >= dialog.number)
                            {
                                selected.DeleteStudents(dialog.number);
                            }
                            else
                                MessageBox.Show("В університета немає стільки студентів",
                                    "Помилка видалення",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error); // вивід сповіщення якщо ім'я не було задано
                            break;
                        case "rbTeachs":
                            if (selected.Teachers >= dialog.number)
                            {
                                selected.DeleteTeachers(dialog.number);
                            }
                            else
                                MessageBox.Show("В університета немає стільки викладачів",
                                    "Помилка видалення",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error); // вивід сповіщення якщо ім'я не було задано
                            break;
                        case "rbEngins":
                            if (selected.Engineers >= dialog.number)
                            {
                                selected.DeleteEngineers(dialog.number);
                            }
                            else
                                MessageBox.Show("В університета немає стільки інженерів",
                                    "Помилка видалення",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error); // вивід сповіщення якщо ім'я не було задано
                            break;
                        case "rbLecs":
                            if (selected.Lectures >= dialog.number)
                            {
                                selected.DeleteLectures(dialog.number);
                            }
                            else
                                MessageBox.Show("В університета немає стільки лекційних аудиторій",
                                    "Помилка видалення",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error); // вивід сповіщення якщо ім'я не було задано
                            break;
                        case "rbLabs":
                            if (selected.Labs >= dialog.number)
                            {
                                selected.DeleteLabs(dialog.number);
                            }
                            else
                                MessageBox.Show("В університета немає стільки лабораторних",
                                    "Помилка видалення",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error); // вивід сповіщення якщо ім'я не було задано
                            break;
                        default:
                            break;
                    }
                }
            }
            else
                MessageBox.Show("Не вибрано університет",
                       "Помилка введення даних",
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

        private void btMerge_Click(object sender, EventArgs e)
        {
            if (universities.Count >= 2)
            {
                var dialog = new CompareMerge();
                dialog.Text = "Злиття";
                foreach (var item in lbUniversities.Items)
                {
                    dialog.lbFirst.Items.Add(item);
                    dialog.lbSecond.Items.Add(item);
                }
                dialog.ShowDialog();
                if (dialog.DialogResult == DialogResult.OK)
                {
                    if (dialog.index1 != -1 && dialog.index2 != -1 && dialog.index1 != dialog.index2)
                    {
                        var u1 = (University)universities[dialog.index1];
                        var u2 = (University)universities[dialog.index2];
                        University newUniversity = new University(u1 + u2);
                        lbUniversities.Items.Remove(u1.Name);
                        lbUniversities.Items.Remove(u2.Name);
                        universities.Remove(u1);
                        universities.Remove(u2);
                        lbUniversities.Items.Add(newUniversity.Name);
                        universities.Add(newUniversity);

                    }
                }
            }
            else
                MessageBox.Show("Недостатня кількість університетів",
                       "Помилка введення даних",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error); // вивід сповіщення якщо ім'я не було задано
        }
    }
}

