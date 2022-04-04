using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno alunoBob = new Aluno("Bob Nelson", 37, 1.70f, 78);
            Console.WriteLine($"O IMC do(a) {alunoBob.nome} é: {alunoBob.CalcularIMC().ToString("F")} Kg/m2.");
            Console.WriteLine($"A situação é: {alunoBob.DescreverSituacaoCorporal()}");
            Console.WriteLine($"Meta de perda de peso: {alunoBob.CalculareMetaPerdaPeso().ToString("F")} kg.");
            Console.ReadLine();

            Aluno alunoTestolfo = new Aluno("Testolfo Rocha", 43, 1.65f, 60);
            Console.WriteLine($"O IMC do(a) {alunoTestolfo.nome} é: {alunoTestolfo.CalcularIMC().ToString("F")} Kg/m2.");
            Console.WriteLine($"A situação é: {alunoTestolfo.DescreverSituacaoCorporal()}");
            Console.WriteLine($"Meta de perda de peso: {alunoTestolfo.CalculareMetaPerdaPeso().ToString("F")} kg.");
            Console.ReadLine();

            Aluno alunoLisa = new Aluno("Lisa Leite", 22, 1.72f, 92);
            Console.WriteLine($"O IMC do(a) {alunoLisa.nome} é: {alunoLisa.CalcularIMC().ToString("F")} Kg/m2.");
            Console.WriteLine($"A situação é: {alunoLisa.DescreverSituacaoCorporal()}");
            Console.WriteLine($"Meta de perda de peso: {alunoLisa.CalculareMetaPerdaPeso().ToString("F")} kg.");
            Console.ReadLine();
        }
    }
}
