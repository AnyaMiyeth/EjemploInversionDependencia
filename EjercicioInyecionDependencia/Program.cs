using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
namespace EjercicioInyecionDependencia
{
    class Program
    {
        static void Main(string[] args)
        {


            ImpresionService2 ServicioImpresion2 = new ImpresionService2();
            Console.WriteLine(ServicioImpresion2.Imprimir());
            Console.ReadKey();



            ImpresionService ServicioImpresion = new ImpresionService();
            Console.WriteLine(ServicioImpresion.Imprimir());
            Console.ReadKey();


            

            DocumentoPDFService FormatoPdf = new DocumentoPDFService();
            DocumentoService DocumentoConstruido = new DocumentoService();
            ImpresionService3 ServicioImpresion3 = new ImpresionService3(DocumentoConstruido, FormatoPdf);
            Console.WriteLine(ServicioImpresion3.Imprimir());
            Console.ReadKey();




            IFormatoDocumento Formatopdf = new DocumentoPDFService();
            IFormatoDocumento FormatoExcel = new DocumentoExcelService();

            DocumentoService DocumentoConstruido2 = new DocumentoService();

            ImpresionService4 ServicioImpresion4 = new ImpresionService4(DocumentoConstruido2, Formatopdf);
            ImpresionService4 ServicioImpresion5 = new ImpresionService4(DocumentoConstruido2, FormatoExcel);

            Console.WriteLine(ServicioImpresion4.Imprimir());
            Console.WriteLine(ServicioImpresion5.Imprimir());

            Console.ReadKey();
        }
    }
}
