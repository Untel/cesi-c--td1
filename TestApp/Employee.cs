using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{

    public class Employee
    {
        protected string m_Nom;

        public Employee(string Nom)
        {
            m_Nom = Nom;
        }

        public virtual void GetDescription()
        {
            Console.Write("Nom: {0}", m_Nom);
        }

    }

    class Technicien : Employee
    {
        public Technicien(string Nom) : base(Nom) { }
        public override void GetDescription()
        {
            base.GetDescription();
            Console.Write("  Fonction Technicien");
        }
    }


    class Secretaire : Employee
    {
        public Secretaire(string Nom) : base(Nom) { }
        public override void GetDescription()
        {
            base.GetDescription();
            Console.Write("  Fonction Secretaire");
        }
    }
}