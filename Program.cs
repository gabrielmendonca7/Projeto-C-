using System;
using System.Globalization;

namespace Desafio
{
    class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados");

            Console.Write("Car model: ");
            string carro = Console.ReadLine();
            Console.Write("Entrada (dd/MM/yyyy HH:mm): ");
            DateTime entrada = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm",CultureInfo.InvariantCulture);
            Console.Write("Saída (dd/MM/yyyy HH:mm): ");
            DateTime saida = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm",CultureInfo.InvariantCulture);

            Console.Write("Entre com o preço por hora: ");
            double pHora = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Entre com o preço por dia: ");
            double pDia = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(entrada,saida,new Vehicle(carro));
            RentalService rentalService = new RentalService(pHora,pDia,new BrazilTax());
            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("NOTA FISCAL: ");
            Console.WriteLine(carRental.Invoice);
        }
    }
}

