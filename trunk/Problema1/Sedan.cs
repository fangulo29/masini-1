using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    public class Sedan : Car
    {
        int _engine; //0 - Diesel ; 1 - Gas
        

        public Sedan(String name, String color, int transm, int eng)
            : base(name, color, transm)
        {
            _engine = eng;
        }

        public int GetEng()
        {
            return this._engine;
        }
        }
}
