using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace lb2
{
    public partial class AddUniversity : Form
    {
        public AddUniversity()
        {
            InitializeComponent();
        }
        public University addedUniversity;
        private List<Hall> halls = new List<Hall>();
        private void btAdd_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Trim() != String.Empty) //Перевірка на пустоту текстбокса
            {
                halls.Add(new Lab { });
                try
                {
                    addedUniversity = new University(tbName.Text, 0);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Пусте поле введення",
                    "Помилка введення даних",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error); // вивід сповіщення якщо ім'я не було задано

            DialogResult = DialogResult.OK;
        }

    }
}
