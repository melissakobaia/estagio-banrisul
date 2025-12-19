# Espaçamento, Bordas e Fundo

Nesta aula, você aprenderá sobre o **modelo de caixa (Box Model)** e as propriedades que definem o **espaçamento interno e externo**, **bordas** e **fundos** de cada elemento na página.

---

## 1. O Modelo de Caixa (Box Model)

No CSS, **cada elemento é tratado como uma caixa retangular**, composta por quatro camadas principais:

```
┌──────────────────────────────┐
│         margin               │  ← Margem (espaçamento externo)
│  ┌────────────────────────┐  │
│  │      border            │  │  ← Borda
│  │  ┌──────────────────┐  │  │
│  │  │    padding       │  │  │  ← Preenchimento interno
│  │  │  ┌────────────┐  │  │  │
│  │  │  │  content   │  │  │  │  ← Conteúdo (texto, imagem, etc.)
│  │  │  └────────────┘  │  │  │
│  │  └──────────────────┘  │  │
│  └────────────────────────┘  │
└──────────────────────────────┘
```

Cada uma dessas partes pode ser controlada por propriedades específicas do CSS.


## 2. Espaçamento Interno e Externo

### 2.1. Padding (Preenchimento Interno)

O `padding` define o **espaço entre o conteúdo e a borda** do elemento.  
Ele cria “respiro” dentro da caixa.

```css
div {
    padding: 20px;
}
```

💡 Dica: você pode definir cada lado separadamente:
```css
padding-top: 10px;
padding-right: 20px;
padding-bottom: 10px;
padding-left: 20px;
```

Ou usar a forma resumida:
```css
padding: 10px 20px; /* 10px em cima/baixo e 20px nas laterais */
```

---

### 2.2. Margin (Espaçamento Externo)

O `margin` define o **espaço entre o elemento e os outros ao redor**.  
É útil para separar seções e blocos na página.

```css
div {
    margin: 30px;
}
```

Assim como o `padding`, o `margin` também pode ser definido por lado:

```css
margin: 20px 10px 30px 10px; /* topo, direita, baixo, esquerda */
```

---

## 3. Bordas

As bordas (`border`) delimitam o contorno do elemento.  
Elas podem ter **largura**, **estilo** e **cor**.

### Exemplo básico:
```css
div {
    border: 2px solid black;
}
```

### Propriedades individuais:
```css
border-width: 2px;
border-style: solid;
border-color: black;
```

### Bordas arredondadas
Use `border-radius` para suavizar os cantos:
```css
div {
    border-radius: 10px;
}
```

---

## 4. Fundos

O CSS permite personalizar o **fundo dos elementos** com cores, imagens e padrões.

### 4.1. Cor de Fundo
```css
div {
    background-color: lightblue;
}
```

### 4.2. Imagem de Fundo
```css
div {
    background-image: url("imagem-fundo.png");
}
```

### 4.3. Repetição de Fundo
```css
background-repeat: no-repeat; /* não repete */
background-repeat: repeat-x; /* repete apenas na horizontal */
```

### *4.4. Posição do Fundo
```css
background-position: center; /* centraliza a imagem */
```

### 4.5. Tamanho do Fundo
```css
background-size: cover; /* cobre todo o elemento */
```

### 4.6. Forma resumida
```css
background: lightblue url("imagem.png") no-repeat center/cover;
```

