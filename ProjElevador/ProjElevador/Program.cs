using System;
using ProjElevador.Model;

namespace ProjElevador
{
    internal class Program
    {
        // Instanciando objeto Elevador.
        static void Main(string[] args)
        {
            var elevadorPrincipal = new Elevador();

            int terreo = elevadorPrincipal.Terreo = 0;
            int andares = elevadorPrincipal.Andares = 0;
            int maxandares = elevadorPrincipal.MaxAndares = 6;
            int pessoas = elevadorPrincipal.PessoasPresentes = 0;
            int capacidade = elevadorPrincipal.Capacidade = 5;
            
            
            // Saudação aos usuários e instrução para escolher ação.
            Console.WriteLine("Estamos felizes com sua visita ao Edifício FuturoTech!");
            Console.WriteLine("");
            Console.WriteLine("Por favor, escolha uma opção: [a] = Inicializar |[b] = Entrar | [c] = Subir | [d] = Sair | [e] = Descer | [x] = Manutenção");
            Console.WriteLine("");

            /*
            Variável menu recebe "linha vazia", pula, menu padrão, pula, "linha vazia" , que são usadas
            por diversas vezes no programa.
            */
            string menu = "" + "\nPor favor, escolha uma opção: [a] = Inicializar | [b] = Entrar | [c] = Subir | [d] = Sair | [e] = Descer | [x] = Manutenção" + "\n";


            // Controle para SwitchCase.

            bool continuar = true;

            do
            {
                char escolha;

                escolha = char.Parse(Console.ReadLine().ToLower());

                switch (escolha)
                {
                    case 'a':
                        Console.WriteLine("");
                        Console.WriteLine("Chamando elevador vazio para o térreo. \nFavor, aguarde...");
                        int[] inicializacao = elevadorPrincipal.Inicializar();
                        andares = inicializacao[0];
                        pessoas = inicializacao[1];
                        break;

                    case 'b':
                        Console.WriteLine("");
                        if (pessoas == capacidade)
                        {
                            Console.WriteLine("Função inválida! Elevador está lotado, aguarde alguém sair.");
                            Console.WriteLine(menu);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.Write("Favor, informe quantas pessoas entrarão: ");
                            int qtentrar = int.Parse(Console.ReadLine());
                            pessoas = elevadorPrincipal.Entrar(qtentrar);
                            break;
                        }

                    case 'c':
                        Console.WriteLine("");
                        if (andares == maxandares)
                        {
                            Console.WriteLine("Função inválida! Já estamos no último andar! Se deseja descer, escolha a opção adequada.");
                            Console.WriteLine(menu);
                            break;
                        }
                        else
                        {
                            Console.Write("Favor, informe para qual andar deseja subir: ");
                            int andaresSubir = int.Parse(Console.ReadLine());
                            andares = elevadorPrincipal.Subir(andaresSubir);
                            break;
                        }

                    case 'd':
                        Console.WriteLine("");
                        if (pessoas == 0)
                        {
                            Console.WriteLine("Função inválida! Não há ninguém no elevador.");
                            Console.WriteLine(menu);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.Write("Favor, informe quantas pessoas sairam: ");
                            int qtsair = int.Parse(Console.ReadLine());
                            pessoas = elevadorPrincipal.Sair(qtsair);
                            break;
                        }                    

                    case 'e':
                        Console.WriteLine("");
                        if (andares == terreo)
                        {
                            Console.WriteLine("Função inválida! Se deseja subir, escolha a opção adequada.");
                            Console.WriteLine(menu);
                            break;
                        }
                        else
                        {
                            Console.Write("Favor, informe para qual andar deseja descer: ");
                            int andaresDescer = int.Parse(Console.ReadLine());
                            andares = elevadorPrincipal.Descer(andaresDescer);
                            break;
                        }
                    
                    // Em 'x' chamamos método Desligar, que retorna elevador para térreo, zera quantidade
                    // de pessoas e torna falso variável continuar, o que encerra o Do-While e, portanto,
                    // finaliza o próprio programa.
                    case 'x':
                        Console.WriteLine("");
                        Console.Write("Desligando sistemas para manutenção.");
                        int[] shutdown = elevadorPrincipal.Desligar();
                        andares = shutdown[0];
                        pessoas = shutdown[1];
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Escolha inválida.");
                        Console.WriteLine(menu);
                        break;
                }
                
            }
            while (continuar);
        }

    }
}
