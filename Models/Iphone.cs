namespace DesafioPOO.Models
{
    //  classe "Smartphone" herdada
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base (numero,modelo,imei,memoria)
        {
            
        }
        // Sobrescrevi o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia");
        }
    }
}