using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Utilitarios
{
   public static class Util_Log
    {
        public static void log(string texto)
        {
            string caminho = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            string arquivo = "log.txt";
            string caminhoCompleto = Path.Combine(caminho, arquivo);
            StreamWriter streamWriter = new StreamWriter(caminhoCompleto);
            streamWriter.WriteLine(DateTime.Now + ": " + texto);
            streamWriter.Close();
        }
    }
}
