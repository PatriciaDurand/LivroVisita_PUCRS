using LivroVisitas.PL;
using LivroVisitas.BLL;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivroVisitas.PL
{
    class VisitaDAOMemory : VisitaDAO
    {
        private static Dictionary<String, Visita> dados;


        public List<Visita> buscarVisita()
        {
            List<Visita> res = new List<Visita>();
            foreach (Visita c in dados.Values)
                res.Add(c);

            return res;
        }

        public void salvar(Visita v)
        {
            dados[v.getEmail()] = v;
        }

        static VisitaDAOMemory()
        {
            dados = new Dictionary<string, Visita>();

            dados["1"] = new Visita("Julio", "Machado", "julio.machado@pucrs.br");
            dados["2"] = new Visita("Bernardo", "Copstein", "bernardo.copstein@pucrs.br");
        }
    }
}
