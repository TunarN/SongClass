using System;
using System.Collections.Generic;
using System.Text;

namespace SongClass.model
{
    class Singer
    {
        private string _name;
        private string _surname;
        private int _age;
        public string Name {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length<=100)
                {
                    value = _name;
                }
            }
        }
        public string Surname {
            get
            {
                return _surname;
            }
            set
            {
                if (value.Length<=100)
                {
                    value = _surname;
                }
            }
        }
        public int Age {
            get
            {
                return _age;
            }
            set
            {
                if (value<=170)
                {
                    value = _age;
                }
            }
        }
    }
}
