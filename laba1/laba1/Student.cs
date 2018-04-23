using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class Student
    {
        private string Name;
        private int Kurs;
        private bool Pol;
        /// <summary>
        /// Инициализирует новый экземпляр класса Student значением по умолчанию
        /// </summary>
        public Student()
        {
            this.Name = "";
            this.Kurs = 0;
            this.Pol = false;
        }
        /// <summary>
        /// Инициализирует новый экземпляр класса Student значениями Имя, курс, пол
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="kurs">Курс</param>
        /// <param name="pol">Пол</param>
        public Student(String name, int kurs, bool pol)
        {
            Name = name;
            Kurs = kurs;
            Pol = pol;
        }
        public override string ToString()
        {
            return "Имя = " + Name + " курс = " + Kurs + " Пол = " + Pol ;
        }
    }
}
