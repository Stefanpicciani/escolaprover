using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaProver
{
    partial class Program
    {
        static void DeletarAluno(List<Aluno> alunos)
        {
        deletar:
            Console.Clear();
            Console.WriteLine("Escolha o aluno a ser deletado pela matrícula : ");
           
            foreach (Aluno Aluno in alunos)
            {

                Console.WriteLine();
                Console.WriteLine($"Matrícula: {Aluno.Matricula}, Aluno: {Aluno.NomeAluno}");
                Console.WriteLine();

            }

            try
            {
                int matricula = int.Parse(Console.ReadLine());


                var aluno = alunos.Where(x => x.Matricula == matricula).FirstOrDefault();
                                
                    
                
                if (aluno == null)
                {
                    
                    Console.WriteLine("Número de matrícula não encontrado para deletar. Tecle [1] para voltar ao cadastro e [2] para sair: ");
                    int escolha = int.Parse(Console.ReadLine());

                    if(escolha == 1)
                    {
                        goto deletar;
                    }
                    else if (escolha == 2)
                    {
                        goto sair;
                    }
                    
                    
                    else
                    {
                        goto deletar;
                    }

                }
                
                 if (aluno.ToString() == "")
                    {
                        Console.WriteLine("Você não deletou nenhuma turma!");
                        Console.WriteLine();
                        Console.WriteLine("Tecle [1] para voltar a opção de deletar ou [s] para sair.");
                        string naoCadastrado = Console.ReadLine();

                        if (naoCadastrado == "1")
                        {
                            goto deletar;
                        }
                       
                        else if (naoCadastrado == "s")
                        {
                            goto sair;
                        }
                        else
                        {
                        invalido6:
                            Console.Clear();
                            Console.WriteLine("Opção inválida!");
                            Console.WriteLine();
                            Console.WriteLine("Tecle [1] para voltar ao cadastro ou [s] para sair.");
                            string nenhum = Console.ReadLine();

                            if (nenhum == "1")
                            {
                                goto deletar;
                            }
                            
                            else if (nenhum == "s")
                            {
                                goto sair;
                            }
                            else
                            {
                                goto invalido6;
                            }

                        }

                    }

                if (matricula.ToString() == "")
                {
                    goto deletar;
                }
                
                

                alunos.Remove(aluno);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Removido com sucesso ");
                Console.WriteLine();
                Console.ResetColor();
                Console.WriteLine("Aperte [Enter] para voltar");
                Console.ReadLine();
            }
            catch (Exception)
            {

                goto deletar;
            }


        sair:;
        }

        static void DeletarTurma(List<Turma> turmas)
        {
            numero1:
            Console.WriteLine("Escolha a turma a ser deletada pelo número: ");

            foreach (Turma Turma in turmas)
            {

                Console.WriteLine();
                Console.WriteLine($"Número da turma: {Turma.NumeroTurma}, Turma: {Turma.NomeTurma}");
                Console.WriteLine();

            }

            try
            {
                int numeroTurma = int.Parse(Console.ReadLine());

                var aluno = turmas.Where(x => x.NumeroTurma == numeroTurma).FirstOrDefault();

                turmas.Remove(aluno);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Removido com sucesso ");
                Console.WriteLine();
                Console.ResetColor();
                Console.WriteLine("Aperte [Enter] para voltar");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.ForegroundColor= ConsoleColor.Red;  
                Console.WriteLine("Número de matrícula inválido!");
                Console.ResetColor();

                goto numero1;
            }
           

        }
        static void DeletarMateria(List<Materia> materias)
        {
            Console.WriteLine("Escolha a matéria a ser deletada pelo número de ID: ");

            foreach (Materia Materia in materias)
            {

                Console.WriteLine();
                Console.WriteLine($"ID da matéria: {Materia.IDMateria}, Matéria: {Materia.NomeMateria}");
                Console.WriteLine();

            }
            int numeroMateria = int.Parse(Console.ReadLine());

            var materia = materias.Where(x => x.IDMateria == numeroMateria).FirstOrDefault();

            materias.Remove(materia);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Removido com sucesso ");
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine("Aperte [Enter] para voltar");
            Console.ReadLine();

        }

    }
}
