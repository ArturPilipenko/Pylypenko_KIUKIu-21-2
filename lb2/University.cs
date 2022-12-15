using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace lb2
{
   public class University : IEqualityComparer<University>
    {
        private string universityName;
        public string Name { get => universityName; set => universityName = value; }

        private uint numFaculties;
        public uint Faculty { get => numFaculties; set => numFaculties = value; }

        private uint numLabs;
        public uint Labs { get => numLabs; set => numLabs = value; }

        private uint numLectures;
        public uint Lectures { get => numLectures;
            set
            {
                if (value <= numEngineers / 2)
                    numLectures = value;
                else
                    MessageBox.Show("Кількість інженерів має бути у 2 рази більша ніж кількість аудиторій",
                            "Помилка введення даних",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                
            }
        }

        private uint numTeachers;
        public uint Teachers { get => numTeachers; 
            set 
            {
                if (value < Students / 10)
                    MessageBox.Show("Кількість студентів більш ніж в 10 рази перевищую кількість викладачів",
                        "Помилка введення даних",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                else
                    numTeachers = value;
            }
        }

        private uint numStudents;
        public uint Students
        {
            get => numStudents;
            set
            {
                if (value > Teachers * 10)
                    MessageBox.Show("Кількість студентів більш ніж в 10 рази перевищую кількість викладачів",
                        "Помилка введення даних",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error); 
                else
                    numStudents = value;
            }
        }

        private uint numEngineers;
        public uint Engineers
        {
            get => numEngineers;
            set
            {   
                if (value < Lectures * 2)
                    MessageBox.Show("Кількість інженерів має бути у 2 рази більша ніж кількість аудиторій",
                        "Помилка введення даних",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error); 
                else
                    numEngineers = value;
            }
        }

        public University() { }
        public University(string name, uint fac, uint lb, uint lec, uint stud, uint teach, uint engin)
        {
            Name = name;
            Faculty = fac;
            Labs = lb;
            Lectures = lec;            
            Teachers = teach;
            Students = stud;
            Engineers = engin;
        }
        public University(University univerForCopy)
        {
            this.Name = univerForCopy.Name;
            this.Faculty = univerForCopy.Faculty;
            this.Labs = univerForCopy.Labs;
            this.Lectures = univerForCopy.Lectures;
            this.Teachers = univerForCopy.Teachers;
            this.Students = univerForCopy.Students;
            this.Engineers = univerForCopy.Engineers;
        }

        public void AddStudents(uint number) => Students += number;
        public void DeleteStudents(uint number) => Students -= number;
        public void AddLectures(uint number) => Lectures += number;
        public void DeleteLectures(uint number) => Lectures -= number;
        public void AddLabs(uint number) => Labs += number;
        public void DeleteLabs(uint number) => Labs -= number;
        public void AddTeachers(uint number) => Teachers += number;
        public void DeleteTeachers(uint number) => Teachers -= number;
        public void AddEngineers(uint number) => Engineers += number;
        public void DeleteEngineers(uint number) => Engineers -= number;

        public bool Equals(University a, University b)
        {
            return (a.Faculty == b.Faculty
                && a.Labs == b.Labs
                && a.Lectures == b.Lectures
                && a.Students == b.Students
                && a.Teachers == b.Teachers
                && a.Engineers == b.Engineers); 
        }

        public int GetHashCode(University univ)
        {
            uint newHCode = univ.Faculty ^ univ.Labs ^ univ.Lectures
                ^ univ.Students ^ univ.Engineers;
            return newHCode.GetHashCode();
        }
        public static University operator +(University a, University b)
        {
            return new University(a.Name + " + " + b.Name,
                a.Faculty + b.Faculty,
                a.Labs + b.Labs,
                a.Lectures + b.Lectures,
                a.Students + b.Students,
                a.Teachers + b.Teachers,
                a.Engineers + b.Engineers);
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
                        return Lectures;

                    default:
                        throw new Exception("Невірний індекс");
                }
            }
            set
            {
                switch (index)
                {
                    case 0:
                        Labs = value;
                        break;
                    case 1:
                        Lectures = value;
                        break;
                    default:
                        throw new Exception("Невірний індекс");
                }
            }
        }

    }
}

