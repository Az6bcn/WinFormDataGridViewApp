using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationDataGridView
{
    class Person
    {
        private string name { set; get; }
        private string surname { set; get; }
        private string address { set; get; }
        private int age { set; get; }



        public void createPerson(string nom, string surn, string addr, int ag)
        {
            this.name = nom;
            this.surname = surn;
            this.address = addr;
            this.age = ag;
        }
    }

    

}
