using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exercicis_II
{
    public class becaris : empleat, estudiants
    {
        private string carrera;

        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }
        private decimal curs;

        public decimal Curs
        {
            get { return curs; }
            set { curs = value; }
        }
        private string departament;

        public string Departament
        {
            get { return departament; }
            set { departament = value; }
        }
        string notes, uni, mitja;
        public void quatrimestres(decimal pri, decimal seg, decimal ter)
        {
            notes=pri+ " "+seg+ " " +ter +" .";
        }

        public void universitat(string univ)
        {
            uni = univ;
        }

        public void mitjana(decimal final)
        {
            mitja = final.ToString();
        }
        public override string info()
        {
            return "El becari , " + Nom + " " + Cognom + ", amb DNI: " + Dni + "\n Te aquestes notes:" + notes + ", que fan una mitjande de : "+ mitja+"\n Ha estudiat a la " + uni + "\n I cobra : " + Sou;
        }
    }
}
