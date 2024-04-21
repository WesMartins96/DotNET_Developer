using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos.Models
{
    public class Curso
    {
        public string NomeCurso { get; set; }
        public List<Aluno> Alunos { get; set; }


        public void AdicionarAluno(Aluno aluno)
        {
            Alunos.Add(aluno);
        }

        public int QuantidadeAlunosMatriculados()
        {
            return Alunos.Count;
        }

        public void RemoverAluno(Aluno aluno)
        {
            Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            foreach (Aluno aluno in Alunos)
            {
                Console.WriteLine($"-> Nome: {aluno.Nome} | Idade: {aluno.Idade} | Curso: {NomeCurso}");
            }
        }

    }
}
