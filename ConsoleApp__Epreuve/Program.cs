using System;

namespace EpreuveCs
{
    public class Program
    {
        static void Main(string[] args)
        {
            DateTime d = DateTime.Parse("2010/5/4");
            Epreuve ep = new Epreuve("math", "2", 10, 40, d);
            ep.AddQuestion(new Qcm("ou se passe le mondial", 20));
            Qcm q1 = new("ou se passe le mondial", 10);
            q1.AddReponses(new(false, "maroc"));
            q1.AddReponses(new(true, "qatar"));
            q1.AddReponses(new(false, "rome"));
            Console.WriteLine(q1.Choix[1].StrRepons);
            ep.AddQuestion(q1);

        }

    }

}