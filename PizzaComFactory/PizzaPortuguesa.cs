namespace PizzaComFactory
{
    public class PizzaPortuguesa : Pizza
    {
        public PizzaPortuguesa()
        {
            Nome = "Pizza de Portuguesa";
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