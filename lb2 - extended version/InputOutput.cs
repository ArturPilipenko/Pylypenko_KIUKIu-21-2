using System;
using System.IO;
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
    public partial class InputOutput : Form
    {
        public InputOutput()
        {
            InitializeComponent();
        }
        public University selected;
        public bool isSelectedUniversity = false;
        public University inputetFromFile;

        private void btExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btOutputInFile_Click(object sender, EventArgs e)
        {
            if (isSelectedUniversity)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog1.Title = "Save university information";
                saveFileDialog1.ShowDialog();
                // створення параметрів діалогового вікна
                if (saveFileDialog1.FileName != "")
                { // перевірка чи обраний файл
                    var filePath = saveFileDialog1.FileName;
                    if (rbOutputUniver.Checked)
                    {
                        using (var file = File.CreateText(filePath))
                        { // щоб не забути закрити файл
                            file.WriteLine($"Назва: {selected.Name}");
                            file.WriteLine($"Лабораторні: {selected.Labs}");
                            file.WriteLine($"Аудиторії: {selected.Auditories}");
                            file.WriteLine($"Лекційні: {selected.Lectories}");
                            file.WriteLine($"Лектори: {selected.Lectors}");
                            file.WriteLine($"Інженери: {selected.Engineers}");
                            Engineer tempLector = new Engineer();
                            foreach (var item in selected.GetWorkers())
                            {
                                if (tempLector.GetType() == item.Value.GetType())
                                {
                                    foreach (var output in item.Value.OutputInformation())
                                    {
                                        file.WriteLine(output);
                                    }
                                }
                            }
                            foreach (var item in selected.GetHalls())
                            {
                                foreach (var output in item.OutputInformation())
                                {
                                    file.WriteLine(output);
                                }
                            }                            
                        }
                    }
                    else if (rbOutputLectors.Checked)
                    {
                        Lecturer tempLector = new Lecturer();
                        using (var file = File.CreateText(filePath))
                        { // щоб не забути закрити файл
                            foreach (var item in selected.GetWorkers())
                            {
                                if (tempLector.GetType() == item.Value.GetType())
                                {
                                    foreach (var output in item.Value.OutputInformation())
                                    {
                                        file.WriteLine(output);
                                    }
                                }
                            }
                        }
                    }
                    else if (rbOutputEngineers.Checked)
                    {
                        Engineer tempLector = new Engineer();
                        using (var file = File.CreateText(filePath))
                        { // щоб не забути закрити файл
                            foreach (var item in selected.GetWorkers())
                            {
                                if (tempLector.GetType() == item.Value.GetType())
                                {
                                    foreach (var output in item.Value.OutputInformation())
                                    {
                                        file.WriteLine(output);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
                MessageBox.Show("У меню не був обраний університет для виведення",
                   "Помилка введення даних",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

        }

        private void btInputFromFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            { // щоб не забути закрити файл
                openFileDialog.InitialDirectory = "UniversityData\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                // встановлення параметрів діалогового вікна

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                { // чи був успішно відкритий файл
                    var filePath = openFileDialog.FileName;
                    if (rbInputUniver.Checked)
                    {
                        try
                        {
                            using (var file = new StreamReader(filePath))
                            {
                                    string name = file.ReadLine();
                                    int labsNum = Convert.ToInt32(file.ReadLine().Split(':')[1].Trim());
                                    int auditoryNum = Convert.ToInt32(file.ReadLine().Split(':')[1].Trim());
                                    string numLectories = file.ReadLine();
                                    file.ReadLine();
                                    int engineerCount = Convert.ToInt32(file.ReadLine().Split(':')[1].Trim());
                                    name = name.Split(':')[1].Trim();
                                    numLectories = numLectories.Split(':')[1].Trim();
                                    inputetFromFile = new University(name, Convert.ToUInt32(numLectories));
                                    for (int iterat = 0; iterat < engineerCount; iterat++)
                                    {
                                        string engName = file.ReadLine();
                                        string passportID = file.ReadLine();
                                        string numYears = file.ReadLine();
                                        string isSertificate = file.ReadLine();
                                        engName = engName.Split(':')[1].Trim();
                                        passportID = passportID.Split(':')[1].Trim();
                                        numYears = numYears.Split(':')[1].Trim();
                                        isSertificate = isSertificate.Split(':')[1].Trim();
                                        inputetFromFile.AddWorker(new Engineer
                                        {
                                            Name = engName,
                                            PassportID = passportID,
                                            NumYearsOnPosition = Convert.ToUInt32(numYears),
                                            IsSertificate = Convert.ToBoolean(isSertificate)
                                        });
                                    }
                                    for (int iter = 0; iter < auditoryNum; iter++)
                                    {
                                        string auditnum = file.ReadLine();
                                        string listenerNum = file.ReadLine();
                                        string desksNum = file.ReadLine();
                                        string isProector = file.ReadLine();
                                        string isWifi = file.ReadLine();
                                        auditnum = auditnum.Split(':')[1].Trim();
                                        listenerNum = listenerNum.Split(':')[1].Trim();
                                        desksNum = desksNum.Split(':')[1].Trim();
                                        isProector = isProector.Split(':')[1].Trim();
                                        isWifi = isWifi.Split(':')[1].Trim();
                                        inputetFromFile.AddHall(new Auditory { LectionID = Convert.ToUInt32(auditnum),
                                            NumListener = Convert.ToUInt32(listenerNum),
                                            NumInteractDesk = Convert.ToUInt32(desksNum),
                                            IsProjector = Convert.ToBoolean(isProector),
                                            IsWiFi = Convert.ToBoolean(isWifi) 
                                        });
                                    }
                                for (int iterator = 0; iterator < labsNum; iterator++)
                                {
                                    string auditnum = file.ReadLine();
                                    string listenerNum = file.ReadLine();
                                    string computerNum = file.ReadLine();
                                    string wiFispeed = file.ReadLine();
                                    auditnum = auditnum.Split(':')[1].Trim();
                                    listenerNum = listenerNum.Split(':')[1].Trim();
                                    computerNum = computerNum.Split(':')[1].Trim();
                                    wiFispeed = wiFispeed.Split(':')[1].Trim();
                                    inputetFromFile.AddHall(new Lab
                                    {
                                        LectionID = Convert.ToUInt32(auditnum),
                                        NumListener = Convert.ToUInt32(listenerNum),
                                        NumComputers = Convert.ToUInt32(computerNum),
                                        WifiSpeed = Convert.ToDouble(wiFispeed)
                                    });

                                }
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Помилка при читанні з файла",
                             "Помилка введення даних",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
                        }
                    }
                    else if (rbInputLectors.Checked)
                    {
                        if (isSelectedUniversity)
                        {
                            try
                            {
                                using (var file = new StreamReader(filePath))
                                {
                                    for (int i = 0; i < File.ReadAllLines(filePath).Length / 4; i++)
                                    { // потстрокове читання з файлу
                                        string name = file.ReadLine();
                                        string passportID = file.ReadLine();
                                        string numCourses = file.ReadLine();
                                        string numScienceWorks = file.ReadLine();
                                        name = name.Split(':')[1].Trim();
                                        passportID = passportID.Split(':')[1].Trim();
                                        numCourses = numCourses.Split(':')[1].Trim();
                                        numScienceWorks = numScienceWorks.Split(':')[1].Trim();
                                        selected.AddWorker(new Lecturer
                                        {
                                            Name = name,
                                            PassportID = passportID,
                                            NumDisciplines = Convert.ToUInt32(numCourses),
                                            ScientificWorks = Convert.ToUInt32(numScienceWorks)
                                        });
                                    }
                                }
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Помилка при читанні з файла",
                                 "Помилка введення даних",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                            }
                        }
                        else
                            MessageBox.Show("Не був обраний університет для введеня інженерів з файлу",
                                 "Помилка введення даних",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                    }                
                    else if (rbInputEngineers.Checked)
                    {
                        if (isSelectedUniversity)
                        {
                            try
                            {
                                using (var file = new StreamReader(filePath))
                                { 
                                    for (int i = 0; i < File.ReadAllLines(filePath).Length / 4; i++)
                                    { // потстрокове читання з файлу
                                        string name = file.ReadLine();
                                        string passportID = file.ReadLine();
                                        string numYears = file.ReadLine();
                                        string isSertificate = file.ReadLine();
                                        name = name.Split(':')[1].Trim(); 
                                        passportID = passportID.Split(':')[1].Trim();
                                        numYears = numYears.Split(':')[1].Trim();
                                        isSertificate = isSertificate.Split(':')[1].Trim();
                                        selected.AddWorker(new Engineer { Name = name, 
                                            PassportID = passportID, 
                                            NumYearsOnPosition = Convert.ToUInt32(numYears), 
                                            IsSertificate = Convert.ToBoolean(isSertificate) });
                                    }                                        
                                }
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Помилка при читанні з файла",
                                 "Помилка введення даних",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                            }
                        }
                        else
                            MessageBox.Show("Не був обраний університет для введеня інженерів з файлу",
                                 "Помилка введення даних",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                    }
                }
            }            
        }
    }
}
