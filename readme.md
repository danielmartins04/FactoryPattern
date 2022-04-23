## Padrões Criacionais:
Padrões de projeto criacionais abstraem e/ou adiam o processo de criação dos objetos e fornecem um mecanismo de criação de objetos que aumentam a flexibilidade e a reutilização do código existente.

### Factory
Um Factory é um objeto usado para intermediar a criação de outros objetos, sendo usado para encapsular a lógica de criação dos produtos ao cliente.

### Simple Factory
* Um Simple Factory é um objeto que é usado para criar instâncias de um objeto para o cliente. 
* Não está entres os 5 padrões criacionais GOF.

### Detalhes de implementação
* O cliente precisa de um produto, mas ao invés de criá-lo diretamente usando o operador **new** ele pede ao objeto Factory um novo produto, fornecendo as informações sobre o tipo que necessita;
* A fábrica instancia um novo produto concreto e em seguida retorna ao cliente o produto criado (convertido para uma classe abstrata);
* O cliente usa os produtos sem estar ciente de sua implementação concreta.