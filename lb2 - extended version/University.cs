using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace lb2
{
   public class University : IEqualityComparer<University>
    {
        private string universityName;
        public string Name { get => universityName; set => universityName = value; }

        public uint Labs 
        { 
            get
            {
                var lab = new Lab();
                uint count = 0;
                foreach (var item in halls)
                {
                    if (item.GetType() == lab.GetType())
                    {
                        count++;
                    }
                }
                return count;
            } 
        }

        public uint Auditories
        {
            get
            {
                var auditory = new Auditory();
                uint count = 0;
                foreach (var item in halls)
                {
                    if (item.GetType() == auditory.GetType())
                    {
                        count++;
                    }
                }
                return count;
            }
        }

        public uint Lectors 
        { 
            get
            {
                var lecturer = new Lecturer();
                uint count = 0;
                foreach (var item in workers)
                {
                    if (item.Value.GetType() == lecturer.GetType())
                    {
                        count++;
                    }
                }
                return count;
            }            
        }
        
        public uint Lectories { get; set; }

        public uint Engineers
        {
            get
            {
                var enginer = new Engineer();
                uint count = 0;
                foreach (var item in workers)
                {
                    if (item.Value.GetType() == enginer.GetType())
                    {
                        count++;
                    }
                }
                return count;
            }
        }

        private List<Hall> halls = new List<Hall>();
        public void AddHall(Hall hall)
        {
            if (this.IsHasHall(hall))
                MessageBox.Show("Однаковий цифровий номер аудиторії",
                    "Помилка введення даних",
                     MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else
            {
                Lab laba = new Lab();
                bool canIAdd = true;
                if (hall.GetType() == laba.GetType())
                {
                    if (this.Engineers / 2  < this.Labs + 1 )
                    {
                        MessageBox.Show("Кількість інженерів має бути в 2 рази більше за кількість лабораторних",
                            "Помилка введення даних",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        canIAdd = false;
                    }                    
                }
                else if (this.Engineers < (this.Auditories + 2) / 2 || this.Engineers == 0)
                {
                    MessageBox.Show("Кількість лекційних аудиторій має бути в 2 рази більше ніж інженерів",
                    "Помилка введення даних",
                     MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    canIAdd = false;
                }
                if (canIAdd)
                    this.halls.Add(hall);
            }

                
        }
        public bool IsHasHall(Hall hall)
        {
            bool isAlreadyHas = false;
            foreach (var item in this.halls)
            {
                if (item.LectionID == hall.LectionID)
                    isAlreadyHas = true;
            }
            return isAlreadyHas;
        }
        public List<Hall> GetHalls()
        {
            return this.halls;
        }

        private Dictionary<string, Worker> workers = new Dictionary<string, Worker>();
        public void AddWorker(Worker worker)
        {
            if (this.IsHasWorker(worker.PassportID))
            {
                MessageBox.Show("Однаковий код та номер паспорту",
                    "Помилка введення даних",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
            }
            else
                this.workers.Add(worker.PassportID, worker);
        }
        public void FireWorker(string passportID)
        {
            if (this.IsHasWorker(passportID))
                this.workers.Remove(passportID);
            else
                MessageBox.Show("Відсутній робітник з таким номером паспорту",
                    "Помилка введення даних",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
        }
        public bool IsHasWorker(string passportID)
        {
            if (this.workers.ContainsKey(passportID))
                return true;
            else
                return false;
        }
        public Dictionary<string, Worker> GetWorkers()
        {
            return this.workers;
        }

        public University() { }
        public University(string name, uint lectoriesCount)
        {
            Name = name;
            Lectories = lectoriesCount;
        }

        public void AuditoryToLectory(int auditoryNumber, bool lectoryOrLab) // 1 - lectory, 0 - Lab
        {
            if (lectoryOrLab)
            {
                if (this.halls.Count > 0 && auditoryNumber < this.halls.Count)
                {
                    if (this.Engineers * 2 < this.Lectories + 1)
                    {
                        MessageBox.Show("Кількість лекційних аудиторій має бути в 2 рази більше ніж інженерів",
                        "Помилка введення даних",
                         MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                    else
                    {
                        this.halls.RemoveAt(auditoryNumber);
                        this.Lectories++;
                    }
                }
                else
                    MessageBox.Show("Немає аудиторій для перетворювання або неправильний номер аудиторії",
                        "Помилка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            else
            {
                if (this.halls.Count > 0 && auditoryNumber < this.halls.Count)
                {
                    if (this.Engineers < (this.Labs + 1) * 2)
                    {
                        MessageBox.Show("Кількість лекційних аудиторій має бути в 2 рази більше ніж інженерів",
                            "Помилка введення даних",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    else
                    {
                        Lab tempLab = new Lab
                        {
                            LectionID = this.halls[auditoryNumber].LectionID,
                            NumListener = this.halls[auditoryNumber].NumListener
                        };
                        this.halls.RemoveAt(auditoryNumber);
                        this.halls.Add(tempLab);
                    }                    
                }
                else
                    MessageBox.Show("Немає аудиторій для перетворювання або неправильний номер аудиторії",
                        "Помилка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }           
        }
        public uint MaxCoursesCanTeaching()
        {
            return Lectors * 5;
        }
        public uint AvailableLabs()
        {
            return this.Engineers * 2;
        }
        public bool Equals(University a, University b)
        {
            return (a.Labs == b.Labs
                && a.Lectors == b.Lectors
                && a.Auditories == b.Auditories
                && a.Engineers == b.Engineers); 
        }

        public int GetHashCode(University univ)
        {
            uint newHCode = univ.Labs ^ univ.Lectors
                ^ univ.Engineers;
            return newHCode.GetHashCode();
        }
        public uint this[uint index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return Labs;
                    case 1:
                        return Lectors;

                    default:
                        throw new Exception("Невірний індекс");
                }
            }
        }

    }
}

