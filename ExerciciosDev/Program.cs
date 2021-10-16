using System;

namespace ExerciciosDev
{
    class Program
    {
        static void Main(string[] args)

        {
            
            int opcao;
            double n1;
            double n2;
            double n3;
            double resulMediaFinal;
            double resultado;
            double resultadoExame;
            int gato = 0;
            int cachorro = 0;
            int peixe = 0;
            int repit = 0;
            int n = 0;

            Animal a1 = new Animal();

            bool validacao = true;
            Program program = new Program( );

           

            do
            {
                //mMenu
                Console.WriteLine();
                Console.WriteLine("Divirta-se com os Programas que desenvolvemos para você!");
                Console.WriteLine("----------------------------------------------------");

                Console.WriteLine("Escolha um dos programas abaixo: ");
                Console.WriteLine("(1) Calcule seu IMC ");
                Console.WriteLine("(2) Quantos Salarios minimos você ganha? ");
                Console.WriteLine("(3) Calculo de volume de Esfera");
                Console.WriteLine("(4) Notas escolares");
                Console.WriteLine("(5) Animais de estimação ");
                Console.WriteLine("(6) Sair ");
                Console.WriteLine("----------------------------------------------------");

                // Digitar a Opção
                Console.WriteLine("Digite a Opção desejada.");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("----------------------------------------------------");

                Console.Clear();
                switch (opcao)
                {
                    //calculo de IMC
                    case 1:
                        Console.WriteLine("Digite seu Peso atual (kg):  ");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite sua altura atual (m):  ");
                        n2 = Convert.ToDouble(Console.ReadLine());
                        // Direcionando o método
                        resultado = program.Imc(n1, n2);
       
                        Console.WriteLine(String.Format("{0:0.00}", resultado));
                        Console.WriteLine();
                        Console.WriteLine("----------------------------------------------------");

                        // determinando mensagens
                        if (resultado < 20)
                        {
                            Console.WriteLine("Abaixo do peso");
                            Console.WriteLine();
                            Console.WriteLine("----------------------------------------------------");

                        }
                        else if (resultado >= 20 && resultado < 25)
                        {
                            Console.WriteLine("Peso ideal");
                            Console.WriteLine();
                            Console.WriteLine("----------------------------------------------------");

                        }
                        else if (resultado >= 25)
                        {
                            Console.WriteLine("Acima do peso");
                            Console.WriteLine();
                            Console.WriteLine("----------------------------------------------------");

                        }
                        break;

                    //Calculo de Salario minimo
                    case 2:
                        Console.WriteLine("Digite Seu Salario Atual: ");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite agora, Quanto está o salario minimo atual: ");
                        n2 = Convert.ToDouble(Console.ReadLine());

                        resultado = program.SalMin(n1, n2);

                        Console.WriteLine($"Seu salario atual, possue {resultado} Salario(s) minimo(s)");
                        Console.WriteLine("-----------------------------------------------------------------");

                        Console.WriteLine();

                        Console.WriteLine("------------------------------------------------------------------");

                        break;
                    //Calculo de Raio
                    case 3:
                        Console.WriteLine("Digite um valor de Raio: ");
                        n1 = Convert.ToDouble(Console.ReadLine());

                        resultado = program.Raio(n1);
                        Console.WriteLine("----------------------------------------------------");
                        Console.WriteLine(String.Format("O volume da esfera é {0:0.00}", resultado));
                        Console.WriteLine("----------------------------------------------------");

                        break;
                    //Calculode de medias e exames
                    case 4:
                        Console.WriteLine("Digite a primeira nota:");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite a seginda nota:");
                        n2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite a terceira nota:");
                        n3 = Convert.ToDouble(Console.ReadLine());

                        resultado = program.Media(n1, n2, n3);
                        if (resultado >= 7)

                        {
                            //Aluno tirou mais ou igual a 7
                            Console.WriteLine("----------------------------------------------------");
                            Console.WriteLine(String.Format("Você tirou {0:0.00} e está Aprovado", resultado));
                            Console.WriteLine("----------------------------------------------------");

                        }
                        else
                        {
                            //Caso o aluno seja Reprovado
                            Console.WriteLine("----------------------------------------------------");
                            Console.WriteLine(String.Format("Você tirou {0:0.00}", resultado));
                            Console.WriteLine("Por tanto está de Exame");
                            Console.WriteLine();
                            //Aluno digita a nota do Exame
                            Console.WriteLine("Digite a Nota de Exame: ");
                         
                            //Nota do exame
                            resultadoExame = Convert.ToDouble(Console.ReadLine());
                            //Media entre os 2 exames
                            resulMediaFinal = program.MediaExame(resultado, resultadoExame);
                            if (resulMediaFinal >= 5)
                            {
                                //Aprovado caso o aluno tire mais ou igual a 5
                                Console.WriteLine("----------------------------------------------------");
                                Console.WriteLine(String.Format("Você tirou {0:0.00} e está Aprovado", resulMediaFinal));                      
                                Console.WriteLine("----------------------------------------------------");
                                Console.WriteLine();
                            }
                            else
                            {
                                //Reprovado caso o aluno tire menos que 5
                                Console.WriteLine("----------------------------------------------------");
                                Console.WriteLine(String.Format("Você tirou {0:0.00} e está Reprovado", resulMediaFinal));
                                Console.WriteLine("----------------------------------------------------");
                                Console.WriteLine();


                            }
                        }

                        break;
                    case 5:
                        //Estrutura que se repetira 5 vezes
                        while (repit < 5)
                        {
                            // numero no titulo
                            n++;
                            Console.WriteLine($"{n}° Animal de estimação");
                            Console.WriteLine();
                            Console.WriteLine("Digite o nome do Animal de estimação: ");
                            a1.setNome(Console.ReadLine());

                            Console.WriteLine("Digite o tipo de Animal de estimação: ");
                            a1.setTipo(Console.ReadLine());




                            //Estrutura que armazena as quantidades de cachorros gatos e peixes citados
                            if (a1.getTipo().ToLower() == "cachorro")
                            {
                                cachorro++;

                            }
                            else if (a1.getTipo().ToLower() == "gato")
                            {
                                gato++;
                            }
                            else
                            {
                                peixe++;
                            }

                            repit++;
                            Console.Clear();



                        }
                        //Apresentação da contagem
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine($" Contagem de Cachorro(0) = {cachorro}");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine($" Contagem de Gato(s)     = {gato}");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine($" Contagem de Peixe(s)     = {peixe}");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();


                        break;

                    case 6:
                        validacao = false;
                    break;
                }

            } while (validacao);

        }
        //método de IMc
        public double Imc(double n1, double n2)
        {
            n2 /= 100;
            return n1 / (n2 * n2);
        }
        //metodo de Salario minimo
        public double SalMin(double n1, double n2)
        {
            return n1 / n2;
        }
        //método de volume de esfera 
        public double Raio(double n1)
        {

            return ((4 * (n1 * n1 * n1))  * 3.14) / 3;
        }
        //Método calculo de media
         public double Media(double n1, double n2, double n3)
        {
            return (n1 + n2 + n3) / 3;
        }
        //Método calculo de media tambem
        public double MediaExame(double resultado, double resultadoExame)
        {
            return (resultado + resultadoExame) / 2;
        }
    }
}
