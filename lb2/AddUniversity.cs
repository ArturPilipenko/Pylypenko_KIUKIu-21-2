using System;
using System.Windows.Forms;

namespace lb2
{
    public partial class AddUniversity : Form
    {
        public AddUniversity()
        {
            InitializeComponent();
        }
        public University addedUniversity;

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Trim() != String.Empty) //Перевірка на пустоту текстбокса
            {
                try
                {
                    addedUniversity = new University
                    (tbName.Text,
                     Convert.ToUInt16(numUpDownFacs.Value),
                     Convert.ToUInt16(numUpDownLabs.Value),
                     Convert.ToUInt16(numUpDownLecs.Value),
                     Convert.ToUInt16(numUpDownStuds.Value),
                     Convert.ToUInt16(numUpDownTeachs.Value),
                     Convert.ToUInt16(numUpDownEngin.Value));
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
