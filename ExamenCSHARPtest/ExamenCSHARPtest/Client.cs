using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenCSHARPtest
{

    class Client
    {
        public string Nom;
        double dettes;
        public double Dettes
        {
            set
            {
                dettes = value;
            }
            get
            {
                return dettes;
            }
        }
        public Client(string Nom, double dettes)
        {


            this.Nom = Nom;
            this.Dettes = dettes;
        }
        public Client(string Nom) : this(Nom, 0.0)
        {
        }
    }
}
