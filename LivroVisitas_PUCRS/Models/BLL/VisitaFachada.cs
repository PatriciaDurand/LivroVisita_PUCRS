using LivroVisitas.PL;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivroVisitas.BLL
{
    public class VisitaFachada
    {
        private VisitaDAO visitaDao;

        public VisitaFachada()
        {
            visitaDao = new VisitaDAOMemory();

        }

        public void salva(String nome, String sobrenome, String email) //throws IrpfException
        {

            Visita v = new Visita(nome, sobrenome, email);
            try
            {
                visitaDao.salvar(v);
            }
            catch (DAOException e)
            {
                throw new VisitaException(e);
            }
        }

        public List<Visita> getVisitas()
        {
            try
            {
                return visitaDao.buscarVisita();
            }
            catch (Exception e)
            {
                throw new VisitaException(e);
            }
        }

    }
}
