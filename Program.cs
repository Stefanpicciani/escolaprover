using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace EscolaProver
{
    partial class Program
    {
        static void Main(string[] args)
        {
           
                                   

            List<Aluno> cadastroList = new List<Aluno>();
            List<Materia> materiaList = new List<Materia>();
            List<Turma> turmaList = new List<Turma>();

            

            Console.WriteLine("Escola Prover");
            Console.WriteLine();

            Aluno aluno = new Aluno();
            Materia materia = new Materia();
            Turma turma = new Turma();

        voltar:
        menu:
            Console.Clear();
            Console.WriteLine("Escola Prover");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("ALUNO");                 Console.Write("                                                           Digite [0] Caso queira sair");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Digite:");
            Console.WriteLine();
            Console.WriteLine("[01] para matricular um novo aluno                         [05](ncodado) para cadastrar aluno na turma  ");
            Console.WriteLine("[02] para consultar dados de aluno                         [06](ncodado) para remover aluno da turma    ");
            Console.WriteLine("[03] para Editar o cadastro do aluno                       [07](ncodado) para Buscar aluno na turma     ");
            Console.WriteLine("[04] para deletar cadastro do aluno");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("TURMA");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Digite:");
            Console.WriteLine();
            Console.WriteLine("[11] para cadastrar uma nova turma                         [15](ncodado) Buscar turma e exibir alunos que estão nela");
            Console.WriteLine("[12] para consultar turmas");
            Console.WriteLine("[13] para editar turmas");
            Console.WriteLine("[14] para deletar turmas");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("MATÉRIA");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Digite:");
            Console.WriteLine();
            Console.WriteLine("[21] para cadastrar matéria                                [25](ncodado) para cadastrar matéria na turma ");
            Console.WriteLine("[22] para consultar as matérias                            [26](ncodado) para remover matéria da turma          ");
            Console.WriteLine("[23] para editar matéria");
            Console.WriteLine("[24] para deletar matéria");




            //Console.WriteLine("Digite [1] para matricular aluno , Digite [2] para cadastrar a matéria , Digite [3] para cadastrar turma");
            //Console.WriteLine();
            //Console.WriteLine("Digite [4] para consultar dados de alunos matriculados, Digite [12] para consultar matéria cadastrada");
            //Console.WriteLine();
            //Console.WriteLine("Digite [22] para consultar turmas cadastradas , Digite [0] para sair.");


            try
            {
                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 01)
                {

                    registrar:
                    Console.Clear();
                    Console.Write("Quantos alunos você deseja registrar? ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(" Obs:.Digite o valor em números!");
                    Console.ResetColor();

                    try
                    {
                        int escolha = int.Parse(Console.ReadLine());

                        for (int i = 1; i <= escolha; i++)
                        {
                            //matricula:

                            Random ran = new Random();
                            int matricula = ran.Next(10000, 30000);

                        nome1:
                            Console.Clear();

                        nome:
                            Console.Clear();
                            Console.WriteLine("Digite o nome do " + i + "° aluno que deseja cadastrar: ");
                            string nomeAluno = Console.ReadLine();

                            if (nomeAluno.Contains("0") || nomeAluno.Contains("1") || nomeAluno.Contains("2") || nomeAluno.Contains("3") || nomeAluno.Contains("4") || nomeAluno.Contains("5") || nomeAluno.Contains("6") || nomeAluno.Contains("7") || nomeAluno.Contains("8") || nomeAluno.Contains("9"))
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Não é aceito números apenas letras");
                                Console.ResetColor();
                                Console.WriteLine();

                                goto nome;
                            }
                            else if (nomeAluno == "")
                            {
                                goto nome1;
                            }

                            if (nomeAluno == "")
                            {
                                Console.WriteLine("Você não cadastrou nenhum aluno!");
                                Console.WriteLine();
                                Console.WriteLine("Tecle [1] para voltar ao cadastro, tecle [2] para voltar ao menu principal ou [s] para sair.");
                                string naoCadastrado = Console.ReadLine();

                                if (naoCadastrado == "1")
                                {
                                    goto nome;
                                }
                                else if (naoCadastrado == "2")
                                {
                                    goto menu;
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
                                    Console.WriteLine("Tecle [1] para voltar ao cadastro, tecle [2] para voltar ao menu principal ou [s] para sair.");
                                    string nenhum = Console.ReadLine();

                                    if (nenhum == "1")
                                    {
                                        goto nome;
                                    }
                                    else if (nenhum == "2")
                                    {
                                        goto menu;
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


                            Console.Clear();
                        cpf:
                            Console.WriteLine("Digite o número do CPF de " + nomeAluno + " :");
                            string cpfAluno = Console.ReadLine();
                            ValidaCPF valcpf = new ValidaCPF();


                            if (!valcpf.IsCpf(cpfAluno))
                            {
                                Console.Clear();
                                Console.WriteLine("Esse CPF é inválido");
                                goto cpf;
                            }
                            if (cpfAluno == "")
                            {
                                Console.WriteLine("Você não cadastrou nenhum CPF!");
                                Console.WriteLine();
                                Console.WriteLine("Tecle [1] para voltar ao cadastro, tecle [2] para voltar ao menu principal ou [s] para sair.");
                                string naoCadastrado = Console.ReadLine();

                                if (naoCadastrado == "1")
                                {
                                    goto cpf;
                                }
                                else if (naoCadastrado == "2")
                                {
                                    goto menu;
                                }
                                else if (naoCadastrado == "s")
                                {
                                    goto sair;
                                }
                                else
                                {
                                invalido2:
                                    Console.Clear();
                                    Console.WriteLine("Opção inválida!");
                                    Console.WriteLine();
                                    Console.WriteLine("Tecle [1] para voltar ao cadastro, tecle [2] para voltar ao menu principal ou [s] para sair.");
                                    string nenhum = Console.ReadLine();

                                    if (nenhum == "1")
                                    {
                                        goto cpf;
                                    }
                                    else if (nenhum == "2")
                                    {
                                        goto menu;
                                    }
                                    else if (nenhum == "s")
                                    {
                                        goto sair;
                                    }
                                    else
                                    {
                                        goto invalido2;
                                    }

                                }

                            }


                            Console.Clear();
                        telefone:
                            Console.WriteLine("Digite o número do telefone: [ddd] + número (Obs: tudo junto).");
                            double telefoneAluno = 0;
                            try
                            {
                                telefoneAluno = double.Parse(Console.ReadLine().Trim());
                            }
                            catch (Exception)
                            {

                                Console.WriteLine("Você não cadastrou nenhum telefone!");
                                Console.WriteLine();
                                Console.WriteLine("Tecle [1] para voltar ao cadastro, tecle [2] para voltar ao menu principal ou [s] para sair.");
                                string naoCadastrado = Console.ReadLine();

                                if (naoCadastrado == "1")
                                {
                                    Console.Clear();
                                    goto telefone;
                                }
                                else if (naoCadastrado == "2")
                                {
                                    goto menu;
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
                                    Console.WriteLine("Tecle [1] para voltar ao cadastro, tecle [2] para voltar ao menu principal ou [s] para sair.");
                                    string nenhum = Console.ReadLine();

                                    if (nenhum == "1")
                                    {
                                        goto telefone;
                                    }
                                    else if (nenhum == "2")
                                    {
                                        goto menu;
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
                            if (telefoneAluno.ToString().Length != 11)
                            {
                                Console.Clear();
                                Console.WriteLine("Telefone tem que ter 11 digitos");
                                goto telefone;
                            }





                            //if (telefoneAluno == "")
                            //{
                            //    Console.WriteLine("Você não cadastrou nenhum telefone!");
                            //    Console.WriteLine();
                            //    Console.WriteLine("Tecle [1] para voltar ao cadastro, tecle [2] para voltar ao menu principal ou [s] para sair.");
                            //    string naoCadastrado = Console.ReadLine();

                            //    if (naoCadastrado == "1")
                            //    {
                            //        goto telefone;
                            //    }
                            //    else if (naoCadastrado == "2")
                            //    {
                            //        goto menu;
                            //    }
                            //    else if (naoCadastrado == "s")
                            //    {
                            //        goto sair;
                            //    }
                            //    else
                            //    {
                            //    invalido3:
                            //        Console.Clear();
                            //        Console.WriteLine("Opção inválida!");
                            //        Console.WriteLine();
                            //        Console.WriteLine("Tecle [1] para voltar ao cadastro, tecle [2] para voltar ao menu principal ou [s] para sair.");
                            //        string nenhum = Console.ReadLine();

                            //        if (nenhum == "1")
                            //        {
                            //            goto telefone;
                            //        }
                            //        else if (nenhum == "2")
                            //        {
                            //            goto menu;
                            //        }
                            //        else if (nenhum == "s")
                            //        {
                            //            goto sair;
                            //        }
                            //        else
                            //        {
                            //            goto invalido3;
                            //        }

                            //    }

                            //}
                            Console.Clear();
                        nascimento:

                            Console.Write("Digite a data de nascimento: ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("    Obrigatório colocar no formato  DD/mm/AAAA {com as barras --> / }");
                            Console.ResetColor();
                            string dataNascimento = Console.ReadLine();
                            try
                            {
                                DateTime data = DateTime.Parse(dataNascimento);
                            }
                            catch (Exception)
                            {
                                Console.Clear();
                                Console.WriteLine("Data no formato inválido");
                                goto nascimento;
                            }
                            if (dataNascimento == "")
                            {
                                Console.WriteLine("Você não cadastrou nenhuma data de nascimento!");
                                Console.WriteLine();
                                Console.WriteLine("Tecle [1] para voltar ao cadastro, tecle [2] para voltar ao menu principal ou [s] para sair.");
                                string naoCadastrado = Console.ReadLine();

                                if (naoCadastrado == "1")
                                {
                                    goto nascimento;
                                }
                                else if (naoCadastrado == "2")
                                {
                                    goto menu;
                                }
                                else if (naoCadastrado == "s")
                                {
                                    goto sair;
                                }
                                else
                                {
                                invalido4:
                                    Console.Clear();
                                    Console.WriteLine("Opção inválida!");
                                    Console.WriteLine();
                                    Console.WriteLine("Tecle [1] para voltar ao cadastro, tecle [2] para voltar ao menu principal ou [s] para sair.");
                                    string nenhum = Console.ReadLine();

                                    if (nenhum == "1")
                                    {
                                        goto nascimento;
                                    }
                                    else if (nenhum == "2")
                                    {
                                        goto menu;
                                    }
                                    else if (nenhum == "s")
                                    {
                                        goto sair;
                                    }
                                    else
                                    {
                                        goto invalido4;
                                    }

                                }
                          
                            }

                          

                            Aluno aluno1 = new Aluno(matricula, nomeAluno, cpfAluno, telefoneAluno, dataNascimento);

                            cadastroList.Add(aluno1);

                        }
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Aluno cadastrado com sucesso!");
                        Console.ResetColor();
                        Console.WriteLine("Tecle [enter] para voltar as opções ou [s] para sair.");
                        string sair1 = Console.ReadLine();

                        if (sair1 == "")
                        {
                            goto voltar;
                        }
                        else if (sair1 == "s")
                        {
                            goto sair;

                        }



                        if (sair1 != "s")
                        {
                        erro1:
                            Console.Clear();
                            Console.WriteLine("Opção inválida!");
                            Console.WriteLine("Tecle [enter] para voltar as opções ou [s] para sair.");
                            string sair2 = Console.ReadLine();

                            if (sair2 == "")
                            {
                                goto voltar;
                            }
                            else if (sair2 == "s")
                            {
                                Console.ReadLine();

                            }
                            else
                            {
                                goto erro1;
                            }

                        }


                        
                    }
                    catch (Exception)
                    {

                        goto registrar;
                    }









                }

                else if (opcao == 21)
                {
                    //ID matéria

                    Random ran = new Random();
                    int idMateria = ran.Next(4001,9999);

                materia:
                    Console.Clear();
                    Console.WriteLine("Digite o nome da matéria: ");
                    string nomeMateria = Console.ReadLine();

                    if (nomeMateria == "")
                    {
                        Console.WriteLine("Você não cadastrou nenhuma matéria!");
                        Console.WriteLine();
                        Console.WriteLine("Tecle [1] para voltar ao cadastro, tecle [2] para voltar ao menu principal ou [s] para sair.");
                        string naoCadastrado = Console.ReadLine();

                        if (naoCadastrado == "1")
                        {
                            goto materia;
                        }
                        else if (naoCadastrado == "2")
                        {
                            goto menu;
                        }
                        else if (naoCadastrado == "s")
                        {
                            goto sair;
                        }
                        else
                        {
                        invalido5:
                            Console.Clear();
                            Console.WriteLine("Opção inválida!");
                            Console.WriteLine();
                            Console.WriteLine("Tecle [1] para voltar ao cadastro, tecle [2] para voltar ao menu principal ou [s] para sair.");
                            string nenhum = Console.ReadLine();

                            if (nenhum == "1")
                            {
                                goto materia;
                            }
                            else if (nenhum == "2")
                            {
                                goto menu;
                            }
                            else if (nenhum == "s")
                            {
                                goto sair;
                            }
                            else
                            {
                                goto invalido5;
                            }

                        }

                    }

                    Materia materia1 = new Materia(idMateria, nomeMateria);

                    materiaList.Add(materia1);

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green; 
                    Console.WriteLine("Matéria cadastrada com sucesso!");
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.WriteLine("Tecle [enter] para voltar as opções, tecle [0] para cadastrar uma nova matéria ou [s] para sair.");
                    string sair3 = Console.ReadLine();

                    if (sair3 == "0")
                    {
                        goto materia;
                    }
                    if (sair3 == "")
                    {
                        goto voltar;
                    }
                    else if (sair3 == "s")
                    {
                        goto sair;

                    }



                    if (sair3 != "s")
                    {
                    erro2:
                        Console.Clear();
                        Console.WriteLine("Opção inválida!");
                        Console.WriteLine("Tecle [enter] para voltar as opções ou [s] para sair.");
                        string sair4 = Console.ReadLine();

                        if (sair4 == "")
                        {
                            goto voltar;
                        }
                        else if (sair4 == "s")
                        {
                            Console.ReadLine();

                        }
                        else
                        {
                            goto erro2;
                        }

                    }

                    
                }




                else if (opcao == 11)
                {
                    //turma:

                    Random ran = new Random();
                    int numeroTurma = ran.Next(1000 , 4000);


                turma:
                    Console.Clear();
                    Console.WriteLine("Digite o nome da turma a ser cadastrada: ");
                    string nomeTurma = Console.ReadLine();

                    if (nomeTurma == "")
                    {
                        Console.WriteLine("Você não cadastrou nenhuma turma!");
                        Console.WriteLine();
                        Console.WriteLine("Tecle [1] para voltar ao cadastro, tecle [2] para voltar ao menu principal ou [s] para sair.");
                        string naoCadastrado = Console.ReadLine();

                        if (naoCadastrado == "1")
                        {
                            goto turma;
                        }
                        else if (naoCadastrado == "2")
                        {
                            goto menu;
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
                            Console.WriteLine("Tecle [1] para voltar ao cadastro, tecle [2] para voltar ao menu principal ou [s] para sair.");
                            string nenhum = Console.ReadLine();

                            if (nenhum == "1")
                            {
                                goto turma;
                            }
                            else if (nenhum == "2")
                            {
                                goto menu;
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

                descricao:
                    Console.Clear();
                    Console.WriteLine("Digite a descrição da turma: ");
                    string descricaoTurma = Console.ReadLine();


                    if (descricaoTurma == "")
                    {
                        Console.WriteLine("Você não cadastrou nenhuma descrição!");
                        Console.WriteLine();
                        Console.WriteLine("Tecle [1] para voltar ao cadastro, tecle [2] para voltar ao menu principal ou [s] para sair.");
                        string naoCadastrado = Console.ReadLine();

                        if (naoCadastrado == "1")
                        {
                            goto descricao;
                        }
                        else if (naoCadastrado == "2")
                        {
                            goto menu;
                        }
                        else if (naoCadastrado == "s")
                        {
                            goto sair;
                        }
                        else
                        {
                        invalido7:
                            Console.Clear();
                            Console.WriteLine("Opção inválida!");
                            Console.WriteLine();
                            Console.WriteLine("Tecle [1] para voltar ao cadastro, tecle [2] para voltar ao menu principal ou [s] para sair.");
                            string nenhum = Console.ReadLine();

                            if (nenhum == "1")
                            {
                                goto descricao;
                            }
                            else if (nenhum == "2")
                            {
                                goto menu;
                            }
                            else if (nenhum == "s")
                            {
                                goto sair;
                            }
                            else
                            {
                                goto invalido7;
                            }

                        }

                    }

                    Turma turma1 = new Turma(numeroTurma, nomeTurma, descricaoTurma);

                    turmaList.Add(turma1);


                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Turma cadastrada com sucesso!");
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.WriteLine("Tecle [enter] para voltar as opções, tecle[0] para cadastrar uma nova turma ou [s] para sair.");
                    string sair5 = Console.ReadLine();

                    if (sair5 == "0")
                    {
                        goto turma;
                    }
                    if (sair5 == "")
                    {
                        goto voltar;
                    }
                    else if (sair5 == "s")
                    {
                        goto sair;

                    }



                    if (sair5 != "s")
                    {
                    erro3:
                        Console.Clear();
                        Console.WriteLine("Opção inválida!");
                        Console.WriteLine("Tecle [enter] para voltar as opções ou [s] para sair.");
                        string sair6 = Console.ReadLine();

                        if (sair6 == "")
                        {
                            goto voltar;
                        }
                        else if (sair6 == "s")
                        {
                            goto sair;

                        }
                        else
                        {
                            goto erro3;
                        }
                    }
                   

                }

                else if (opcao == 02)
                {
                   

                consulta:
                    Console.Clear();
                    Console.WriteLine("Digite o número de matrícula do aluno que deseja consultar: ");

                    foreach (var item in cadastroList)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Matrícula : {item.Matricula} , Nome : {item.NomeAluno}");
                        Console.WriteLine();
                    }


                    int numeroMatricula = int.Parse(Console.ReadLine());

                    var resConsulta = cadastroList.Where(x => x.Matricula == numeroMatricula).FirstOrDefault();


                    Console.WriteLine();

                    if (numeroMatricula.ToString() == "")
                    {
                        goto consulta;
                    }

                    if (resConsulta == null)
                    {
                    erro1:
                        Console.Clear();
                        Console.WriteLine("Número de matrícula não cadastrado para realizar consulta.");
                        Console.WriteLine();
                        Console.WriteLine("Tecle [1] para voltar a consulta, tecle [2] para menu inicial ou [0] para sair.");

                        try
                        {
                            int escolha = int.Parse(Console.ReadLine());

                            if (escolha == 1)
                            {
                                goto consulta;
                            }
                            else if (escolha == 2)
                            {
                                goto menu;
                            }
                            else if (escolha == 0)
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
                   
                    if (numeroMatricula.ToString() == "")
                    {
                    opcaoInvalida:
                        Console.WriteLine("Opção inválida!");
                        Console.WriteLine();
                        Console.WriteLine("Digite [1] para voltar a consulta, digite [2] para voltar ao menu principal , [0] para sair !");
                        int escolha = int.Parse(Console.ReadLine());

                        if (escolha == 1)
                        {
                            goto consulta;
                        }
                        if (escolha == 2)
                        {
                            goto menu;
                        }
                        if (escolha == 0)
                        {
                            goto sair;
                        }
                        else
                        {
                            goto opcaoInvalida;
                        }

                    }


                    if (numeroMatricula.ToString() == "")
                    {
                        Console.WriteLine("Você não consultou dados de nenhum aluno!");
                        Console.WriteLine();
                        Console.WriteLine("Tecle [1] para voltar a consulta, tecle [2] para voltar ao menu principal ou [s] para sair.");
                        string naoConsultar = Console.ReadLine();

                        if (naoConsultar == "1")
                        {
                            goto consulta;
                        }
                        else if (naoConsultar == "2")
                        {
                            goto menu;
                        }
                        else if (naoConsultar == "s")
                        {
                            goto sair;
                        }
                        else
                        {
                        invalido7:
                            Console.Clear();
                            Console.WriteLine("Opção inválida!");
                            Console.WriteLine();
                            Console.WriteLine("Tecle [1] para voltar a consulta, tecle [2] para voltar ao menu principal ou [s] para sair.");
                            string nenhum = Console.ReadLine();

                            if (nenhum == "1")
                            {
                                goto consulta;
                            }
                            else if (nenhum == "2")
                            {
                                goto menu;
                            }
                            else if (nenhum == "s")
                            {
                                goto sair;
                            }
                            else
                            {
                                goto invalido7;
                            }

                        }

                    }

                    Console.WriteLine($"Matrícula : {resConsulta.Matricula} , Nome : {resConsulta.NomeAluno} , CPF : {resConsulta.CpfAluno} , Telefone {resConsulta.TelefoneAluno} ");
                    Console.WriteLine($"Data de Nascimento : {resConsulta.DataNascimento} ");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Dados consultados com sucesso!");
                    Console.ResetColor();

                    //Console.Clear();
                    //Console.WriteLine("Dados consultados com sucesso!");
                    //Console.WriteLine();
                    Console.WriteLine("Tecle [enter] para voltar as opções ou [s] para sair ou [0] para realizar uma nova consulta.");
                    string sair5 = Console.ReadLine();


                    if (sair5 == "")
                    {
                        goto voltar;
                    }
                    else if (sair5 == "0")
                    {
                        goto consulta;
                    }
                    else if (sair5.ToLower() == "s")
                    {
                        goto sair;

                    }


                    if (sair5 != "s")
                    {
                    erro3:
                        Console.Clear();
                        Console.WriteLine("Opção inválida!");
                        Console.WriteLine("Tecle [enter] para voltar as opções ou [s] para sair.");
                        string sair6 = Console.ReadLine();

                        if (sair6 == "")
                        {
                            goto voltar;
                        }
                        else if (sair6 == "s")
                        {
                            goto sair;

                        }
                        else
                        {
                            goto erro3;
                        }
                    }
                    

                }
                else if (opcao == 04)
                {
                    Console.Clear();
                    DeletarAluno(cadastroList);

                    goto menu;
                }

                else if (opcao == 03)
                {
                    Console.Clear();
                    EditarAluno(cadastroList);

                    goto menu;
                }

                else if (opcao == 22)
                {


                consulta:
                    Console.Clear();
                    Console.WriteLine("Digite o ID da matéria que deseja consultar: ");

                    foreach (var item in materiaList)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"ID da matéria : {item.IDMateria} , Matéria : {item.NomeMateria}");
                        Console.WriteLine();
                    }


                    int numeroMateria = int.Parse(Console.ReadLine());

                    var resConsulta = materiaList.Where(x => x.IDMateria == numeroMateria).FirstOrDefault();


                    Console.WriteLine();

                    if (numeroMateria.ToString() == "")
                    {
                        goto consulta;
                    }

                    if (resConsulta == null)
                    {
                    erro1:
                        Console.Clear();
                        Console.WriteLine("ID da matéria não encontrado para realizar consulta.");
                        Console.WriteLine();
                        Console.WriteLine("Tecle [1] para voltar a consulta, tecle [2] para menu inicial ou [0] para sair.");

                        try
                        {
                            int escolha = int.Parse(Console.ReadLine());

                            if (escolha == 1)
                            {
                                goto consulta;
                            }
                            else if (escolha == 2)
                            {
                                goto menu;
                            }
                            else if (escolha == 0)
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

                    if (numeroMateria.ToString() == "")
                    {
                    opcaoInvalida:
                        Console.WriteLine("Opção inválida!");
                        Console.WriteLine();
                        Console.WriteLine("Digite [1] para voltar a consulta, digite [2] para voltar ao menu principal , [0] para sair !");
                        int escolha = int.Parse(Console.ReadLine());

                        if (escolha == 1)
                        {
                            goto consulta;
                        }
                        if (escolha == 2)
                        {
                            goto menu;
                        }
                        if (escolha == 0)
                        {
                            goto sair;
                        }
                        else
                        {
                            goto opcaoInvalida;
                        }

                    }


                    if (numeroMateria.ToString() == "")
                    {
                        Console.WriteLine("Você não consultou dados de nenhuma matéria!");
                        Console.WriteLine();
                        Console.WriteLine("Tecle [1] para voltar a consulta, tecle [2] para voltar ao menu principal ou [s] para sair.");
                        string naoConsultar = Console.ReadLine();

                        if (naoConsultar == "1")
                        {
                            goto consulta;
                        }
                        else if (naoConsultar == "2")
                        {
                            goto menu;
                        }
                        else if (naoConsultar == "s")
                        {
                            goto sair;
                        }
                        else
                        {
                        invalido7:
                            Console.Clear();
                            Console.WriteLine("Opção inválida!");
                            Console.WriteLine();
                            Console.WriteLine("Tecle [1] para voltar a consulta, tecle [2] para voltar ao menu principal ou [s] para sair.");
                            string nenhum = Console.ReadLine();

                            if (nenhum == "1")
                            {
                                goto consulta;
                            }
                            else if (nenhum == "2")
                            {
                                goto menu;
                            }
                            else if (nenhum == "s")
                            {
                                goto sair;
                            }
                            else
                            {
                                goto invalido7;
                            }

                        }

                    }

                    Console.WriteLine($"ID da Matéria : {resConsulta.IDMateria} , Matéria : {resConsulta.NomeMateria} ");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Dados consultados com sucesso!");
                    Console.ResetColor();

                    //Console.Clear();
                    //Console.WriteLine("Dados consultados com sucesso!");
                    //Console.WriteLine();
                    Console.WriteLine("Tecle [enter] para voltar as opções ou [s] para sair ou [0] para realizar uma nova consulta.");
                    string sair5 = Console.ReadLine();


                    if (sair5 == "")
                    {
                        goto voltar;
                    }
                    else if (sair5 == "0")
                    {
                        goto consulta;
                    }
                    else if (sair5.ToLower() == "s")
                    {
                        goto sair;

                    }


                    if (sair5 != "s")
                    {
                    erro3:
                        Console.Clear();
                        Console.WriteLine("Opção inválida!");
                        Console.WriteLine("Tecle [enter] para voltar as opções ou [s] para sair.");
                        string sair6 = Console.ReadLine();

                        if (sair6 == "")
                        {
                            goto voltar;
                        }
                        else if (sair6 == "s")
                        {
                            goto sair;

                        }
                        else
                        {
                            goto erro3;
                        }
                    }


                }
                else if (opcao == 23)
                {
                    Console.Clear();
                    EditarMateria(materiaList);

                    goto menu;
                }
                else if (opcao == 24)
                {
                    Console.Clear();
                    DeletarMateria(materiaList);

                    goto menu;
                }


                else if (opcao == 12)
                {


                consulta:
                    Console.Clear();
                    Console.WriteLine("Digite o número da turma que deseja consultar: ");

                    foreach (var item in turmaList)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Número da turma: {item.NumeroTurma} , Turma : {item.NomeTurma}");
                        Console.WriteLine();
                    }


                    int numeroTurma = int.Parse(Console.ReadLine());

                    var resConsulta = turmaList.Where(x => x.NumeroTurma == numeroTurma).FirstOrDefault();


                    Console.WriteLine();

                    if (numeroTurma.ToString() == "")
                    {
                        goto consulta;
                    }

                    if (resConsulta == null)
                    {
                    erro1:
                        Console.Clear();
                        Console.WriteLine("ID da matéria não encontrado para realizar consulta.");
                        Console.WriteLine();
                        Console.WriteLine("Tecle [1] para voltar a consulta, tecle [2] para menu inicial ou [0] para sair.");

                        try
                        {
                            int escolha = int.Parse(Console.ReadLine());

                            if (escolha == 1)
                            {
                                goto consulta;
                            }
                            else if (escolha == 2)
                            {
                                goto menu;
                            }
                            else if (escolha == 0)
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

                    if (numeroTurma.ToString() == "")
                    {
                    opcaoInvalida:
                        Console.WriteLine("Opção inválida!");
                        Console.WriteLine();
                        Console.WriteLine("Digite [1] para voltar a consulta, digite [2] para voltar ao menu principal , [0] para sair !");
                        int escolha = int.Parse(Console.ReadLine());

                        if (escolha == 1)
                        {
                            goto consulta;
                        }
                        if (escolha == 2)
                        {
                            goto menu;
                        }
                        if (escolha == 0)
                        {
                            goto sair;
                        }
                        else
                        {
                            goto opcaoInvalida;
                        }

                    }


                    if (numeroTurma.ToString() == "")
                    {
                        Console.WriteLine("Você não consultou dados de nenhuma matéria!");
                        Console.WriteLine();
                        Console.WriteLine("Tecle [1] para voltar a consulta, tecle [2] para voltar ao menu principal ou [s] para sair.");
                        string naoConsultar = Console.ReadLine();

                        if (naoConsultar == "1")
                        {
                            goto consulta;
                        }
                        else if (naoConsultar == "2")
                        {
                            goto menu;
                        }
                        else if (naoConsultar == "s")
                        {
                            goto sair;
                        }
                        else
                        {
                        invalido7:
                            Console.Clear();
                            Console.WriteLine("Opção inválida!");
                            Console.WriteLine();
                            Console.WriteLine("Tecle [1] para voltar a consulta, tecle [2] para voltar ao menu principal ou [s] para sair.");
                            string nenhum = Console.ReadLine();

                            if (nenhum == "1")
                            {
                                goto consulta;
                            }
                            else if (nenhum == "2")
                            {
                                goto menu;
                            }
                            else if (nenhum == "s")
                            {
                                goto sair;
                            }
                            else
                            {
                                goto invalido7;
                            }

                        }

                    }

                    Console.WriteLine($"Número da turma : {resConsulta.NumeroTurma} , Turma : {resConsulta.NomeTurma} , Descrição da turma: {resConsulta.DescricaoTurma} ");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Dados consultados com sucesso!");
                    Console.ResetColor();

                    //Console.Clear();
                    //Console.WriteLine("Dados consultados com sucesso!");
                    //Console.WriteLine();
                    Console.WriteLine("Tecle [enter] para voltar as opções ou [s] para sair ou [0] para realizar uma nova consulta.");
                    string sair5 = Console.ReadLine();


                    if (sair5 == "")
                    {
                        goto voltar;
                    }
                    else if (sair5 == "0")
                    {
                        goto consulta;
                    }
                    else if (sair5.ToLower() == "s")
                    {
                        goto sair;

                    }


                    if (sair5 != "s")
                    {
                    erro3:
                        Console.Clear();
                        Console.WriteLine("Opção inválida!");
                        Console.WriteLine("Tecle [enter] para voltar as opções ou [s] para sair.");
                        string sair6 = Console.ReadLine();

                        if (sair6 == "")
                        {
                            goto voltar;
                        }
                        else if (sair6 == "s")
                        {
                            goto sair;

                        }
                        else
                        {
                            goto erro3;
                        }
                    }


                }


                else if (opcao == 13)
                {
                    Console.Clear();
                    EditarTurma(turmaList);

                    goto menu;
                }
                else if (opcao == 14)
                {
                    Console.Clear();
                    DeletarTurma(turmaList);

                    goto menu;
                }


                if (opcao == 0)
                {
                    goto sair;
                }
                else
                {
                erro4:
                    Console.Clear();
                    Console.WriteLine("Opção inválida!");
                    Console.WriteLine();
                    Console.WriteLine("Tecle [enter] para voltar as opções ou [s] para sair.");
                    string sair7 = Console.ReadLine();

                    if (sair7 == "")
                    {
                        goto voltar;
                    }
                    else if (sair7 == "s")
                    {
                        goto sair;
                    }
                    else
                    {
                        goto erro4;
                    }
                }


            }
            catch (Exception)
            {
            erro:
                Console.Clear();
                Console.WriteLine("Opção inválida!");
                Console.WriteLine();
                Console.WriteLine("Tecle [enter] para voltar as opções ou [s] para sair.");
                string sair8 = Console.ReadLine();

                if (sair8 == "")
                {
                    goto voltar;
                }
                else if (sair8 == "s")
                {
                    goto sair;
                }
                else
                {
                    goto erro;
                }

            }























        //lista:
        //    foreach (var item in cadastroList)
        //    {
        //        Console.WriteLine();
        //        Console.WriteLine($"Nome: {item.NomeAluno} , CPF: {item.CpfAluno} , Telefone: {item.TelefoneAluno} , Data de Nascimento {item.DataNascimento}");
        //        Console.WriteLine();
        //    }
        //    foreach (var item in materiaList)
        //    {
        //        Console.WriteLine();
        //        Console.WriteLine($"Matéria: {item.NomeMateria}");
        //        Console.WriteLine();
        //    }
        //    foreach (var item in turmaList)
        //    {
        //        Console.WriteLine();
        //        Console.WriteLine($"Turma: {item.NomeTurma} , Descrição da turma: {item.DescricaoTurma}");
        //        Console.WriteLine();
        //    }



        //    Console.WriteLine("Tecle [s] para sair ou [enter] para registrar mais funcionários.");
        //    string sair9 = Console.ReadLine();

        //    if (sair9 == "")
        //    {
        //        goto voltar;
        //    }






        sair:;

        }
    }
}
