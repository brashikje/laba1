using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class Student
    {
        private string name;
        private int kurs;
        private bool pol;
        /// <summary>
        /// Инициализирует новый экземпляр класса Student значением по умолчанию
        /// </summary>
        
        public Student()
        {
            this.name = "";
            this.kurs = 0;
            this.pol = false;
            /// <summary>
            /// Инициализирует новый конструктор по умолчанию
            /// </summary>
        }
    }
}
