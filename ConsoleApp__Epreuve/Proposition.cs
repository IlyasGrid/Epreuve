using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpreuveCs
{
    public class Proposition
    {
        string strPropo;
        int idExaminateur;
        public Proposition() { }
        public Proposition(string proposition, int idExaminateur)
        {
            strPropo = proposition;
            IdExaminateur = idExaminateur;
        }
        public int IdExaminateur { get { return idExaminateur; } set { idExaminateur = value; } }
        public string proposition { get { return strPropo; } set { strPropo = value; } }

    }
}
