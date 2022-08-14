using System;
using System.Collections.Generic;
using System.Text;

namespace SongClass.model
{
    class Song
    {
        private string _name;
        private string _genre;
        private float _rating = 0;
        private float _count = 0;
        public Singer Singer { get; set; }
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
        public string Genre {
            get
            {
                return _genre;
            }
            set
            {
                if (value=="Pop"||value=="Rock"||value=="Jazz"||value=="Techno")
                {
                    value = _genre;
                }
            }
         }
        public void Addreting(float Rate)
        {
            if (Rate>10)
            {
                Rate = 10;

            }
            _count++;
            _rating = ((_count - 1) * _rating + Rate) / _count;
             
        }
        public float GetAverageRating()
        {
            return _rating;
        }
    }
}
