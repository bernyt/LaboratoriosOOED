using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoraIMC
{
    class Aluno
    {   
        // Atributos
        public string nome;
        public int idade;
        public float altura;
        public float peso;

        // Construtor
        public Aluno(string nome_, int idade_, float altura_, float peso_)
        {
            nome = nome_;
            idade = idade_;
            altura = altura_;
            peso = peso_;
        }

        // Método 1
        public float CalcularIMC()
        {
            return peso / (altura * altura);
        }

        // Método 2
        public string DescreverSituacaoCorporal()
        {
            string situacaoCorporal = "Não foi possível verificar a situação corporal!";
            double imc = CalcularIMC();
            if ((18.5 <= imc) && (24.9 >= imc))
            {
                situacaoCorporal = "Parabéns - você está em seu peso normal!";
            }
            if ((25.0 <= imc) && (29.9 >= imc))
            {
                situacaoCorporal = "Você está acima de seu peso (sobrepeso).";
            }
            if ((30.0 <= imc) && (34.9 >= imc))
            {
                situacaoCorporal = "Obesidade grau I.";
            }
            if ((35.0 <= imc) && (39.9 >= imc))
            {
                situacaoCorporal = "Obesidade grau II.";
            }
            if (imc >= 40)
            {
                situacaoCorporal = "Obesidade grau III e IV.";
            }
            return situacaoCorporal;
        }

        // Método 3
        public float CalculareMetaPerdaPeso()
        {
            float imcMaxIdeal = 24.9f;
            float pesoIdeal = imcMaxIdeal * (altura * altura);
            if (peso - pesoIdeal <= 0)
            {
                return 0;
            }
            else
            {
                return peso - pesoIdeal;
            }
        }
    }
}
