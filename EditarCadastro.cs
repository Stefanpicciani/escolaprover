using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaProver
{
    partial class Program
    {
        static void EditarAluno(List<Aluno> cadastroList)
        {
        consulta:
            Console.Clear();
            Console.WriteLine("Escolha o aluno que deseja editar pelo número da matrícula : ");
            
            foreach (var item in cadastroList)
            {
                Console.WriteLine();
                Console.WriteLine($"Matrícula: {item.Matricula} , Nome: {item.NomeAluno} ");
                Console.WriteLine();
            }

            

            try
            {
                int escolha = int.Parse(Console.ReadLine());

                var aluno = cadastroList.Where(x => x.Matricula == escolha).FirstOrDefault();

                Console.WriteLine();


                if (escolha.ToString() == "")
                {
                    goto consulta;
                }

                if (aluno == null)
                {
                erro1:
                    Console.Clear();
                    Console.WriteLine("ID da aluno não encontrado para realizar alteração.");
                    Console.WriteLine();
                    Console.WriteLine("Tecle [1] para voltar a edição ou [0] para sair.");

                    try
                    {
                        int escolha1 = int.Parse(Console.ReadLine());

                        if (escolha1 == 1)
                        {
                            goto consulta;
                        }
                        
                        else if (escolha1 == 0)
                        {
                            goto sair;
                        }
                        else
                        {
                            goto erro1;
                        }
                    }
                    catch (Exception)
                    {

                        goto erro1;
                    }

                }



            nome:
                Console.Clear();
                
                Console.WriteLine("Digite o novo nome a ser definido : ");
                aluno.NomeAluno = Console.ReadLine();

                if (aluno.NomeAluno == null)
                {
                    goto nome;
                }
                if (aluno.NomeAluno.Contains("0") || aluno.NomeAluno.Contains("1") || aluno.NomeAluno.Contains("2") || aluno.NomeAluno.Contains("3") || aluno.NomeAluno.Contains("4") || aluno.NomeAluno.Contains("5") || aluno.NomeAluno.Contains("6") || aluno.NomeAluno.Contains("7") || aluno.NomeAluno.Contains("8") || aluno.NomeAluno.Contains("9"))
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Não é aceito números apenas letras");
                    Console.ResetColor();
                    Console.WriteLine();

                    goto nome;
                }
                else if (aluno.NomeAluno == "")
                {
                    goto nome;
                }

                if (aluno.NomeAluno == "")
                {
                    Console.WriteLine("Você não cadastrou nenhum aluno!");
                    Console.WriteLine();
                    Console.WriteLine("Tecle [1] para voltar a consulta para editar os dados ou tecle [2] para voltar a editar o nome ou [s] para sair.");
                    string naoCadastrado = Console.ReadLine();

                    if (naoCadastrado == "1")
                    {
                        goto consulta;
                    }
                    else if (naoCadastrado == "2")
                    {
                        goto nome;
                    }
                    else if (naoCadastrado == "s")
                    {
                        goto sair;
                    }
                    else
                    {
                    invalido1:
                        Console.Clear();
                        Console.WriteLine("Opção inválida!");
                        Console.WriteLine();
                        Console.WriteLine("Tecle [1] para voltar ao cadastro ou [s] para sair.");
                        string nenhum = Console.ReadLine();

                        if (nenhum == "1")
                        {
                            goto nome;
                        }

                        else if (nenhum == "s")
                        {
                            goto sair;
                        }
                        else
                        {
                            goto invalido1;
                        }

                    }

                }
                 telefone:
                Console.Clear();
                Console.WriteLine("Digite o novo telefone a ser definido : [ddd] + número (Obs: tudo junto).");
                

                try
                {
                    aluno.TelefoneAluno = int.Parse(Console.ReadLine().Trim());
                    if(aluno.TelefoneAluno.ToString() == "")
                    {
                        goto telefone;
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Você não editou nenhum telefone!");
                    Console.WriteLine();
                    Console.WriteLine("Tecle [1] para voltar ao edição ou [s] para sair.");
                    string naoCadastrado = Console.ReadLine();

                    if (naoCadastrado == "1")
                    {
                        Console.Clear();
                        goto telefone;
                    }
                    
                    else if (naoCadastrado == "s")
                    {
                        goto sair;
                    }
                    else
                    {
                    invalido3:
                        Console.Clear();
                        Console.WriteLine("Opção inválida!");
                        Console.WriteLine();
                        Console.WriteLine("Tecle [1] para voltar a edição ou [s] para sair.");
                        string nenhum = Console.ReadLine();

                        if (nenhum == "1")
                        {
                            goto telefone;
                        }
                       
                        else if (nenhum == "s")
                        {
                            goto sair;
                        }
                        else
                        {
                            goto invalido3;
                        }
                    }
                }
                if (aluno.TelefoneAluno.ToString().Length != 11)
                {
                    Console.Clear();
                    Console.WriteLine("Telefone tem que ter 11 digitos");
                    goto telefone;
                }



                Console.Clear();
            nascimento:
                                
                
                Console.WriteLine("Digite a nova data de nascimento a ser definida : ");
                aluno.DataNascimento = Console.ReadLine();

               
                try
                {
                    DateTime data = DateTime.Parse(aluno.DataNascimento);
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("Data no formato inválido");
                    goto nascimento;
                }
                if (aluno.DataNascimento == "")
                {
                    Console.WriteLine("Você não cadastrou nenhuma data de nascimento!");
                    Console.WriteLine();
                    Console.WriteLine("Tecle [1] para voltar ao cadastro, tecle [2] para voltar ao menu principal .");
                    string naoCadastrado = Console.ReadLine();

                    if (naoCadastrado == "1")
                    {
                        goto nascimento;
                    }
                    else if (naoCadastrado == "2")
                    {
                        goto sair;
                    }
                    
                    else
                    {
                    invalido4:
                        Console.Clear();
                        Console.WriteLine("Opção inválida!");
                        Console.WriteLine();
                        Console.WriteLine("Tecle [1] para voltar ao cadastro, tecle [2] para voltar ao menu principal .");
                        string nenhum = Console.ReadLine();

                        if (nenhum == "1")
                        {
                            goto nascimento;
                        }
                        else if (nenhum == "2")
                        {
                            goto sair;
                        }
                        
                        else
                        {
                            goto invalido4;
                        }

                    }

                }



            }
            catch (Exception)
            {

                goto consulta;
            }



        sair:;
        }
        static void EditarTurma(List<Turma> turmaList)
        {
        consulta:
            Console.Clear();
            Console.WriteLine("Escolha a turma que deseja editar pelo número : ");

            foreach (var item in turmaList)
            {
                Console.WriteLine();
                Console.WriteLine($"Matrícula: {item.NumeroTurma} , Turma: {item.NomeTurma} ");
                Console.WriteLine();
            }



            try
            {
                int escolha = int.Parse(Console.ReadLine());

                var turma = turmaList.Where(x => x.NumeroTurma == escolha).FirstOrDefault();

                Console.WriteLine();


                if (escolha.ToString() == "")
                {
                    goto consulta;
                }

                if (turma == null)
                {
                erro1:
                    Console.Clear();
                    Console.WriteLine("ID da turma não encontrado para realizar alteração.");
                    Console.WriteLine();
                    Console.WriteLine("Tecle [1] para voltar a edição ou [0] para sair.");

                    try
                    {
                        int escolha1 = int.Parse(Console.ReadLine());

                        if (escolha1 == 1)
                        {
                            goto consulta;
                        }

                        else if (escolha1 == 0)
                        {
                            goto sair;
                        }
                        else
                        {
                            goto erro1;
                        }
                    }
                    catch (Exception)
                    {

                        goto erro1;
                    }

                }



            nome:
                Console.Clear();

                Console.WriteLine("Digite o novo nome da turma a ser definido : ");
                turma.NomeTurma = Console.ReadLine();

                if (turma.NomeTurma == null)
                {
                    goto nome;
                }
                
                else if (turma.NomeTurma == "")
                {
                    goto nome;
                }

                if (turma.NomeTurma == "")
                {
                    Console.WriteLine("Você não alterou nenhuma turma!");
                    Console.WriteLine();
                    Console.WriteLine("Tecle [1] para voltar a consulta para editar os dados , tecle [2] para voltar a editar o nome ou [s] para sair.");
                    string naoCadastrado = Console.ReadLine();

                    if (naoCadastrado == "1")
                    {
                        goto consulta;
                    }
                    else if (naoCadastrado == "2")
                    {
                        goto nome;
                    }
                    else if (naoCadastrado == "s")
                    {
                        goto sair;
                    }
                    else
                    {
                    invalido1:
                        Console.Clear();
                        Console.WriteLine("Opção inválida!");
                        Console.WriteLine();
                        Console.WriteLine("Tecle [1] para voltar ao cadastro ou [s] para sair.");
                        string nenhum = Console.ReadLine();

                        if (nenhum == "1")
                        {
                            goto nome;
                        }

                        else if (nenhum == "s")
                        {
                            goto sair;
                        }
                        else
                        {
                            goto invalido1;
                        }

                    }

                }

            descricao:
                Console.Clear();
                Console.WriteLine("Digite a nova descrição da turma: ");


                try
                {
                    turma.DescricaoTurma = (Console.ReadLine().Trim());

                    if (turma.DescricaoTurma.ToString() == "")
                    {
                        goto descricao;
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Você não editou nenhuma turma!");
                    Console.WriteLine();
                    Console.WriteLine("Tecle [1] para voltar ao edição ou [s] para sair.");
                    string naoCadastrado = Console.ReadLine();

                    if (naoCadastrado == "1")
                    {
                        Console.Clear();
                        goto descricao;
                    }

                    else if (naoCadastrado == "s")
                    {
                        goto sair;
                    }
                    else
                    {
                    invalido3:
                        Console.Clear();
                        Console.WriteLine("Opção inválida!");
                        Console.WriteLine();
                        Console.WriteLine("Tecle [1] para voltar a edição ou [s] para sair.");
                        string nenhum = Console.ReadLine();

                        if (nenhum == "1")
                        {
                            goto descricao;
                        }

                        else if (nenhum == "s")
                        {
                            goto sair;
                        }
                        else
                        {
                            goto invalido3;
                        }
                    }
                }
               
                            
            }
            catch (Exception)
            {

                goto consulta;
            }



        sair:;
        }
        static void EditarMateria(List<Materia> materiaList)
        {
        consulta:
            Console.Clear();
            Console.WriteLine("Escolha o matéria que deseja editar pelo número : ");

            foreach (var item in materiaList)
            {
                Console.WriteLine();
                Console.WriteLine($"Número : {item.IDMateria} , Nome: {item.NomeMateria} ");
                Console.WriteLine();
            }



            try
            {
                int escolha = int.Parse(Console.ReadLine());

                var materia = materiaList.Where(x => x.IDMateria == escolha).FirstOrDefault();

                Console.WriteLine();


                if (escolha.ToString() == "")
                {
                    goto consulta;
                }

                if (materia == null)
                {
                erro1:
                    Console.Clear();
                    Console.WriteLine("ID da matéria não encontrado para realizar alteração.");
                    Console.WriteLine();
                    Console.WriteLine("Tecle [1] para voltar a edição ou [0] para sair.");

                    try
                    {
                        int escolha1 = int.Parse(Console.ReadLine());

                        if (escolha1 == 1)
                        {
                            goto consulta;
                        }

                        else if (escolha1 == 0)
                        {
                            goto sair;
                        }
                        else
                        {
                            goto erro1;
                        }
                    }
                    catch (Exception)
                    {

                        goto erro1;
                    }

                }



            nome:
                Console.Clear();

                Console.WriteLine("Digite o novo nome a ser definido : ");
                materia.NomeMateria = Console.ReadLine();

                if (materia.NomeMateria == null)
                {
                    goto nome;
                }

                else if (materia.NomeMateria == "")
                {
                    goto nome;
                }

                if (materia.NomeMateria == "")
                {
                    Console.WriteLine("Você não cadastrou nenhum aluno!");
                    Console.WriteLine();
                    Console.WriteLine("Tecle [1] para voltar a consulta para editar os dados ou tecle [2] para voltar a editar o nome ou [s] para sair.");
                    string naoCadastrado = Console.ReadLine();

                    if (naoCadastrado == "1")
                    {
                        goto consulta;
                    }
                    else if (naoCadastrado == "2")
                    {
                        goto nome;
                    }
                    else if (naoCadastrado == "s")
                    {
                        goto sair;
                    }
                    else
                    {
                    invalido1:
                        Console.Clear();
                        Console.WriteLine("Opção inválida!");
                        Console.WriteLine();
                        Console.WriteLine("Tecle [1] para voltar ao cadastro ou [s] para sair.");
                        string nenhum = Console.ReadLine();

                        if (nenhum == "1")
                        {
                            goto nome;
                        }

                        else if (nenhum == "s")
                        {
                            goto sair;
                        }
                        else
                        {
                            goto invalido1;
                        }

                    }

                }
            }
            catch (Exception)
            {

                goto consulta;
            }



        sair:;
        }

    }
}

