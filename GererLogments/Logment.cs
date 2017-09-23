using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GererLogments
{
    [Serializable]class Logment
    {
        private uint _IdLogment; // 0>=
        private static uint numeroLogment; //auto increment ndiroh static // 
        private string _Adresse;
        private uint _superficie; // positive
        private string _Type;
        private uint _Prix; // positif

        public Logment(string adress, uint superficie,string type,uint prix)
        {
            numeroLogment++;

            _IdLogment = numeroLogment;
            _Adresse = adress;
            _superficie = superficie;
            _Type = type;
            _Prix = prix;

        }

        //properties 
        static public uint NumeroLogment {
            get { return numeroLogment; }
        }
        public uint IdLogment
        {
            get { return _IdLogment; }
        }

        
        public string Adresse{
            
            get{ return _Adresse; }
            set { _Adresse = value; }
            }

        public uint Superficie{
        
            get { return _superficie; }
            set { _superficie = value; }
        }

        public string Type {

            get { return _Type; }
            set { _Type = value; }
        }
        public uint Prix {
            get { return _Prix; }
            set {_Prix = value; }
        }


        


    }
}
