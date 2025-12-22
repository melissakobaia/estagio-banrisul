# Avaliação: Gestão de contas bancárias

## Problema

Você precisa criar uma aplicação MM4 para a gestão de contas bancárias, compreendendo toda a parte operacional de criação, consultas e atualização de contas bancárias. A deleção não é permitida — logo não será desenvolvida.

As user stories disponibilizadas pelo time de negócio são as seguintes:

```gherkin
US1 - Inclusão de nova conta bancária

Como um analista financeiro
Eu quero incluir uma nova conta bancária informando número da agência, número da conta e cliente associado
Para que o sistema mantenha um cadastro oficial e padronizado de contas bancárias

Regras
    - *O número da agência é obrigatório e deve conter de 3 a 4 dígitos numéricos de 100 a 9999 (mudança de dígitos de 4 para 3 a 4 REVISAR DEPOIS)
    - *O número da conta é obrigatório e deve conter até 9 dígitos numéricos de 1 até 999999999 (mudança de dígitos para 9 pois não percebemos que o limite real era de 2.147.483.647 REVISAR DEPOIS)
    - A combinação de número de agência e número de conta deve ser única na base
    - *O saldo inicial é obrigatório e deve ser maior ou igual a 0 (zero)
    - O código do cliente é obrigatório e é representado pelo seu respectivo CNPJ (remoção do CPF pois as anotações validação se contradiziam REVISAR DEPOIS)
    - *O CPF/CNPJ do cliente deve ser válido perante cálculos de dígito verificador (não é necessária a verificação prévia de existência do cliente na base de dados)
    - *O tipo de pessoa é obrigatório e deve aceitar apenas "F" (física) ou "J" (jurídica)
    - A situação é obrigatória e deve ser sempre "A" (ativa) no momento da inclusão
    - O operador é obrigatório e deve ser sempre preenchido com a matrícula do usuário logado no momento da inclusão
    - A data de última atualização é obrigatória e deve ser sempre preenchida com a data data/hora atual no momento da inclusão

Critérios de Aceitação

    - Dado que informo um número de agência válido, um número de conta válido, um CPF/CNPJ de cliente válido, um tipo de pessoa válido e um saldo inicial válido (maior ou igual a zero), sendo que não existe na base de dados uma conta bancária com a mesma combinação de números de agência e conta, então a aplicação inclui a nova conta bancária com situação "A", preenche o código do operador de acordo com usuário logado, e a data de atualização com a data/hora atuais
    -* Dado que o número da agência não é informado ou está fora do intervalo numérico esperado, então a aplicação rejeita a inclusão com a mensagem "Um número válido de agência deve ser informado (entre 1000 e 9999)."
    -* Dado que o número da conta não é informado ou está fora do intervalo numérico esperado, então a aplicação rejeita a inclusão com a mensagem "Um número válido de conta deve ser informado (entre 1 e 9999999999)."
    -* Dado que já existe uma conta bancária com a mesma combinação de números de agência e conta, então a aplicação rejeita a inclusão com a mensagem "Já existe na base de dados uma conta bancária com a combinação de número de agência e número de conta informados."
    -* Dado que o saldo inicial não é informado ou está fora do intervalo numérico esperado, então a aplicação rejeita a inclusão com a mensagem "Um saldo válido deve ser informado (não negativo)."
    -* Dado que o código do cliente informado é inválido (referente aos cálculos de dígito verificador de CPF e CNPJ), então a aplicação rejeita a inclusão com a mensagem "Um CPF/CNPJ válido deve ser informado." (faltou adicionar a regra que deve retornar o mesmo erro ao campo não ser informado)
    -* Dado que o tipo de pessoa informado é diferentes das opções possíveis, então a aplicação rejeita a inclusão com a mensagem "Um tipo de pessoa válido deve ser informado ('F' para pessoa física ou 'J' para pessoa jurídica)." (faltou adicionar a regra que deve retornar o mesmo erro ao campo não ser informado)
```

```gherkin
US2 - Listagem de contas bancárias

Como um gerente de agência
Eu quero visualizar a lista completa de contas bancárias cadastradas
Para apoiar consultas operacionais, análises financeiras e auditorias internas

Regras
    -* A listagem deve retornar as contas cadastradas de acordo com os critérios de filtragem (todos opcionais), que podem ser uma composição de:
        - Número da agência
        - Número da conta
    -* O número da agência é obrigatório e deve conter de 3 a 4 dígitos numéricos de 100 a 9999
    -* O número da conta é obrigatório e deve conter até 9 dígitos numéricos de 1 até 999999999
        - CPF/CNPJ do cliente
        - Tipo de pessoa do cliente
        - Situação
    -* A listagem deve exibir para cada conta bancária:
        - Número da agência
        - Número da conta
        - Saldo
        - CPF/CNPJ do cliente
        - Tipo de pessoa do cliente
        - Situação
        - Operador da última atualização
        - Data/hora da última atualização

Critérios de Aceitação
    - Dado que solicito a listagem sem nenhum critério de filtragem informado, se houver contas bancárias cadastradas, então a aplicação retorna todas as contas bancárias cadastradas com as informações esperadas
    - Dado que solicito a listagem com um set de critérios informado, se houver contas bancárias cadastradas para os critérios informados, então a aplicação retorna as devidas contas bancárias cadastradas com as informações esperadas
    -* Dado que solicito a listagem sem nenhum critério de filtragem informado e não há contas bancárias cadastradas, então a aplicação rejeita a consulta com a mensagem "Não existem contas bancárias cadastradas."
```

```gherkin
US3 - Consulta de conta bancária

Como um gerente de agência
Eu quero consultar os dados completos de uma conta bancária específica
Para validar informações em operações internas, auditorias e conferências periódicas de dados

Regras
    -* A consulta deve ser realizada exclusivamente pelo critério de filtragem da combinação obrigatória de:
        - Número da agência
        - Número da conta
    -* O número da agência é obrigatório e deve conter de 3 a 4 dígitos numéricos de 100 a 9999
    -* O número da conta é obrigatório e deve conter até 9 dígitos numéricos de 1 até 9999999999
    -* A consulta deve exibir para a conta bancária:
        - Número da agência
        - Número da conta
        - Saldo
        - CPF/CNPJ do cliente
        - Tipo de pessoa do cliente
        - Situação
        - Operador da última atualização
        - Data/hora da última atualização

Critérios de Aceitação
    - Dado que informo um número de agência válido e um número de conta válido, e existe na base de dados uma conta bancária correspondente, então a aplicação retorna os dados completos da conta com as informações esperadas
    -* Dado que o número da agência não é informado ou está fora do intervalo numérico esperado, então a aplicação rejeita a consulta com a mensagem "Um número válido de agência deve ser informado (entre 1000 e 9999)."
    -* Dado que o número da conta não é informado ou está fora do intervalo numérico esperado, então a aplicação rejeita a consulta com a mensagem "Um número válido de conta deve ser informado (entre 1 e 9999999999)."
    -* Dado que não existe uma conta bancária com a mesma combinação de números de agência e conta informados, então a aplicação rejeita a consulta com a mensagem "Não existe uma conta bancária cadastrada para os critérios informados."
```

```gherkin
US4 - Alteração de situação de conta bancária

Como um analista financeiro
Eu quero alterar a situação de uma conta bancária específica
Para manter o cadastro atualizado conforme bloqueios, ativações e suspensões operacionais

Regras
    -* A alteração deve ser realizada exclusivamente pelo critério de filtragem da combinação obrigatória de:
        - Número da agência
        - Número da conta
    -* O número da agência é obrigatório e deve conter de 3 a 4 dígitos numéricos de 100 a 9999
    -* O número da conta é obrigatório e deve conter até 9 dígitos numéricos de 1 até 999999999
    -* A situação é o único campo permitido para alteração, e deve aceitar apenas:
        - "A" (ativa)
        - "I" (inativa)
        - "S" (suspensa)
    -* O operador é obrigatório e deve ser sempre atualizado com a matrícula do usuário logado no momento da alteração
    -* A data de última atualização é obrigatória e deve ser sempre atualizada com a data data/hora atual no momento da alteração

Critérios de Aceitação
    - Dado que informo um número de agência válido, um número de conta válido e uma situação válida ("A", "I" ou "S"), e existe na base de dados uma conta bancária correspondente, então a aplicação altera a situação da conta bancária, o código do operador de acordo com usuário logado e a data de atualização com a data/hora atuais
    - Dado que o número da agência não é informado ou está fora do intervalo numérico esperado, então a aplicação rejeita a alteração com a mensagem "Um número válido de agência deve ser informado (entre 1000 e 9999)."
    - Dado que o número da conta não é informado ou está fora do intervalo numérico esperado, então a aplicação rejeita a alteração com a mensagem "Um número válido de conta deve ser informado (entre 1 e 9999999999)."
    - Dado que a nova situação informada não corresponde aos valores permitidos, então a aplicação rejeita a alteração com a mensagem "Uma situação válida deve ser informada ('A' para conta ativa, 'I' para inativa e 'S' para suspensa)."
    - Dado que não existe uma conta bancária com a mesma combinação de números de agência e conta informados, então a aplicação rejeita a alteração com a mensagem "Não existe uma conta bancária cadastrada para os critérios informados."
```

## Estrutura de Dados

Modelagem já efetuada e pronta no **IBM DB2**:

```sql
SELECT
    AGENCIA           -- DECIMAL(4,0)   NN PK
  , CONTA             -- DECIMAL(10,0)  NN PK
  , SALDO             -- DECIMAL(15,2)  NN
  , IND_SITUACAO      -- CHAR(1)        NN
  , COD_CLIENTE       -- CHAR(14)       NN FK(PXC.CLIENTE_PXC)
  , IND_TP_PESSOA     -- CHAR(1)        NN FK(PXC.CLIENTE_PXC)
  , COD_OPERADOR      -- CHAR(6)        NN
  , ULT_ATUALIZACAO   -- TIMESTAMP      NN
FROM PXC.CONTA;
```

## Informações Adicionais

- Além da operação _Excluir_ , as operações _Contar_ e _Imprimir_ também **não precisam ser desenvolvidas**;
- O _identificador curto para o TO_ de contas é **"cn"**;
- Os dados de cliente a serem utilizados para cenários de teste em geral devem ser:
  - CPNJ: **"43977980000190"**;
  - Tipo: **"J"**.
  ![Registro cliente](./_assets/01-registro-cliente.png)

## Objetivos

- Criação do projeto de **TOs**
  - Deve tratar corretamente o mapeamento dos devidos _enums_ para tipo de pessoa do cliente e situação
- Criação do projeto de **camada Q:**
  - Deve conter o controle por _alias_
  - Deve conter o controle de _SAC_
- Criação do projeto de **camada S:**
  - Todas as regras contidas nas user stories devem ser satisfeitas
  - Deve conter o objeto de mapa de mensagens
  - Deve retornar para os devidos cenários, mensagens idênticas às definidas nos critérios de aceitação das user stories
- Criação do projeto de **camada U:**
  - Todos os critérios de aceitação contidos nas user stories devem ser atendidos por testes (não é necessária a entrega de casos de teste)
  - As devidas mensagens retornadas da camada S devem ser validadas de acordo com os critérios de aceitação contidos nas user stories
  - Deve conter o objeto mock com ao menos 1 teste de exceção com dependência "mockada"
- É necessária a agregação de todos os projetos na **solução padrão** (arquivo .sln)

## Entrega

A entrega será feita via upload da pasta completa `PXC` compactada (em `.zip` ou `.rar` de preferência) dentro da pasta de avaliação disponibilizada no espaço da aula.

Utilize como nome do arquivo o padrão `Avaliação-MM4-[matrícula]` ex.: `Avaliação-MM4-T07007`.

Lembrando que uma aplicação usual deve seguir um padrão estrutural semelhante a este:

```makefile
PXC\
|
├── pxcbtoxn\                         # Pasta do projeto - TOs
├── pxcqcnxn_Conta\                   # Pasta do projeto - Camada Q
├── pxcscnxn_Conta\                   # Pasta do projeto - Camada S
├── pxcucnxn_TestesAutomatizados\     # Pasta do projeto - Camada U
└── pxckcfxn.sln                      # Arquivo .NET da solução
```

Boa sorte e bom trabalho!
