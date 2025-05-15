# Atividade Avaliativa - Exercícios em C#

## Integrantes do Grupo
- Emerson Junior (substituir ou completar com mais nomes, se necessário)

## Questões Resolvidas
1. Validador de Senhas Fortes  
2. Tabuada Completa com Laço  
3. Cálculo de Fatorial com while  
4. Conversor de Temperaturas com Menu  
5. Verificador de Palíndromos  
6. Cadastro Simples de Produtos  
7. Soma de Números Pares de um Array  
8. Cálculo de IMC com Classificação  
9. Jogo da Adivinhação  
10. Lista de Tarefas (To-Do List)

## Descrição Funcional dos Exercícios

1. **Validador de Senhas Fortes:**  
   Verifica se a senha digitada atende critérios de segurança: tamanho mínimo, letra maiúscula, número e caractere especial.

2. **Tabuada Completa com Laço:**  
   Imprime a tabuada de 1 a 10 do número informado pelo usuário.

3. **Cálculo de Fatorial com while:**  
   Calcula o fatorial de um número inteiro positivo com estrutura `while`.

4. **Conversor de Temperaturas com Menu:**  
   Permite converter temperaturas entre Celsius e Fahrenheit com menu interativo (loop com switch-case).

5. **Verificador de Palíndromos:**  
   Verifica se a palavra/frase lida é um palíndromo, desconsiderando espaços e caracteres especiais.

6. **Cadastro Simples de Produtos:**  
   Permite cadastrar 3 produtos, com nome, preço e quantidade, e mostra o valor total em estoque.

7. **Soma de Números Pares de um Array:**  
   Lê 10 números e soma apenas os pares.

8. **Cálculo de IMC com Classificação:**  
   Calcula o IMC a partir do peso e altura e classifica segundo faixas padrão da OMS.

9. **Jogo da Adivinhação:**  
   Gera um número aleatório de 1 a 100. O usuário tenta adivinhar com dicas de "maior" ou "menor".

10. **Lista de Tarefas (To-Do List):**  
    Permite ao usuário adicionar tarefas e exibe todas ao final.

---

## Documentação Detalhada de Dois Exercícios

### 1. **Validador de Senhas Fortes**

#### Lógica:
1. Solicitar que o usuário digite uma senha.
2. Verificar os seguintes critérios:
   - Ter no mínimo 8 caracteres.
   - Conter ao menos uma letra maiúscula.
   - Conter ao menos um número.
   - Conter ao menos um caractere especial (como `@`, `!`, `#` etc).

#### Estruturas Utilizadas:
- **`Regex.IsMatch`**: Utilizada para verificar se um determinado padrão (regex) está presente na string.
- **`if`**: Usado para validar todos os critérios.

#### Justificativa:
A utilização de expressões regulares simplifica muito a verificação de padrões de forma concisa e eficiente. Cada verificação retorna um `bool`, facilitando a construção de uma condição composta.

---

### 2. **Cadastro Simples de Produtos**

#### Lógica:
1. Criar uma classe `Produto` com `Nome`, `Preco` e `Quantidade`.
2. Usar um laço `for` para permitir que o usuário cadastre 3 produtos.
3. Armazenar os produtos em uma `List<Produto>`.
4. Após o cadastro, calcular e exibir o valor total de cada produto (preço × quantidade).

#### Estruturas Utilizadas:
- **Classes**: Para organizar os dados dos produtos.
- **List<Produto>**: Armazena os produtos dinamicamente.
- **Laço `for`**: Para entrada de múltiplos produtos.
- **`Console.ReadLine()` e `Parse`**: Para ler e converter os dados inseridos.

#### Justificativa:
O uso de uma classe ajuda a organizar os dados de maneira orientada a objetos. A `List` permite armazenar vários objetos dinamicamente, tornando o código mais escalável e limpo.

---

### Organização do Código**
Todos os exercícios estão centralizados em um único arquivo chamado Atividades.cs. Essa abordagem visa manter a simplicidade e facilitar o gerenciamento do código durante a avaliação.
Além disso, foi criado um arquivo Program.cs, que contém o método Main() responsável por exibir um menu interativo no terminal. Através dele, o usuário pode escolher qual exercício deseja executar, tornando a navegação e utilização das funcionalidades mais prática e intuitiva.
