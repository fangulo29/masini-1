using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    abstract class Persoana
    {
        String _firstname;
        String _secondname;
        int _age;

        public Persoana(String fname, String sname, int age)
        {
            _firstname = fname;
            _secondname = sname;
            _age = age;
        }

        public String GetName()
        {
            return this._firstname;
        }

        public String GetSName()
        {
            return this._secondname;
        }
        //public abstract Client CreateClient();
        //public abstract Seller CreateSeller();
    }
}
