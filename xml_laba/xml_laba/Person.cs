using System;
using System.Collections.Generic;
using System.Text;

namespace xml_laba
{
    class Person
    {
        private string name;
        private string department;
        private string catedra;
        private string date;
        private string degree;
        private string sex;

        public string Name { get => name; set => name = value; }
        public string Department { get => department; set => department = value; }
        public string Catedra { get => catedra; set => catedra = value; }
        public string Date { get => date; set => date = value; }
        public string Degree { get => degree; set => degree = value; }
        public string Sex { get => sex; set => sex = value; }
    }
}
