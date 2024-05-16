using ChainOfResponsability;

var chain = new Chain();
char exit = 'n';
while(exit == 'n')
{
    Console.WriteLine("Selecione o produto que você quer comprar:");
    Console.WriteLine("1 - Mesa R$ 1500,00");
    Console.WriteLine("2 - Monitor R$ 700,00");

    chain.StartProcessChained();
    Console.Write("Deseja sair (s/n): ");
    exit = char.Parse(Console.ReadLine());
}