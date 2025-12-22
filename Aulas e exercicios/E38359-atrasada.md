NOTA FINAL - 4.05

1) estrutura do projeto 0.4/0.5
- Identificador: 0.1 -> 0.0 usou 01 nos testes
- Solution:      0.2 -> 0.2
- Estrutura:     0.2 -> 0.2

2) TO 1.5/1.5
 - Tipagem:               0.4 (0.05/item) -> 0.4
 - Mapeamento de retorno: 0.4 (0.05/item) -> 0.4
 - Enum:                  0.4 -> 0.4
 - Wrapper:               0.3 (0.04 nas primeiras 6, 0.03 nas últimas  -> 0.3

3) Camada Q 1.6/2.0
 - - Obs: Se query falta/adiciona algo de coluna ou filtro, zera montagem da query.
 - Inserir: 0.65/0.65 (0.3 montagem da query + 0.1 do retorno + 0.25 SAC) 

 - Alterar: 0.35/0.65 (0.3 montagem da query + 0.1 do retorno + 0.25 SAC)
Usou this.MontarSet(toConta), permitindo alterar todos os campos

 - Listar:  0.25/0.35 (0.1 montagem da query + 0.1 do retorno + 0.15 Alias)
Usou this.MontarWhere(toConta, "CON."), permitindo filtrar por todos os campos

 - Obter:   0.35/0.35 (0.1 montagem da query + 0.1 do retorno + 0.15 Alias)


4) Camada S 0.3/3.0
 - - Obs Funcionalidade: Se teste passar, ponto ganho.
 - - Obs Validação: N testes por regra (marcadas com * nas regras das US's).

 - US1 Funcionalidade: x/0.4
 - - TC01 

 - US2 Funcionalidade: x/0.2
 - - TC39 e TC41

 - US3 Funcionalidade: x/0.2 
 - - TC45 

 - US4 Funcionalidade: x/0.4
 - - TC75 

 - US1 Validação:      x/0.3 
 - - R1 0.03 -> () TC15
 - - R2 0.03 -> () TC03, TC05, TC07, TC09, TC11, TC13 
 - - R3 0.03 -> () TC27
 - - R4 0.03 -> () TC17, TC19 TC21, TC23, TC25
 - - R6 0.03 -> () TC33
 - - R7 0.03 -> () TC31, T111 
 - - R8 0.03 -> () T107
 - - R10 0.03 -> () TC35
 - - R11 0.03 -> () T109
 - - R12 0.03 -> () TC37

 - US2 Validação:      x/0.15 
 - - R1 0.075 -> () TC39, TC41, TC43
 - - R2 0.075 -> () TC113

 - US3 Validação:     x/0.15 
 - - R1 0.03 -> () TC59
 - - R2 0.03 -> () TC47, TC49, TC51, TC53, TC55, TC57
 - - R3 0.03 -> () TC71
 - - R4 0.03 -> () TC61, TC63, TC65, TC67, TC69
 - - R5 0.03 -> () TC114
 
 - US4 Validação:    x/0.3
 - - R1 0.05 -> () TC89
 - - R2 0.05 -> () TC77, TC79, TC81, TC83, TC85, TC87 
 - - R3 0.05 -> () TC101
 - - R4 0.05 -> () TC89, TC91, TC93, TC95, TC97, TC99
 - - R5 0.05 -> () TC103
 - - R6 0.05 -> () valiadar cod operador na mão


 - Mapa de mensagens:  0.3/0.3 (ter a classe de mensagens herdando Mensagem e com um objeto Enum de TipoMensagem, estando junto com a classe de camada S)

 - US1 Mensagem:     0.0/0.2 
 - - CA2 0.03 -> () TC16 
 - - CA3 0.03 -> () TC04, TC06, TC08, TC10, TC12, TC14  
 - - CA4 0.02 -> () TC28 
 - - CA5 0.02 -> () TC18, TC20, TC22, TC24, TC26
 - - CA6 0.02 -> () TC30
 - - CA7 0.02 -> () TC34 
 - - CA8 0.02 -> () TC32
 - - CA9 0.02 -> () TC36
 - - CA10 0.02 -> () TC38 

 - US2 Mensagem:      x/0.1 
 - - CA3 0.1 -> () TC44, TC42
 
 - US3 Mensagem:      x/0.1
 - - CA2 0.02 -> () TC60 
 - - CA3 0.02 -> () TC48, TC50, TC52, TC54, TC56, TC58 
 - - CA4 0.02 -> () TC72 
 - - CA5 0.02 -> () TC62, TC64, TC66, TC68, TC70 
 - - CA6 0.02 -> () TC74 

 - US4 Mensagem:       x/0.2
 - - CA2 0.04 -> () TC90
 - - CA3 0.032 -> () TC78, TC80, TC82, TC84, TC86, TC88 
 - - CA4 0.032 -> () TC102 
 - - CA5 0.032 -> () TC90, TC92, TC94, TC96, TC98, TC100 
 - - CA6 0.032 -> () TC104 
 - - CA7 0.032 -> () TC106 

5) Camada U 0.25/3.0 (comparar as validações e mensagens do gabarito aula com as validações deles)  não fez testes
 - US1 Caminho feliz:     x/0.7 (tem que ter todos os asserts do gabarito aula) 

 - US2 Caminho feliz:     x/0.25 (tem que ter todos os asserts do gabarito aula)


 - US3 Caminho feliz:     x/0.25 (tem que ter todos os asserts do gabarito aula) 


 - US4 Caminho feliz:     x/0.7 (tem que ter todos os asserts do gabarito aula) 


 - US1 Mensagem de falha: x/0.3 
 - - CA2 0.04 -> () 
 - - CA3 0.0325 -> () 
 - - CA4 0.0325 -> () 
 - - CA5 0.0325 -> () 
 - - CA6 0.0325 -> () 
 - - CA7 0.0325 -> () 
 - - CA8 0.0325 -> () 
 - - CA9 0.0325 -> () 
 - - CA10 0.0325 -> () 

 - US2 Mensagem de falha: x/0.15 
 - - CA3 0.15 -> ()

 - US3 Mensagem de falha: x/0.15 
 - - CA2 0.03 -> ()
 - - CA3 0.03 -> () 
 - - CA4 0.03 -> () 
 - - CA5 0.03 -> () 
 - - CA6 0.03 -> () 

 - US4 Mensagem de falha: x/0.25 
 - - CA2 0.05 -> () 
 - - CA3 0.04 -> ()
 - - CA4 0.04 -> ()
 - - CA5 0.04 -> ()
 - - CA6 0.04 -> ()
 - - CA7 0.04 -> ()

 - mock de grátis:        0.25/0.25