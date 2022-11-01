using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp__Epreuve
{
    public class Epreuve
    {
  
            DateTime dateEpreuve;
            string duree;
            string matiere;
            int noteTotal;
            string idExaminateur;
            DateTime dateDebut;
            DateTime dateFin;

        public List<Question> questions;
        public Epreuve(int noteTotal, DateTime dateEpreuve, string duree, string matiere, string idExaminateur, DateTime dateDebut,    DateTime dateFin)
        {
            questions = new List<Question>();
        }
        public List<Question> Comptes
        {
            get { return questions; }
        }



        public void setDateEpreuve()
        {
            this.dateEpreuve = DateTime.Today;
        }

           
        public void setDuree(int hour , int minute)
        {
            this.duree = hour + "h" + minute + "min";
        }

        public DateTime setDateDebut()
        {
            ;

            return this.dateDebut = DateTime.Now;
        }
        
        public DateTime GetDatedebut()
        {
            return this.dateDebut;
        }
        public DateTime setDatefin()
        {
            dateFin = DateTime.Now;
            if ( dateFin > dateDebut.AddHours(2) )
            {
                dateFin = dateDebut.AddHours(2);
            }


            return this.dateFin;

        }
         
        public DateTime GetDatefin()
        {
            return this.dateFin;
        }

        public void ouvrirEpreuve()
        {
            setDateDebut();

        }
            public void fermerEpreuve()
        {
            setDatefin();
        }
        
    }
}
