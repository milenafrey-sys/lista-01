Console.Write("Informe o valor total da compra: R$ ");
double valorCompra = Convert.ToDouble(Console.ReadLine());

double desconto = 0;

if (valorCompra >= 200)
{
    desconto = valorCompra * 0.10;
}

double valorFinal = valorCompra - desconto;

Console.WriteLine($"Valor original: R$ {valorCompra:F2}");
Console.WriteLine($"Desconto aplicado: R$ {desconto:F2}");
Console.WriteLine($"Valor final: R$ {valorFinal:F2}");