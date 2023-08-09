using System;
using System.Globalization;

namespace PrimeiroPj {
    class Program {
        static void Main(string[] args) {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Prudutos:\n" + produto1 + ", cujo preço é $" + preco1.ToString("F2") + 
                "\n" + produto2 + ", cujo o preço é $" + preco2.ToString("F2") + 
                "\n\n" + "Registro: " + idade + " anos de idade, código: " + codigo + " e gênero: " + genero + 
                "\n\n" + "Medida com oito casas decimais: " + medida.ToString("F8") + 
                "\nArredondado (três casas decimais): " + medida.ToString("F3") + 
                "\nSeparador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
