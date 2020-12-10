using System;

namespace AulaPOO_Abstracao.classes
{
    public class Boleto : Pagamento
    {
        private string codigoDeBarras = "123456.123123123.123123123.123123123";
        public string CodigoDeBarras{
            get{return codigoDeBarras;}
        }

        public void Registrar(float valor, DateTime data, string codigoDeBarras){
            Console.WriteLine($"O valor da compra fica em R${valor-(valor*0.12f)}");
            Console.WriteLine($"data de emissão = {Data}");
            Console.WriteLine($"Data de Vencimento = {Data.AddDays(10)}");
            Console.WriteLine($"Código de Barras = {codigoDeBarras}");
        }

    }
}