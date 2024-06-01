using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        private List<string> ListaHistorico;

        public CalculadoraImp()
        {
            ListaHistorico = new List<string>();
        }

        public int Somar(int num1, int num2)
        {
            ListaHistorico.Insert(0, "Ultima operação:" + num1 + num2);
            return num1 + num2;
        }

        public int Subtrair(int num1, int num2)
        {
            ListaHistorico.Insert(0, "Ultima operação:" + num1 + num2);
            return num1 - num2;
        }

        public int Multiplicar(int num1, int num2)
        {
            ListaHistorico.Insert(0, "Ultima operação:" + num1 + num2);
            return num1 * num2;
        }

        public int Dividir(int num1, int num2)
        {
            ListaHistorico.Insert(0, "Ultima operação:" + num1 + num2);
            return num1 / num2;
        }

        public  List<string> Historico()
        {
            ListaHistorico.RemoveRange(3, ListaHistorico.Count - 3);
            return ListaHistorico;
        }
    }
}