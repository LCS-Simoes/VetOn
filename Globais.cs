using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetOn
{
    internal class Globais
    {
        //Programa
        public static string versão = "1.0";
        public static string caminho = System.Environment.CurrentDirectory;
        public static string nomeBanco = "bd_vet.db";
        public static string camnhoBanco = caminho + @"\bd_vet\";

        //Usuario
        public static string nivel = "";

        //Animais
        public static string caminhoFotos = caminho + @"\Fotos\";
    }
}
