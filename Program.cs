// Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
// O sistema deve exibir um menu com as seguintes opções:

// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair

// Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N).


// // // 1- FAZER O USUARIO DIGITAR UMA SENHA PARA PODER ENTRAR NO SISTEMA

// // // // 2- DEPOIS DE ENTRAR, MOSTRAR AS SEGUINTES OPCOES:
// // // 1-  para Cadastrar passagem
// // // 2-  para Listar Passagens
// // // 0-  Para Sair


// // // // MOSTRAR 5 PASSAGEIROS CADA UM COM:
// // // NOME DO PASSAGEIRO
// // // ONDE ELE ESTA
// // // PARA ONDE VAI
// // // DATA DO VOO

string[] nome = new string[5];
string[] embarque = new string[5];
string[] desembarque = new string[5];
string[] dataVoo = new string[5];

static void BarraCarregamento(string texto, int quantidadePontinhos, int tempo)
{

    Console.Write(texto);

    for (int i = 0; i < quantidadePontinhos; i++)
    {
        Console.Write($".");
        Thread.Sleep(tempo);
    }
}

int senhaValidacao = 2023;


Console.WriteLine(@$"
                                    ------------------------------------------------------
                                    |                                                    | 
                                    |                                                    | 
                                    |                                                    | 
                                    |                      Bem vindo(a)                  | 
                                    |                                                    | 
                                    |                                                    | 
                                    |                                                    |
                                    ------------------------------------------------------                
");

Console.WriteLine($"Digite a senha requerida para entrar no sistema(2023): ");
int senhaDigitada = int.Parse(Console.ReadLine());

while (senhaDigitada != 2023)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    BarraCarregamento("Entrando no sistema", 15, 300);
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(@$"
    
    Login inválido, digite novamente: 
    ");
    Console.ResetColor();
    senhaDigitada = int.Parse(Console.ReadLine());
}

if (senhaValidacao == senhaDigitada)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    BarraCarregamento("Entrando no sistema", 10, 400);
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(@$"
        
        Login válido
        ");
    Console.ResetColor();
}


Console.WriteLine(@$"
                                    ------------------------------------------------------
                                    |           O que voçê gostaria de fazer?            | 
                                    |   (Digite o número referente a opção desejada)     | 
                                    |                                                    | 
                                    |   1- Cadastrar passagem                            | 
                                    |   2- Listar passagens                              | 
                                    |   0- Sair                                          | 
                                    |                                                    |
                                    ------------------------------------------------------                
");

int operacao = int.Parse(Console.ReadLine());



switch (operacao)
{
    case 0:
        Console.ForegroundColor = ConsoleColor.Yellow;
        BarraCarregamento("Caregando", 10, 400);
        Console.ResetColor();
        Console.WriteLine(@$"
        Voçê saiu do programa!
        ");
        Environment.Exit(0);
        break;

    case 1:
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine(@$"
            {i + 1}º Passageiro
            ");

            Console.WriteLine($"Digite seu nome: ");
            nome[i] = Console.ReadLine();

            Console.WriteLine($"Digite o local de embarque: ");
            embarque[i] = Console.ReadLine();

            Console.WriteLine($"Digite o local de desembarque: ");
            desembarque[i] = Console.ReadLine();

            Console.WriteLine($"Digite a data do voo( Exemplo: XX/XX/XXXX): ");
            dataVoo[i] = Console.ReadLine();
        }
        break;

    case 2:
        break;

}

Console.WriteLine(@$"Gostaria de cadastrar uma nova passagem?

Digite:

S para sim 
N para não
");
char questao = char.Parse(Console.ReadLine());

for (int i = 0; i < 4; i++)

    if (questao == 's')
    {
        Console.WriteLine($"Digite seu nome: ");
        nome[i] = Console.ReadLine();

        Console.WriteLine($"Digite o local de embarque: ");
        embarque[i] = Console.ReadLine();

        Console.WriteLine($"Digite o local de desembarque: ");
        desembarque[i] = Console.ReadLine();

        Console.WriteLine($"Digite a data do voo( Exemplo: XX/XX/XXXX): ");
        dataVoo[i] = Console.ReadLine();

        Console.WriteLine(@$"Passagensa cadastradas: 

{i + 1}º Passageiro:

Nome: {nome[i]}
Local de embarque: {embarque[i]}
Local de desembarque: {desembarque[i]}
Data: {dataVoo[i]}
");
    }


for (int i = 0; i < 3; i++)

    if (operacao == 2)
    {
        Console.WriteLine(@$"Passagensa cadastradas: 

{i + 1}º Passageiro:

Nome: {nome[i]}
Local de embarque: {embarque[i]}
Local de desembarque: {desembarque[i]}
Data: {dataVoo[i]}
");
    }



