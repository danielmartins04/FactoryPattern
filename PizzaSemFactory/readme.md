Pontos negativos da abordagem sem utilização de Factory:
* Programação para implementações e não para interfaces;
* A classe cliente conhece os detalhes de implementação;
* A alteração em qualquer produto (inclusão ou remoção) é difícl de ser feita pois exige alterar o cliente;
* Código difícil de dar manutenção;
* Viola o princípio OCP - Open/Closed Principle.