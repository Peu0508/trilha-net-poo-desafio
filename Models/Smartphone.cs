namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }

        protected string Modelo { get; set; }

        protected string IMEI { get; set; }

        protected int Memoria { get; set; }

    
        // TODO: Implementadas as propriedades faltantes de acordo com o diagrama
        // TODO: Passados os parâmetros do construtor para as propriedades

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}