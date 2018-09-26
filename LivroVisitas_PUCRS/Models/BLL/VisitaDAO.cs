using System;
using System.Collections.Generic;
using System.Text;

namespace LivroVisitas.BLL
{
    public interface VisitaDAO
    {
        void salvar(Visita c); //throws CpfDuplicadoException, DAOException;
        List<Visita> buscarVisita(); //throws DAOException;
    }
}
