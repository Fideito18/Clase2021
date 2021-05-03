using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exercicis_II
{
    public abstract class empleat
    {
        private string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        private string cognom;

        public string Cognom
        {
            get { return cognom; }
            set { cognom = value; }
        }
        private string sou;

        public string Sou
        {
            get { return sou; }
            set { sou ="Cobra :"+value+ " "; }
        }
        private string dni;

        public string Dni
        {
            get { return dni; }
            set { dni = "Amb DNI: "+value+ ","; }
        }
    
        public virtual string info()
        {
            return Dni + Sou;
        }
    }
}
