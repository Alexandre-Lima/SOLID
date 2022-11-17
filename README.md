# SOLID
Projeto a fim de experimento com praticas de princípios SOLID
________________________________


# 1 - Single Responsibility Principle (Princípio da Responsabilidade Única) 
— Uma classe deve ter um, e somente um, motivo para mudar.

Esse princípio declara que uma classe deve ser especializada em um único assunto e possuir apenas uma responsabilidade dentro do software, ou seja, a classe deve ter uma única tarefa ou ação para executar.

Quando estamos aprendendo programação orientada a objetos, sem sabermos, damos a uma classe mais de uma responsabilidade e acabamos criando classes que fazem de tudo — God Class*.
________________

# 2 - Open-Closed Principle (Princípio Aberto-Fechado) 
— Objetos ou entidades devem estar abertos para extensão, mas fechados para modificação, ou seja, quando novos comportamentos e recursos precisam ser adicionados no software, devemos estender e não alterar o código fonte original.
________________

# 3 - Liskov Substitution Principle (Princípio da substituição de Liskov) 
— Uma classe derivada deve ser substituível por sua classe base.

Se S é um subtipo de T, então os objetos do tipo T, em um programa, podem ser substituídos pelos objetos de tipo S sem que seja necessário alterar as propriedades deste programa.
________________

# 4 - Interface Segregation Principle (Princípio da Segregação da Interface) 
— Uma classe não deve ser forçada a implementar interfaces e métodos que não irão utilizar.

Esse princípio basicamente diz que é melhor criar interfaces mais 
específicas ao invés de termos uma única interface genérica.
________________

# 5 - Dependency Inversion Principle (Princípio da Inversão de Dependência) 
— Dependa de abstrações e não de implementações.

1. Módulos de alto nível não devem depender de módulos de baixo nível. Ambos devem depender da abstração.

2. Abstrações não devem depender de detalhes. Detalhes devem depender de abstrações.
