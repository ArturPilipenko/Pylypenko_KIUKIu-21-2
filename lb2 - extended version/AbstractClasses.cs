using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb2
{
    public abstract class Hall
    {
        private uint lectionID;
        public uint LectionID
        {
            get => lectionID;
            set => lectionID = value; 
        }

        private uint numListener;
        public uint NumListener
        {
            get => numListener; 
            set => numListener = value; 
        }
        public abstract string[] OutputInformation();
    }
    public abstract class Worker
    {
        private string name;
        public string Name
        {
            get => name; 
            set => name = value; 
        }

        private string passportID;
        public string PassportID
        {
            get => passportID; 
            set 
            {
                if (value.Length == 8)
                {
                    if (Char.IsLetter(value[0]) && Char.IsLetter(value[1]))
                    {
                        try
                        {
                            uint temp = uint.Parse(value.Substring(2, 6));
                            passportID = value;
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Неправильний формат кода та номера паспорту. Правильний: 2 літери, 6 цифр",
                                    "Помилка введення даних",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                        }
                    }
                    else
                        MessageBox.Show("Неправильний формат кода та номера паспорту. Правильний: 2 літери, 6 цифр",
                            "Помилка введення даних",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Неправильний формат кода та номера паспорту. Правильний: 2 літери, 6 цифр",
                        "Помилка введення даних",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);

            }
        }

        public abstract string[] OutputInformation();
    }
}
