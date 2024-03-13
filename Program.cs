// See https://aka.ms/new-console-template for more information

double precoAlcool;
double precoGas;
double quantidadeAbastecidaAlcool;
double quantidadeAbastecidaGas;


Console.Write("Qual o preço do litro do álcool? R$");
precoAlcool = Convert.ToDouble(Console.ReadLine());

Console.Write("Qual o preço do litro do gás? R$");
precoGas = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Qual foi a quantidade abastecida de álcool em litros? ");
quantidadeAbastecidaAlcool = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Qual foi a quantidade abastecida de gás em litros? ");
quantidadeAbastecidaGas = Convert.ToDouble(Console.ReadLine());

double custoAlcool = precoAlcool * quantidadeAbastecidaAlcool;
double custoGas = precoGas * quantidadeAbastecidaGas;

Console.WriteLine($"Custo total do Álcool: R$ {custoAlcool:F2}");
Console.WriteLine($"Custo total do Gás: R$ {custoGas:F2}");

Console.WriteLine("------------------------------");

if (custoAlcool < custoGas)
{
    Console.WriteLine("A opção mais econômica é abastecer com álcool.");
}
else
{
    Console.WriteLine("A opção mais econômica é abastecer com Gás.");
}