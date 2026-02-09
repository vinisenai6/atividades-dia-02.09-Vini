using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace att_aula_02._09
{
    public class Calculadora
    {
        public double Adicao { get; set; }
        public double Sub { get; set; }
        public double Div { get; set; }
        public double Mult { get; set; }

            public void CalculoMais(double a,Double b)
        {
            Adicao = a + b;
            Console.WriteLine($"A soma de {a} e {b} é : {Adicao}");
        }

            public void CalculoSub(double a,Double b)
        {
            Sub = a - b;
            Console.WriteLine($"A subtração de {a} e {b} é : {Sub}");
        }

            public void CalculoDiv(double a,Double b)
        {
            Div = a / b;
            Console.WriteLine($"A divisão de {a} e {b} é : {Div}");
        }


            public void CalculoMult(double a,Double b)
        {
            Mult = a * b;
            Console.WriteLine($"A multiplicação de {a} e {b} é : {Mult}");
        }

    }
}