using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp__Epreuve
{
    internal class Examinateur
    {
        string nom;
        string prenom;
        string id;
         
        Examinateur(string nom, string prenom, string id)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.id = id;
        }
        public void setName(string prenom)
        {
            this.prenom = prenom;
        }
        public void setLastName(string nom)
        {
            this.nom = nom;
        }
        public void setId(string id)
        {
            this.id = id;
        }
        public string getName()
        {
            return this.prenom; 
        }
        public string getLastName()
        {
            return this.nom;    
        }
        public string getId()
        {
            return id;
        }
    }

}
