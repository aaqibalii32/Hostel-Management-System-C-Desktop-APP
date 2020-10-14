using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Databasep.Repositry;
using System.Threading.Tasks;

namespace Databasep.Repositry
{
    class Personservices
    {   public void addperson(Person obj) {
            var dv = new PersonDB();
            dv.register(obj);
        }
        public void adduser(Person obj) {
            var adv = new PersonDB();
            adv.addUser(obj);

        }
        public void addvisitor(Person obj)
        {

            var adv = new PersonDB();
            adv.addvisitor(obj);
        }
        public void addemployee(Person obj) {
            var adv = new PersonDB();
            adv.addemploy(obj);
        }
        public void addfees(Person obj) {
            var adv = new PersonDB();
            adv.addfee(obj);
        }
        public void addstatus(Person obj) {
            var adv = new PersonDB();
            adv.addstatus(obj);
        }
    }
}
