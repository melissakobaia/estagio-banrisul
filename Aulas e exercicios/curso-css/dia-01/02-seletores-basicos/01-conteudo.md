# Seletores Básicos no CSS

No CSS, utilizamos **seletores** para escolher quais elementos serão estilizados. Eles permitem aplicar estilos de forma precisa a partes específicas do conteúdo, e cada tipo de seletor permite um nível diferente de customização.

---

## 1. **Seletores de Elemento**
   Os seletores de elemento aplicam estilos a todas as instâncias de um elemento HTML específico.

   - **Sintaxe**:
     ```css
     elemento {
         propriedade: valor;
     }
     ```

   - **Exemplo**:
     ```css
     p {
         color: black;
         font-size: 16px;
     }
     ```
     Esse código aplica um estilo a todos os parágrafos `<p>` da página, definindo a cor do texto como preto e o tamanho da fonte como 16px.


## 2. **Seletores de Classe**
   Os seletores de classe são utilizados para aplicar estilos a um ou mais elementos que possuam a mesma classe. Para selecionar uma classe no CSS, usa-se o ponto (`.`) seguido do nome da classe.

   - **Sintaxe**:
     ```css
     .nome-da-classe {
         propriedade: valor;
     }
     ```

   - **Exemplo**:
     ```css
     .destaque {
         color: blue;
         font-weight: bold;
     }
     ```

     ```html
     <p class="destaque">Este texto será azul e em negrito.</p>
     <span class="destaque">Este texto também será azul e em negrito.</span>
     ```
     No exemplo acima, qualquer elemento com a classe `destaque` terá o texto azul e em negrito.


## 3. **Seletores de ID**
   O seletor de ID é usado para aplicar estilos a um elemento específico. IDs são únicos, ou seja, cada ID deve ser usado apenas uma vez por página. Para declarar um ID, usa-se o símbolo `#` seguido do nome do ID no CSS.

   - **Sintaxe**:
     ```css
     #nome-do-id {
         propriedade: valor;
     }
     ```

   - **Exemplo**:
     ```css
     #principal {
         background-color: lightgrey;
         padding: 20px;
     }
     ```

     ```html
     <div id="principal">Este é o conteúdo principal da página.</div>
     ```
     Esse estilo será aplicado apenas ao elemento com o ID `principal`.

---


### Quando Usar IDs vs. Classes

| Critério                        | ID                                         | Classe                                  |
|---------------------------------|--------------------------------------------|-----------------------------------------|
| **Aplicação**                   | Elemento único                             | Múltiplos elementos                     |
| **Especificidade**              | Alta                                       | Moderada                                |
| **Reutilização**                | Não deve ser reutilizado                   | Pode ser reutilizado                    |
| **Exemplo de Uso**              | Estilos exclusivos de um elemento específico, como um cabeçalho único | Estilos aplicáveis a vários itens, como botões de formulário |

---

## 4. **Seletores de Atributo**
Os **seletores de atributo** são um tipo poderoso de seletor no CSS que permitem aplicar estilos a elementos HTML com base em atributos específicos, como `type`, `href`, `title`, entre outros. Esses seletores são especialmente úteis quando se deseja estilizar campos de formulários, links, ou qualquer elemento que possua atributos específicos, sem precisar adicionar classes ou IDs adicionais.

   - **Sintaxe**:
     ```css
     elemento[atributo="valor"] {
         propriedade: valor;
     }
     ```

   - **Exemplo**:
     ```css
     input[type="text"] {
         border: 1px solid black;
         padding: 5px;
     }
     ```
     Esse estilo será aplicado a todos os campos de entrada (`<input>`) do tipo `text`.