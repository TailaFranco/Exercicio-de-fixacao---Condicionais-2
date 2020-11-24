using System;

//Um posto está vendendo combustíveis com a seguinte tabela de descontos:
// Álcool:
// . até 20 litros, desconto de 3% por litro Álcool
// . acima de 20 litros, desconto de 5% por litro
// Gasolina:
// . até 20 litros, desconto de 4% por litro Gasolina
// . acima de 20 litros, desconto de 6% por litro

// Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
// da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
// sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.

namespace Exercício_2___posto_de_gasolina
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração de variaveis
           
            
           string combustivel;
           double alcool;
           double gasolina;
           double desconto1A;
           double desconto1B;
           double desconto2A;
           double desconto2B;
           double litros;
           double total;
           double total1;
            
            
            Console.WriteLine("Saudações, digite se o cliente comprou Alcool ou Gasolina para iniciar");
            Console.WriteLine("Lembre-se informe apenas o código: A para Alcool e G para Gasolina.");
            combustivel = Console.ReadLine();
            
            
            if(combustivel == "A")
            {
                Console.WriteLine("Atenção!!! \n Você selecionou A- Alcool, o desconto será aplicado conforme as regras vigentes");
                alcool = 4.90;
                Console.WriteLine("Digite quantos litros o cliente adquiriu:");
                litros = double.Parse(Console.ReadLine());
                if(litros <= 20)
                { 
                desconto1A = alcool * 0.03 * litros;
                total1 = alcool*litros;
                total = total1 - desconto1A;
                Console.WriteLine($"Valor total sem descontos: {total1} \n Desconto: {desconto1A} Valor total com o desconto: {total}");
                Console.WriteLine("Postos C-nai aqui você economiza muito mais!");
                }
                if (litros >20)
                {
                    desconto1B = alcool*litros*0.05;
                    total1 = alcool*litros;
                total = total1 - desconto1B;
                Console.WriteLine($"Valor total sem descontos: {total1} \n Desconto: {desconto1B} Valor total com o desconto: {total}");
                Console.WriteLine("Postos C-nai aqui você economiza muito mais!");
                }
                else
                {
                    Console.WriteLine("Dados inválidos");
                }
            }
            if (combustivel == "G")
            {
                Console.WriteLine("Atenção!!! \n Você selecionou G- Gasolina, o desconto será aplicado conforme as regras vigentes");
                gasolina = 5.30;
                Console.WriteLine("Digite quantos litros o cliente adquiriu:");
                litros = double.Parse(Console.ReadLine());
                if(litros <= 20)
                { 
                desconto2A = gasolina * 0.04 * litros;
                total1 = gasolina*litros;
                total = total1 - desconto2A;
                Console.WriteLine($"Valor total sem descontos: {total1} \n Desconto: {desconto2A} Valor total com o desconto: {total}");
                Console.WriteLine("Postos C-nai aqui você economiza muito mais!");
                }
                if (litros >20)
                {
                    desconto2B = gasolina*litros*0.06;
                    total1 = gasolina*litros;
                total = total1 - desconto2B;
                Console.WriteLine($"Valor total sem descontos: {total1} \n Desconto: {desconto2B} Valor total com o desconto: {total}");
                Console.WriteLine("Postos C-nai aqui você economiza muito mais!");
                }
                
            }
            
            
        }
    }
}
