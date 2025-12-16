let nome = "Mel";
let sobrenome = "Schmidt";

console.log(`Nome completo: ${nome} ${sobrenome}`);

let inicialNome = nome.charAt(0).toUpperCase();
let inicialSobrenome = sobrenome.charAt(0).toUpperCase();

let contagemTotal = nome.length + sobrenome.length;

console.log("Iniciais e contagem: " + inicialNome + "." + inicialSobrenome + " (" + contagemTotal + ")");

//Nome Secreto

const pontoCorteNome = Math.ceil(nome.length / 2);
const primeiraMetadeNome = nome.slice(0, pontoCorteNome);

const pontoCorteSobrenome = Math.floor(sobrenome.length / 2);
const segundaMetadeSobrenome = sobrenome.slice(pontoCorteSobrenome);

const nomeSecreto = primeiraMetadeNome + segundaMetadeSobrenome;

console.log(`Nome secreto: ${nomeSecreto}`);