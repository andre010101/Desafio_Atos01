using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace desafio10_arquivos
{
    internal class Util
    {
        int pessoasTtoal = 0;
        int alunosTtoal = 0;
        List<Pessoa> listapessoas = new List<Pessoa>();
        string[] list = File.ReadAllLines("C:\\Ambiente\\Andre\\academia\\desafio10-arquivos\\10-TXTdesafio10_Arquivo.txt.txt");
        public void LeArquivo()
        {
            Aluno al = new Aluno();
            for (int i = 0; i < list.Length; i++)
            {
                string[] auxiliarAlunosZ = list[i].Split('-');
                string[] auxiliarAlunosY = list[i].Split('-');
                string LetrasZ = auxiliarAlunosZ[0];
                string LetrasY = auxiliarAlunosY[0];
                if (LetrasZ == "Z")
                {
                    al.nome = auxiliarAlunosZ[1];
                    al.telefone = auxiliarAlunosZ[2];
                    al.cidade = auxiliarAlunosZ[3];
                    al.RG = auxiliarAlunosZ[4];
                    al.CPF = auxiliarAlunosZ[5];
                    Console.WriteLine($"Nome:{al.nome}\nTelefone:{al.telefone}\nCidade:{al.cidade}\nRG:{al.RG}\nCPF:{al.CPF}");
                }
                else if (LetrasY == "Y")
                {
                    al.matricula = auxiliarAlunosY[1];
                    al.codigoCurso = auxiliarAlunosY[2];
                    al.curso = auxiliarAlunosY[3];
                    Console.WriteLine($"matricula:{al.matricula}\ncodigoCurso:{al.codigoCurso}\ncurso:{al.curso}\n");
                    Console.WriteLine(@"- - - - - - - - - - - - - - - - - - - - - - - - - - - ");
                }
                if (i == 6)
                {
                    i++;
                }
                else if (i == 11)
                {
                    i++;
                }
               
            }

        }

        public void AdicionaPessoas()
        {
            for (int i = 0; i < list.Length; i++)
            {
                Pessoa p = new Pessoa();
                string[] auxiliarPessoasZ = list[i].Split('-');
                string LetrasZ = auxiliarPessoasZ[0];
                if (LetrasZ == "Z")
                {
                    p.nome = auxiliarPessoasZ[1];
                    p.telefone = auxiliarPessoasZ[2];
                    p.cidade = auxiliarPessoasZ[3];
                    p.RG = auxiliarPessoasZ[4];
                    p.CPF = auxiliarPessoasZ[5];
                }
                if (i == 7)
                {
                    listapessoas.Add(p);
                    pessoasTtoal++;

                }
                else if (i == 12)
                {
                    listapessoas.Add(p);
                    pessoasTtoal++;
                }
            }
        }
        public void ContaNumeroAlunos()
        {
            foreach (string auxiliarAlunosY in list)
            {
                if (auxiliarAlunosY.Contains("Y"))
                {

                    alunosTtoal++;
                }
            }
        }
        public void ApresentaNumeroAlunosPessoas()
        {
            Console.WriteLine($"| total de pessoas é de {pessoasTtoal} e o total de alunos é de {alunosTtoal} |");
            Console.WriteLine(@"- - - - - - - - - - - - - - - - - - - - - - - - - - - ");
            Console.ReadKey();
        }
        public void ApresentarPessoas()
        {
            foreach (Pessoa a in listapessoas)
            {
                Console.WriteLine(@"Pessoas Nome: {0};Telefone: {1}; Cidade: {2};RG: {3};CPF: {4} ", a.nome, a.telefone, a.cidade, a.RG, a.CPF);
                
            }
        }
    }
}

