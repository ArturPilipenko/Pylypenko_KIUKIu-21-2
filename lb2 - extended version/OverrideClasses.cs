using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb2
{
    public class Lab: Hall
    {
        private uint numComputers;
        public uint NumComputers { get => numComputers; set => numComputers = value; }

        private double wifiSpeed;
        public double WifiSpeed { get => wifiSpeed; set => wifiSpeed = value; }

        public override string[] OutputInformation()
        {
            return new string[] { $"Номер аудиторії: {this.LectionID.ToString()}",
                $"Кількість слухачів: {this.NumListener.ToString()}",
                $"Кількість комп'ютерів: {this.NumComputers.ToString()}",
                $"Швидкість WiFi: {this.WifiSpeed.ToString()}"
            };
        }
    }
    
    public class Auditory : Hall
    {
        private uint numInteractDesk;
        public uint NumInteractDesk { get => numInteractDesk; set => numInteractDesk = value; }

        private bool isProjector;
        public bool IsProjector { get => isProjector; set => isProjector = value; }

        private bool isWiFi;
        public bool IsWiFi { get => isWiFi; set => isWiFi = value; }

        public override string[] OutputInformation()
        {
            return new string[] { $"Номер аудиторії: {this.LectionID.ToString()}",
                $"Кількість слухачів: {this.NumListener.ToString()}",
                $"Кількість інтерактивних дошок: {this.NumInteractDesk.ToString()}",
                $"Наявність проектору: {this.IsProjector.ToString()}",
                $"Наявність WiFi: {this.IsWiFi.ToString()}",
            };
        }
    }

    public class Lecturer : Worker
    {
        private uint numDisciplines;
        public uint NumDisciplines { get => numDisciplines; set => numDisciplines = value; }

        private uint scientificWorks;
        public uint ScientificWorks { get => scientificWorks; set => scientificWorks = value; }

        public override string[] OutputInformation()
        {
            return new string[] { $"ПІБ: {this.Name}",
                $"Номер паспорту: {this.PassportID}",
                $"Кількість дисциплін: {this.NumDisciplines.ToString()}",
                $"Кількість наукових робіт: {this.ScientificWorks.ToString()}"
            };
        }
    }

    public class Engineer : Worker
    {
        private uint numYearsOnPosition;
        public uint NumYearsOnPosition { get => numYearsOnPosition; set => numYearsOnPosition = value; }

        private bool isSertificate;
        public bool IsSertificate { get => isSertificate; set => isSertificate = value; }

        public override string[] OutputInformation()
        {
            return new string[] { $"ПІБ: {this.Name}",
                $"Номер паспорту: {this.PassportID}",
                $"Кількість років на посаді: {this.NumYearsOnPosition.ToString()}",
                $"Наявність сертифікату: {this.IsSertificate.ToString()}"
            };
        }
    }
}
