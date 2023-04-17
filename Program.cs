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











