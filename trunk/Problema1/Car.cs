using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    public abstract class Car
    {
        String _name;
        String _color;
        int _transmission;   //0 - manual ; 1 - automatic

        public Car (String name, String color, int transm)
        {
            _name = name;
            _color = color;
            _transmission = transm;
        }

        public String GetName()
        {
            return this._name;
        }
        public String GetColor()
        {
            return this._color;
        }
        public int GetTransm()
        {
            return this._transmission;
        }

    }
}
