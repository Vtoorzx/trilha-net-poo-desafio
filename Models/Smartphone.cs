using System.Security.Cryptography.X509Certificates;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string Modelo { get; set; }
        private string Imei { get; set; }
        private int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;


        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação de um nokia...");
        }

        public abstract void InstalarAplicativo(string nomeApp);

        public void LicacaorNokia()
        {
            Console.WriteLine("Você está ligando para (81) 984040803.");
        }

        public void InstalandoApp()
        {
            Console.WriteLine("Você clicou para instalar whatsapp");
        }

        public void AtenderLigacao()
        {

            Console.WriteLine("digite sim para atender a ligação");
            string confirmacao = Console.ReadLine();
            {
                if (confirmacao.ToLower() == "sim")
                {
                    Console.WriteLine("Você atendeu a ligação");
                }

                else
                {
                    Console.WriteLine("Você rejeitou a ligação \n");
                }

            }
        }

        public void InstalarInstagram()
        {
            Console.WriteLine("Você clicou para instalar o instagram");
        }
    }



}
