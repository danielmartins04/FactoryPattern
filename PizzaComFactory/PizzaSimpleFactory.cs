namespace PizzaComFactory
{
    public sealed class PizzaSimpleFactory
    {
        public static Pizza CriarPizza(char tipo)
        {
            Pizza pizza;

            switch(tipo)
            {
                case '1':
                    pizza = new PizzaCalabresa();
                    break;
                case '2':
                   pizza = new PizzaPortuguesa();
                    break;
                default:
                    throw new Exception("Não há disponível o tipo requerido.");
            }

            return pizza;
        }
    }
}