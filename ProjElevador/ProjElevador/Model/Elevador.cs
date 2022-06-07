using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjElevador.Model
{
    /*
    Definição da classe Elevador e suas propriedades, onde:
    - Térreo receberá 0;
    - Andares receberá 0 inicialmente, mas mudará para qual andar o elevador está;
    - MaxAndares receberá 6 (número de andares do Edifício FuturoTech) e não mudará com uso do programa;
    - PessoasPresentes receberá 0, mas mudará conforme ocupação do elevador;
    - Capacidade receberá 5 (número máximo de ocupantes para este elevador) e não mudará durante programa.
    */
    public class Elevador
    {
        
        public int Terreo { get; set; }
        public int Andares { get; set; }
        public int MaxAndares { get; set; }
        public int PessoasPresentes { get; set; }
        public int Capacidade { get; set; }

        /*
        Variável menu recebe "linha vazia", pula, menu padrão, pula, "linha vazia" , que são usadas
        por diversas vezes no programa.
        */
        string menu = "" + "\nPor favor, escolha uma opção: [a] = Inicializar | [b] = Entrar | [c] = Subir | [d] = Sair | [e] = Descer | [x] = Manutenção" + "\n";
        

        /*
        Primeiramente, o método Entrar é cancelado caso elevador já esteja lotado (isso no Program).
        Depois, foi declarado variável livre para definir espaço vago no elevador. Em seguida, foi definido
        while que impede ser informado número de pessoas a entrar maior que Capacidade. Passado isso,
        while seguinte testa se número informado é menor ou igual a Capacidade, e o sendo, é testado se
        informado é menor ou igual a livre. Estando OK, PessoasPresentes é acrescido do número informado, enquanto
        o contrário ocorre com livre, e faz-se na sequência uma if-else ir-else apenas para ajustes de concordância
        verbale, caso usuário informe 0 (valor inválido), foi usado break para voltar ao menu inicial. Ao final, temos o else que fecha o if, caso número informado seja maior que pessoas livres,
        terminando com return da situação de PessoasPresentes.
        */
        public int Entrar(int qtpessoas)
        {
            int livre = Capacidade - PessoasPresentes;

            while (qtpessoas > Capacidade)
            {
                Console.WriteLine("Valor inválido! Elevador suporta até " + Capacidade + " pessoas. Favor, tente novamente.");
                qtpessoas = int.Parse(Console.ReadLine());
            }

            while (livre <= Capacidade)
            {
                if (qtpessoas <= livre)
                {
                    PessoasPresentes = PessoasPresentes + qtpessoas;
                    livre = livre - qtpessoas;

                    if (qtpessoas > 1)
                    {
                        Console.WriteLine("Entraram " + qtpessoas + " pessoas no elevador. Ainda cabem " + livre + " pessoas.");
                        Console.WriteLine(menu);                        
                        break;
                    }
                    else if (qtpessoas == 1)
                    {
                        Console.WriteLine("Entrou " + qtpessoas + " pessoa no elevador. Ainda cabem " + livre + " pessoa(s).");
                        Console.WriteLine(menu);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Não entrou ninguém!");
                        Console.WriteLine(menu);
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Elevador não suporta tantas pessoas. Cabem apenas mais " + livre + " pessoas.");
                    Console.WriteLine("Favor, informe uma quantidade menor de pessoas.");
                    qtpessoas = int.Parse(Console.ReadLine());
                }
            }         
            return PessoasPresentes;
        }

        /*
        Primeiramente, o método Sair é cancelado caso elevador já esteja vazio (isso no Program).
        Depois, foi declarado variável livre para definir espaço vago no elevador. Em seguida, foi definido
        while que impede ser informado número de pessoas a sair maior que Capacidade. Passado isso,
        while seguinte testa se número informado é menor ou igual a Capacidade, e o sendo, é testado se
        informado é menor ou igual a PessoasPresentes. Estando OK, de PessoasPresentes é subtraido o número informado,
        enquanto o contrário ocorre com livre, e faz-se na sequência uma if-else if-else apenas para ajustes de concordância
        verbal e, caso usuário informe 0 (valor inválido), foi usado break para voltar ao menu inicial.
        Ao final, temos o else que fecha o if, caso número informado seja maior que pessoas livres,
        terminando com return da situação de PessoasPresentes.
        */
        public int Sair(int qtpessoas)
        {
            int livre = Capacidade - PessoasPresentes;

            while (qtpessoas > Capacidade)
            {
                Console.WriteLine("Valor inválido! Não há mais que " + Capacidade + " pessoas neste elevador. Favor, tente novamente.");
                qtpessoas = int.Parse(Console.ReadLine());
            }

            while (qtpessoas <= Capacidade)
            {
                if (qtpessoas <= PessoasPresentes)
                {
                    PessoasPresentes = PessoasPresentes - qtpessoas;
                    livre = livre + qtpessoas;
                    if (qtpessoas == 1)
                    {
                        Console.WriteLine("Saiu " + qtpessoas + " pessoa do elevador. Agora cabem mais" + livre + " pessoas aqui.");
                        Console.WriteLine(menu);
                        break;
                    }
                    else if (qtpessoas > 1)
                    {
                        Console.WriteLine("Estão saindo " + qtpessoas + " pessoas do elevador. Agora cabem mais " + livre + " pessoas aqui.");
                        Console.WriteLine(menu);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Não saiu ninguém!");
                        Console.WriteLine(menu);
                        break;
                    }

                }
                else
                {
                    Console.WriteLine("Valor inválido! Há apenas " + PessoasPresentes + " pessoas neste elevador. Favor, tente novamente.");
                    Console.WriteLine("Favor, informe quantas pessoas querem sair.");
                    qtpessoas = int.Parse(Console.ReadLine());
                }
            }
            return PessoasPresentes;
        }

        /*
        Método Subir nem inicia se ele já estivar no último andar (definido em MaxAndares).
        Caso possa subir, recebe andar informado pelo usuário, sendo que não aceita valores maiores que MaxAndares
        e, não o sendo, testa se já está no andar solicitado (daí cancela), testa e a solicitação é para
        um andar abaixo (daí cancela também) e, sendo um andar acima, se move para andar solicitado.
        */
        public int Subir(int andar)
        {
            while (andar > MaxAndares)
            {
                Console.WriteLine("Valor inválido! Este elevador atende até o 6º andar! Favor, tente novamente.");
                andar = int.Parse(Console.ReadLine());
            }

            while (andar <= MaxAndares)
            {
                if (andar == Andares)
                {
                    if (andar == Terreo)
                    {
                        Console.WriteLine("Valor inválido! Estamos no térreo! Favor, indique para qual andar subir.");
                        andar = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido! Já estamos no " + andar + "º andar! Favor, indique para qual andar subir.");
                        andar = int.Parse(Console.ReadLine());
                    }
                }
                else if (andar < Andares)
                {
                    Console.WriteLine("Valor inválido! Se deseja descer, escolha a opção adequada.");
                    Console.WriteLine(menu);
                    break;
                }
                else
                {
                    Andares = andar;
                    Console.WriteLine("Elevador subindo para o " + Andares + "º andar.");
                    Console.WriteLine(menu);
                    break;
                }
            }
            return Andares;
        }

        /*
        Método Descer nem inicia se ele já estivar no Térreo.
        Caso possa descer, recebe andar informado pelo usuário, sendo que não aceita valores maiores que MaxAndares
        e, não o sendo, pode ir para o Térreo. Ou, se 0 naõ foi solicitado, testa se já está no andar solicitado
        (daí cancela), testa e a solicitação é para um andar acima (daí cancela também) e, sendo um andar abaixo
        do atual e acima do Térreo, se move para andar solicitado.
        */
        public int Descer(int andar)
        {
            while (andar > MaxAndares)
            {
                Console.WriteLine("Valor inválido! Favor, tente novamente.");
                andar = int.Parse(Console.ReadLine());
            }           
            
            while (andar <= MaxAndares)
            {
                if (andar == Terreo)
                {
                    Andares = Terreo;
                    Console.Write("Elevador descendo para o térreo.");
                    Console.WriteLine(menu);
                    break;
                }
                else if (andar == Andares)
                {
                    Console.WriteLine("Valor inválido! Já estamos no " + andar + "º andar! Favor, indique para qual andar descer.");
                    andar = int.Parse(Console.ReadLine());
                }
                else if (andar > Andares)
                {
                    Console.WriteLine("Valor inválido! Se deseja subir, escolha a opção adequada.");
                    Console.WriteLine(menu);
                    break;
                }
                else if (andar > Terreo && andar < Andares)
                {
                    Andares = andar;
                    Console.WriteLine("Elevador descendo para o " + Andares + "º andar.");
                    Console.WriteLine(menu);
                    break;
                }                
            }
            return Andares;                        
        }
        
        /*
        No método Inicializar, declaramos que terreo recebe Terreo (propriedade que por padrão 
        sempre deixaremos com valor de 0) e declaramos que PessoasPresentes recebe 0.
        Por fim, declaramos o array inicio e o utilizamos para fazer elevedor começar no térreo
        da prédio e sem nenhum ocupante.
        */
        public int[] Inicializar()
        {
            Andares = Terreo;
            PessoasPresentes = 0;
            int[] inicio = { Andares, PessoasPresentes };

            Console.WriteLine(menu);
            return inicio;
        }

        /*
        Como usamos estrutura de repetição Do-While, foi criado método Desligar, que é chamado
        na opção [x] Manutenção do SwitchCase, com objetivo de negar repetição e encerrar programa.
        Estrutura de variáveis e valores é igual do método Inicializar, mas uso na chamada é diferente.
        */
        public int[] Desligar()
        {
            Andares = Terreo;
            PessoasPresentes = 0;
            int[] inicio = { Andares, PessoasPresentes };
            return inicio;
          }


    }

}

/*
Testes:
Console.WriteLine("Por favor, escolha uma opção: \n[n] = Digitar novamente? \n[f] = Ir para menu inicial");
                        char define = char.Parse(Console.ReadLine());

                        bool continuar = true;
                        do
                        {
                            if (define == 'n')
                            {
                                Console.Write("Quantas pessoas para entrar ? : ");
                                qtpessoas = int.Parse(Console.ReadLine());
                                continuar = false;
                            }
                            else if (define == 'f')
                            {
                                continuar = false;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Por favor, escolha uma opção: \n[n] = Digitar novamente? \n[f] = Ir para menu inicial");
                                define = char.Parse(Console.ReadLine());
                            }
                        }
                        while (continuar);
*/
