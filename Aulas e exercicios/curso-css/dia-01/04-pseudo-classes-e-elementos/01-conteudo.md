# Pseudo-classes e Pseudo-elementos no CSS

As **pseudo-classes** e **pseudo-elementos** são ferramentas do CSS que permitem estilizar **estados** e **partes específicas** de elementos sem alterar o HTML. Juntos, eles permitem interações ricas e efeitos visuais sem o uso de JavaScript.

---

## 1. Visão Geral

- **Pseudo-classes** (`:nome`) selecionam elementos com base em **estado** (ex.: `:hover`, `:focus`) ou **posição** (ex.: `:first-child`, `:nth-child()`).
- **Pseudo-elementos** (`::nome`) criam ou estilizam **partes de um elemento** (ex.: `::before`, `::first-letter`) ou **áreas geradas**, como a **seleção de texto** (`::selection`).

---

## 2. Pseudo-classes

**Sintaxe:**
```css
elemento:pseudo-classe {
  propriedade: valor;
}
```

### 2.1 Interatividade do Usuário
Usadas para estilizar elementos conforme o usuário interage com a página.

**Principais:**
- `:hover` — quando o mouse passa sobre o elemento.
- `:focus` — quando o elemento está em foco (ex.: input selecionado).
- `:active` — durante o clique ou ativação.

**Exemplo:**
```css
button:hover {
  background-color: blue;
  color: white;
}
```
  Neste caso, ao passar o mouse sobre um botão (`<button>`), ele muda para fundo azul e texto branco.

```css
input:focus {
  outline: 2px solid green;
}
```
  Aqui, qualquer campo de entrada (`<input>`) em foco terá uma borda verde.

---

### 2.2 Estruturais (posição no DOM)
Permitem selecionar elementos com base em sua **posição** dentro do elemento pai.

**Principais:**
- `:first-child` — o primeiro filho.
- `:last-child` — o último filho.
- `:nth-child(n)` — filho de número *n* (ou padrão `odd`/`even`).

**Exemplo:**
  ```css
  p:first-child {
      font-weight: bold;
  }
  ```

  Aqui, apenas o primeiro parágrafo (`<p>`) de um contêiner será exibido em negrito.

  ```css
  tr:nth-child(odd) {
      background-color: #f2f2f2;
  }
  ```

  Esse código aplica um fundo cinza claro a linhas ímpares de uma tabela.

---

### 2.3 Estados de Formulário
Aplicadas a elementos de formulário de acordo com seu estado.

**Principais:**
- `:checked` — quando um checkbox/radio está selecionado.
- `:disabled` / `:enabled`
- `:valid` / `:invalid`

**Exemplo:**
  ```css
  input:disabled {
      background-color: #ddd;
      color: #666;
  }
  ```
  Este estilo altera a cor do fundo e do texto dos campos desativados para indicar que não estão disponíveis para edição.

---

### 2.4 Links
Definem o estilo de links em diferentes estados.

**Principais:**
- `:link` — seleciona links que **ainda não foram visitados**.  
- `:visited` — seleciona links que **já foram visitados**.  
- `:hover` — aplicado quando o usuário **passa o mouse** sobre o link.  
- `:active` — aplicado **no momento do clique**.  

**Exemplo:**
  ```css
  a:visited {
      color: purple;
  }
  ```

  Links já visitados pelo usuário aparecerão na cor roxa.

---

### 2.5 Negação
A pseudo-classe `:not()` aplica estilos a elementos **que não** correspondem ao seletor informado.

**Exemplo:**
```css
button:not(.primary) {
    background-color: gray;
}
```
Esse exemplo aplica um fundo cinza a todos os botões (`<button>`) que **não** têm a classe `primary`.

---

## 3. Pseudo-elementos

**Sintaxe:**
```css
elemento::pseudo-elemento {
  propriedade: valor;
}
```

> 💡 A sintaxe moderna usa `::`, mas `:` ainda é aceita por compatibilidade.

---

### 3.1 `::before` e `::after`
Permitem **inserir conteúdo gerado** antes ou depois do conteúdo real do elemento. É **obrigatório** usar a propriedade `content` para que o pseudo-elemento apareça.

**Exemplo:**
```css
h1::before {
    content: "→ ";
    color: blue;
}
```

Aqui, o símbolo "→ " será inserido antes de cada título `<h1>` e terá a cor azul.

---

### 3.2 Tipografia e Seleção de Texto
Controlam partes específicas do texto.

**Principais:**
- `::first-line` — primeira linha de um parágrafo.
- `::first-letter` — primeira letra do texto.
- `::selection` — parte selecionada pelo usuário.

**Exemplo**:
```css
p::first-line {
    font-weight: bold;
    color: darkblue;
}
```
Aqui, apenas a primeira linha de cada parágrafo (`<p>`) ficará em negrito e na cor azul escuro.

---

### 3.3 Usos Comuns
- Inserir ícones ou símbolos sem alterar o HTML.
- Marcar campos obrigatórios:
  ```css
  label.required::after {
    content: " *";
    color: red;
  }
  ```
- Criar decorações, contadores ou separadores visuais.

---

## 4. Combinação de Pseudo-classes e Pseudo-elementos

É possível combinar pseudo-classes com pseudo-elementos para aplicar estilos ainda mais dinâmicos.

**Exemplo**: Destacando a primeira letra de um parágrafo em hover
```css
p:hover::first-letter {
    color: orange;
    font-size: 1.5em;
}
```

Neste caso, a primeira letra do parágrafo ficará laranja e maior ao passar o mouse sobre ele.

