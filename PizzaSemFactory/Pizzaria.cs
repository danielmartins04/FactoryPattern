namespace PizzaSemFactory
{
    public class Pizzaria
    {
        public static void SolicitarPizza()
        {
            Console.WriteLine("Bem vindo.");
            Console.WriteLine("Selecione uma opção de pizza disponível abaixo:");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("1 - Pizza de Calabresa.");
            Console.WriteLine("2 - Pizza Portuguesa.");
            Console.WriteLine("-------------------------------");

            var option = Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("---------------------------");
            Console.WriteLine("");

            switch(option.KeyChar)
            {
                case '1':
                    var pizza1 = new PizzaCalabresa();
                    pizza1.Preparar();
                    pizza1.Assar(45);
                    pizza1.Embalar();
                    break;
                case '2':
                    var pizza2 = new PizzaPortuguesa();
                    pizza2.Preparar();
                    pizza2.Assar(35);
                    pizza2.Embalar();
                    break;
                default:
                    throw new Exception("Não há disponível o tipo requerido.");
            }
        }
    }
}