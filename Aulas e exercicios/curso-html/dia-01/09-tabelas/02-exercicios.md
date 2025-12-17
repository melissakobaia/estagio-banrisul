## **Exercício: Tabela**
Atualmente, a seção "Benefícios" exibe uma lista simples de vantagens em formato de `<ul>`. Substitua essa lista por uma tabela HTML, organizando as informações de forma mais estruturada.

### **Instruções:**
- Substitua o elemento `<ul>` por um elemento `<table>`.
- A tabela deve conter:
    - Um cabeçalho (`<thead>`) com duas colunas: uma para o nome do benefício e outra para os detalhes;
    - Um corpo (`<tbody>`) com três linhas, descrevendo os principais benefícios da conta digital.
- A tabela deve ter o conteúdo e formato abaixo:  


| **Benefício**    | **Detalhes e Vantagens**                                                                       |
| -------------------------- | ---------------------------------------------------------------------------------------------- |
| **Custo Zero**             | Sem taxas de manutenção e sem tarifas escondidas no seu dia a dia.                             |
| **Acesso Imediato**        | Acesso 24/7 (24 horas por dia, 7 dias por semana) para gerenciar tudo pelo aplicativo.         |
| **Segurança e Velocidade** | Transferências rápidas e seguras, com a garantia do nosso sistema de proteção. |

### Dica:
Após construir a tabela, insira a tag `<style>` abaixo dentro da tag `<head>` do seu HTML, para visualizar melhor a estrutura dos dados.

```html
<style>
    table {
        width: 100%;
        border-collapse: collapse; /* Remove espaços entre as bordas */
    }
    th, td {
        border: 1px solid black; /* Define a borda */
        padding: 8px; /* Adiciona espaço interno */
        text-align: left; /* Alinha o texto à esquerda */
    }
    th {
        background-color: #f2f2f2; /* Cor de fundo para cabeçalhos */
    }
</style>
```
