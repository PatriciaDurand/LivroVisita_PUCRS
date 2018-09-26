using System;
using System.Collections.Generic;
using System.Text;

namespace LivroVisitas.BLL
{
    public class VisitaException : Exception
    {

        public VisitaException(Exception ex)
        {
            ErrorMessage = "Visita ERROR " + ex.Message;
        }

        public VisitaException(String msg)
        {
            ErrorMessage = msg;
        }


        private String ErrorMessage { get; set; }

        public override String Message
        {
            get { return ErrorMessage; }
        }
    }
}
