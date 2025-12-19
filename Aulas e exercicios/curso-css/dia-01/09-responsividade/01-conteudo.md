# Responsividade e Media Queries

Responsividade é a capacidade de uma página web se adaptar a diferentes tamanhos de tela e dispositivos, garantindo que o conteúdo seja exibido de forma legível e funcional em desktops, tablets e smartphones.

## 1. Por que a Responsividade é Importante
- Melhora a experiência do usuário.
- Aumenta a acessibilidade.
- Ajuda no SEO, já que mecanismos de busca valorizam sites responsivos.
- Evita que o layout quebre em telas menores ou maiores.

## 2. Conceito de Media Queries
As **media queries** permitem aplicar estilos CSS diferentes dependendo das características do dispositivo, como largura da tela, altura, orientação e resolução.

### Sintaxe
```css
@media (condição) {
    /* estilos aplicados quando a condição é verdadeira */
}
```

### Exemplo

```css
/* Estilo padrão para desktop */
body {
    font-size: 16px;
}

/* Estilo para telas menores que 768px (tablets e smartphones) */
@media (max-width: 768px) {
    body {
        font-size: 14px;
    }
}
```

## 3. Condições Comuns em Media Queries

* `max-width`: aplica estilos quando a largura da tela é menor ou igual ao valor definido.
* `min-width`: aplica estilos quando a largura da tela é maior ou igual ao valor definido.
* `orientation`: detecta se o dispositivo está em modo retrato (`portrait`) ou paisagem (`landscape`).

### Exemplo com múltiplas condições

```css
@media (max-width: 768px) and (orientation: portrait) {
    body {
        font-size: 13px;
    }
}
```

## 4. Boas Práticas

* Evite definir tamanhos fixos; prefira unidades relativas como `%`, `em`, `rem`, `vh` e `vw`.
* Teste sempre em diferentes dispositivos e resoluções.
