namespace PizzaSemFactory
{
    public class PizzaPortuguesa
    {
        public PizzaPortuguesa()
        {
            Nome = "Pizza Portuguesa";
        }

        public string Nome { get; set; }
        
        public void Preparar()
        {
            Console.WriteLine($"Preparando a {Nome}");
        }

        public void Assar(int tempo)
        {
            Console.WriteLine($"A {Nome} ficará pronta em {tempo} min.");
        }

        public void Embalar()
        {
            Console.WriteLine($"A {Nome} está sendo embalada.");
        }
    }
}
