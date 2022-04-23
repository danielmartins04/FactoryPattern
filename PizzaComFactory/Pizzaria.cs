namespace PizzaComFactory
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

            try
            {
                Pizza pizza = PizzaSimpleFactory.CriarPizza(option.KeyChar);
                pizza.Preparar();
                pizza.Assar(20);
                pizza.Embalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }
    }
}