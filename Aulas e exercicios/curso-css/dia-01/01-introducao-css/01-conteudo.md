# Introdução ao CSS

Agora que você já aprendeu a estruturar uma página utilizando HTML, chegou o momento de aprender como **estilizar** seus conteúdos e deixá-los visualmente atraentes. Enquanto o HTML cuida da **estrutura** e do **conteúdo**, o CSS cuida do **design** e da **experiência visual** do usuário. Eles trabalham juntos para criar páginas completas e bem apresentadas. 

## O que é CSS?
CSS, ou Cascading Style Sheets (Folhas de Estilo em Cascata), é uma linguagem de estilização utilizada para descrever a apresentação de documentos escritos em HTML ou XML. Ele foi criado para possibilitar a separação entre o conteúdo (HTML) e a apresentação (CSS), promovendo uma maior flexibilidade e eficiência no desenvolvimento de páginas web.

Através do CSS, é possível controlar vários aspectos visuais dos elementos HTML, como cores, espaçamentos, fontes, tamanhos e layout geral da página. Com CSS, desenvolvedores conseguem criar páginas visualmente atraentes e responsivas, o que melhora a experiência do usuário e facilita o processo de manutenção do site.

## Vantagens do CSS
- **Separação de Conteúdo e Estilo**: Com CSS, o conteúdo HTML fica mais organizado e sem estilos embutidos, permitindo que a apresentação da página seja gerida em arquivos externos.
- **Reutilização de Código**: As regras CSS podem ser aplicadas a múltiplos elementos e páginas, economizando tempo e esforço.
- **Manutenção Facilitada**: Alterar o estilo em um único arquivo CSS reflete automaticamente em todas as páginas que o utilizam.
- **Compatibilidade com Diferentes Dispositivos**: Com CSS, é possível criar páginas responsivas, adaptáveis a diferentes resoluções e tamanhos de tela.

## Sintaxe Básica do CSS
A estrutura de uma regra CSS é composta por um **seletor**, uma **propriedade** e um **valor**.

```css
seletor {
    propriedade: valor;
}
```

- **Seletor**: Define o elemento ou grupo de elementos HTML ao qual as regras serão aplicadas.
- **Propriedade**: Especifica qual aspecto visual será modificado (como cor, tamanho da fonte, espaçamento).
- **Valor**: Define a configuração da propriedade (por exemplo, `color: red` define que a cor do texto será vermelha).

Exemplo:
```css
p {
    color: blue;
    font-size: 16px;
}
```
No exemplo acima, todas as tags `<p>` no HTML terão texto na cor azul e tamanho de fonte 16 pixels.

## Formas de Incluir CSS
O CSS pode ser inserido de três maneiras em um documento HTML: **inline**, **interno** e **externo**.

1. **CSS Inline**:
   Definido diretamente no elemento HTML usando o atributo `style`. Este método é menos recomendado, pois diminui a organização e dificulta a manutenção.

   ```html
   <p style="color: blue; font-size: 16px;">Texto com estilo inline</p>
   ```

2. **CSS Interno**:
   Inserido dentro da tag `<style>` no `<head>` do HTML. Ideal para estilos exclusivos de uma página específica.

   ```html
   <head>
       <style>
           p {
               color: blue;
               font-size: 16px;
           }
       </style>
   </head>
   ```

3. **CSS Externo**:
   Utiliza um arquivo CSS separado e vinculado ao HTML através da tag `<link>`. Esta é a maneira mais recomendada de usar CSS, pois permite reutilização de estilos em múltiplas páginas.

   ```html
   <head>
       <link rel="stylesheet" href="estilos.css">
   </head>
   ```
   Conteúdo do arquivo `estilos.css`:
   ```css
   p {
       color: blue;
       font-size: 16px;
   }
   ```