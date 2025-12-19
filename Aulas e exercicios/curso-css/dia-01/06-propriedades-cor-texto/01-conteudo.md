# Propriedades de Cor, Texto e Fonte

Agora que você já conhece os seletores CSS, é hora de começar a **personalizar a aparência dos elementos**.  
Nesta aula, você aprenderá a controlar **cores, fontes e o estilo do texto**, aspectos fundamentais para deixar suas páginas mais agradáveis e legíveis.

---

## 1. **Propriedades de Cor**

A cor pode ser aplicada tanto ao **texto** quanto ao **fundo** de um elemento.

### **Cor do texto (`color`)**

```css
p {
    color: blue;
}
```

Você pode usar:

- **Nomes de cores**: `red`, `blue`, `green`
- **Hexadecimal**: `#FF0000`
- **RGB**: `rgb(255, 0, 0)`
- **RGBA** (com transparência): `rgba(255, 0, 0, 0.7)`

### **Cor de fundo (`background-color`)**

```css
body {
    background-color: #f2f2f2;
}
```


---

## 2. **Propriedades de Texto**

O CSS oferece várias propriedades para ajustar o texto e melhorar sua legibilidade.

| Propriedade | Função | Exemplo |
|--------------|--------|----------|
| `text-align` | Alinha o texto | `text-align: center;` |
| `text-decoration` | Adiciona ou remove decorações (sublinhado, linha sobreposta etc.) | `text-decoration: underline;` |
| `text-transform` | Controla letras maiúsculas/minúsculas | `text-transform: uppercase;` |
| `line-height` | Define o espaçamento entre linhas | `line-height: 1.5;` |
| `letter-spacing` | Define o espaçamento entre letras | `letter-spacing: 2px;` |

### **Exemplo**

```css
h1 {
    text-align: center;
    text-transform: uppercase;
    letter-spacing: 3px;
}
```

---

## 3. **Propriedades de Fonte**

A escolha da fonte influencia diretamente a identidade visual e a legibilidade do site.

| Propriedade | Função | Exemplo |
|--------------|--------|----------|
| `font-family` | Define a fonte do texto | `font-family: Arial, sans-serif;` |
| `font-size` | Define o tamanho da fonte | `font-size: 18px;` |
| `font-weight` | Define a espessura (negrito) | `font-weight: bold;` |
| `font-style` | Define o estilo (itálico, normal) | `font-style: italic;` |

### **Exemplo Completo**

```css
p {
    font-family: "Roboto", sans-serif;
    font-size: 16px;
    font-weight: 400;
    color: #333;
}
```

> 💡 **Dica:**  Sempre use fontes seguras ou fontes importadas via Google Fonts para garantir que o texto seja exibido corretamente em todos os dispositivos.

---

## 4. **Combinando Propriedades**

Veja como essas propriedades podem ser usadas juntas para criar um estilo agradável:

```css
body {
    background-color: #f9f9f9;
    color: #333;
    font-family: "Open Sans", sans-serif;
    line-height: 1.6;
}

h1 {
    color: #173AEB;
    text-align: center;
    text-transform: uppercase;
}

p {
    font-size: 16px;
    letter-spacing: 0.5px;
}
```
