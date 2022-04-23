namespace PizzaComFactory
{
    public class PizzaCalabresa : Pizza
    {
        public PizzaCalabresa()
        {
            Nome = "Pizza de Calabresa";
        }
        
        public override void Preparar()
        {
            Console.WriteLine($"Preparando a {Nome}");
        }

        public override void Assar(int tempo)
        {
            Console.WriteLine($"A {Nome} ficará pronta em {tempo} min.");
        }

        public override void Embalar()
        {
            Console.WriteLine($"A {Nome} está sendo embalada.");
        }
    }
}