using Metodos.Models;


Aluno aluno1 = new Aluno();
aluno1.Nome = "Wesley Martins";
aluno1.Idade = 27;

Aluno aluno2 = new Aluno();
aluno2.Nome = "Beatriz Cristina";
aluno2.Idade = 26;

Aluno aluno3 = new Aluno();
aluno3.Nome = "Gael Cachorro";
aluno3.Idade = 4;

Curso curso = new Curso();
curso.NomeCurso = ".NET Developer AVANADE";
curso.Alunos = new List<Aluno>();

curso.AdicionarAluno(aluno1);
curso.AdicionarAluno(aluno2);

Curso cursoPet = new Curso();
cursoPet.NomeCurso = "Curso PET";
cursoPet.Alunos = new List<Aluno>();

cursoPet.AdicionarAluno(aluno3);

curso.ListarAlunos();
cursoPet.ListarAlunos();
