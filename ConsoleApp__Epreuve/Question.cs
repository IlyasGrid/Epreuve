using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp__Epreuve
{
    public class Question
    {
        string ennonce;
        int noteQuestion;
        Reponse[] correctRps;

        public void setEnonce()
        {
            this.ennonce = Console.ReadLine();
        }

        public string showEnonce()
        {
            return this.ennonce;
        }

        public void donnerNote(int note)
        {
            this.noteQuestion = note;
        }
        public int getNoteQuestion()
        {
            return this.noteQuestion;
        }

        public Reponse[] setCorrectRps(Reponse[] rps)
        {
            return correctRps = rps;
        }
    }




    class Qcm : Question
    {
        int nombreChoix;

        public void setNbrChoix(int nbrchoix)
        {
            this.nombreChoix = nbrchoix;
        }

        public int getNbrChoix()
        {
            return this.nombreChoix;
        }

    }
    class QusetionOuverte : Question
    {

    }

}
