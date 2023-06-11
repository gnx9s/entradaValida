Console.WriteLine("-- ENTRADA VÁLIDA OU NÃO --");


int valorInserido = 10;

while (valorInserido < 0 || valorInserido > 9)
{
    mensagem("", ConsoleColor.White);
    mensagem("Digite um número entre 1 e 9 (ou 0 para cancelar a operação)...", ConsoleColor.White);
    valorInserido = int.Parse(Console.ReadLine()!);
}

if (valorInserido == 0)
{
    mensagem("Operação cancelada.", ConsoleColor.Red);
}

else 
{
    mensagem($"O número digitado foi = {valorInserido}", ConsoleColor.Green);
}

void mensagem(string mensagem, ConsoleColor corMensagem)
{
    Console.ForegroundColor = corMensagem;
    Console.WriteLine(mensagem);
    Console.ResetColor();
}