using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace BLL
{
   public class DocumentoPDFService:IFormatoDocumento
    {
        
        public string Generar()
        {
            return "Es es el Formato del Docuemnto:";
        }
    }
}
