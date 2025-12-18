## **HTML Semântico**
Agora que você já conhece sobre divisões e containers de conteúdo, é hora de dar um passo além e aprender como deixar suas páginas mais estruturadas e compreensíveis.

---

### **1. O que é HTML Semântico**
O HTML semântico utiliza tags que descrevem o significado do conteúdo, ao invés de apenas a aparência. Diferente de `<div>`, que é uma tag genérica, as tags semânticas ajudam a organizar melhor o documento, melhorando:

- **Acessibilidade**: leitores de tela entendem melhor a página.
- **SEO**: motores de busca interpretam corretamente o conteúdo.
- **Manutenção**: facilita identificar seções do site e ajuda desenvolvedores a manterem o código mais legível e organizado.

---

### **2. Principais Tags Semânticas**
| Tag | Função |
|------|--------|
| `<header>` | Representa o cabeçalho da página ou de uma seção. Pode conter logo, título ou menu. |
| `<main>` | Contém o conteúdo principal da página. Deve haver apenas um por documento. |
| `<section>` | Define uma seção temática de conteúdo. |
| `<article>` | Representa um conteúdo independente, como uma notícia ou post. |
| `<aside>` | Conteúdo lateral ou complementar, como barras de anúncios ou widgets. |
| `<footer>` | Indica o rodapé da página ou de uma seção. |
| `<nav>` | Área de navegação, geralmente menus de links. |

---

### 3. Estrutura semântica de uma página
```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <title>Exemplo de Página Semântica</title>
</head>
<body>

<header>
    <h1>Meu Site Semântico</h1>
    <nav>
        <ul>
            <li><a href="#home">Início</a></li>
            <li><a href="#sobre">Sobre</a></li>
            <li><a href="#contato">Contato</a></li>
        </ul>
    </nav>
</header>

<main>
    <section id="home">
        <h2>Bem-vindo</h2>
        <p>Esta é a seção principal da página.</p>
    </section>

    <section id="sobre">
        <h2>Sobre Nós</h2>
        <article>
            <h3>Nossa História</h3>
            <p>Um breve resumo da empresa.</p>
        </article>
        <article>
            <h3>Nossa Missão</h3>
            <p>Descrição da missão.</p>
        </article>
    </section>
</main>

<footer>
    <p>Todos os direitos reservados © 2025</p>
</footer>

</body>
</html>

```

### 4. Quando usar `<div>` e quando usar elementos semânticos?

Mesmo com as tags semânticas, a tag `<div>` continua sendo útil! Ela é ideal quando o conteúdo não se encaixa em uma tag semântica específica, mas ainda precisa ser agrupado para organização ou estilização com CSS.

Ou seja, use `<div>` quando o agrupamento for apenas estrutural, e tags semânticas quando o conteúdo tiver significado.