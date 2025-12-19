# Posicionamento e Display

Nesta aula, você aprenderá como controlar o **comportamento e a posição dos elementos** na página.  
Com o CSS, é possível determinar **como os blocos se organizam**, **como se sobrepõem** e **como se ajustam ao espaço disponível**.

---

## 1. Tipos de Exibição (Display)

A propriedade `display` define **como um elemento é exibido na página** — se ele ocupa toda a linha, se pode ficar lado a lado com outros, ou se é invisível.

### Principais valores:

| Valor | Descrição | Exemplo |
|-------|------------|----------|
| `block` | O elemento ocupa toda a largura disponível e começa em uma nova linha. | `<div>`, `<p>`, `<section>` |
| `inline` | O elemento ocupa apenas o espaço necessário e **não quebra linha**. | `<span>`, `<a>`, `<strong>` |
| `inline-block` | Combina características dos dois: ocupa só o espaço necessário, mas permite definir largura e altura. | Ideal para botões, menus, etc. |
| `none` | Oculta completamente o elemento da página (não ocupa espaço). | — |

### Exemplo :
```css
p {
    display: block;
}
```

---

## 2. Fluxo da Página e o Position

A propriedade `position` define **como o elemento é posicionado** em relação ao seu contêiner, ao documento ou a outros elementos.

### Principais valores de `position`:

| Valor | Descrição |
|-------|------------|
| `static` | Padrão. O elemento segue o fluxo normal da página. |
| `relative` | Move o elemento em relação à sua posição original. |
| `absolute` | Posiciona o elemento de forma **absoluta**, em relação ao primeiro ancestral com `position: relative`. |
| `fixed` | Fixa o elemento em uma posição específica da janela (mesmo ao rolar a página). |
| `sticky` | Combina comportamentos de `relative` e `fixed`: o elemento “gruda” ao rolar até certo ponto. |

### Exemplo:
```css
.caixa1 {
    position: relative;
    top: 20px;
    left: 10px;
}

.menu-fixo {
    position: fixed;
    top: 0;
    width: 100%;
}
```

---

## 3. Controle de Sobreposição – `z-index`

Quando dois elementos se sobrepõem, o `z-index` define **quem fica por cima**.

### Exemplo:

```css
.elemento1 {
    position: absolute;
    z-index: 1;
}

.elemento2 {
    position: absolute;
    z-index: 2; /* Fica acima */
}
```

> 💡 O `z-index` só funciona em elementos **com `position` diferente de `static`**.

---

## 4. Controle de Conteúdo – `overflow`

A propriedade `overflow` define **o que acontece quando o conteúdo ultrapassa o tamanho do elemento**.

| Valor | Efeito |
|--------|---------|
| `visible` | O conteúdo que ultrapassar será exibido (padrão). |
| `hidden` | O conteúdo que ultrapassar será cortado. |
| `scroll` | Adiciona barras de rolagem sempre. |
| `auto` | Adiciona barras de rolagem somente quando necessário. |

### Exemplo:

```css
div {
    width: 200px;
    height: 100px;
    overflow: auto;
}
```

---

## 5. Sistemas Modernos de Layout: Flexbox e Grid

Com o tempo, o CSS evoluiu e trouxe novas formas de organizar elementos na tela.  
As propriedades **`flexbox`** e **`grid`** são ferramentas modernas para construir **layouts responsivos e organizados**, substituindo boa parte do uso de `float` e `position` para estruturar páginas. Nesta aula, veremos uma introdução sobre esses recursos.

---

### 5.1 Flexbox (Layout unidimensional)

O **Flexbox** foi criado para facilitar a **organização de elementos em linha ou em coluna**, ajustando automaticamente o espaço entre eles. Com ele, você pode **centralizar itens**, **criar espaçamentos uniformes**, e **adaptar o layout a diferentes tamanhos de tela**.

Para usar o Flexbox, aplicamos a propriedade `display: flex` ao **container** (o elemento pai).  
Os elementos dentro dele tornam-se **itens flexíveis** e podem ser alinhados com facilidade.

**Exemplo:**

```css
.container {
    display: flex;
    justify-content: center; /* Alinha horizontalmente */
    align-items: center; /* Alinha verticalmente */
    gap: 10px;
}
```

**HTML:**
```html
<div class="container">
    <div class="item">A</div>
    <div class="item">B</div>
    <div class="item">C</div>
</div>
```


---

### 5.2 Grid (Layout bidimensional)

O **Grid Layout** organiza o conteúdo em **linhas e colunas**, sendo ideal para criar **estruturas mais complexas**, como o esqueleto de uma página completa.
Para usar o Grid, aplicamos `display: grid` ao **container** (elemento pai).  
Os elementos filhos tornam-se **itens de grid**.

```css
.container {
    display: grid;
    grid-template-columns: 1fr 2fr;
    gap: 10px;
}
```

**HTML:**
```html
<div class="container">
    <div class="sidebar">Barra lateral</div>
    <div class="content">Conteúdo principal</div>
</div>
```