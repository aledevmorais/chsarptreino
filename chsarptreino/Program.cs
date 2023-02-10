using csharptreino.contas;
using csharptreino.titular;

//contaCorrente contadayvonne = new contacorrente();
//contadayvonne.titular = "yvonne strahovsky";
//contadayvonne.numero_agencia = 15;
//contadayvonne.conta = "007-x";
//contadayvonne.saldo = 1000;

//console.writeline("saldo da conta da yvonne strahovsky = " + contadayvonne.saldo);

//// tipagem por referencia duas contas mesmos valores mas com objetos diferentes na memoria pois
//// contadayvonne e contadayvonne2 tem enderecos de memoria diferentes

//contaCorrente contadayvonne2 = new contacorrente();
//contadayvonne2.titular = "yvonne strahovsky";
//contadayvonne2.numero_agencia = 15;
//contadayvonne2.conta = "007-x";
//contadayvonne2.saldo = 1000;

//console.writeline("saldo da conta da yvonne strahovsky = " + contadayvonne2.saldo);

//console.writeline(contadayvonne == contadayvonne2);
// return false pois cada objeto na memoria tem endereço unicos 
// a comparação é com endereço de memoria e não conteudo do objeto

//cliente contaPadrao = new cliente();

//contaPadrao.nome = "Alessandro";
//contaPadrao.cpf = "20030040056";
//contaPadrao.profissão = "analista";

//contaCorrente contaPadrao2 = new contaCorrente();

//contaPadrao2.titular = contaPadrao;
//contaPadrao2.conta = "1010-x";
//contaPadrao2.numero_agencia = 15;
//contaPadrao2.SetSaldo(100);
////a partir da mudanca para private eu não consigo atribuir valor a saldo fora classe

//Console.WriteLine("Titular   : " + contaPadrao2.titular.nome);
//Console.WriteLine("CPF       : " + contaPadrao2.titular.cpf);
//Console.WriteLine("Profissão : " + contaPadrao2.titular.profissão);
//Console.WriteLine("Conta N.  : " + contaPadrao2.conta);
//Console.WriteLine("Agencia N.: " + contaPadrao2.numero_agencia);

//contaCorrente conta3 = new contaCorrente();
//conta3.Numero_agencia = 18;
//conta3.Conta = "1011-H";

//Console.WriteLine("o numero da agencia é : " + conta3.Numero_agencia);
//Console.WriteLine("o numero da conta é : " +conta3.Conta);
//internamente o compilador do c# vai  criar em tempo de execução uma variavel 
//vai atribuir o get e o set "propriedade"
//Tenho compôs privados sendo acessos por métodos públicos ou propriedades públicas e autoimplementadas

contaCorrente conta4 = new contaCorrente();
conta4.SetSaldo(500);
conta4.Numero_agencia = 18;
conta4.Titular = new cliente();

Console.WriteLine(conta4.GetSaldo());
Console.WriteLine(conta4.Numero_agencia);

