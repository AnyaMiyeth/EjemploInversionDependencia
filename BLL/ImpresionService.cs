using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ImpresionService
    {
        public string CrearDocuemtno()
        {
            string Documento = " Esta es la informacion del Documento";


            return Documento;
        }


        public string GenerarPDF()
        {

            string DocumentoPDF = "Este es el Docuemnto PDF:" + CrearDocuemtno();

            return DocumentoPDF;
        }

        public string Imprimir()
        {

             return GenerarPDF();
        }
    }

    public class ImpresionService2
    {
        DocumentoService DocumentoConstruido;
        DocumentoPDFService FormatoDocumento;

        public ImpresionService2() {
            DocumentoConstruido = new DocumentoService();
            FormatoDocumento = new DocumentoPDFService();
        }
        public string Imprimir()
        {
            return FormatoDocumento.Generar()+DocumentoConstruido.crearDocumento()  ;
        }
    }


    public class ImpresionService3
    {
        DocumentoService DocumentoConstruido;
        DocumentoPDFService FormatoDocumento;

        public ImpresionService3 (DocumentoService documentoConstruido, DocumentoPDFService formatoDocumento)
        {
            DocumentoConstruido = documentoConstruido;
            FormatoDocumento = formatoDocumento;
        }
        public string Imprimir()
        {
            return FormatoDocumento.Generar() + DocumentoConstruido.crearDocumento();
        }
    }



    public class ImpresionService4
    {
        DocumentoService DocumentoConstruido;
        IFormatoDocumento FormatoDocumento;

        public ImpresionService4(DocumentoService documentoConstruido, IFormatoDocumento formatoDocumento)
        {
            DocumentoConstruido = documentoConstruido;
            FormatoDocumento = formatoDocumento;
        }
        public string Imprimir()
        {
            return FormatoDocumento.Generar() + DocumentoConstruido.crearDocumento();
        }
    }
}
