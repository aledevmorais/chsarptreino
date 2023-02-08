﻿using csharptreino.contas;
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

cliente contaPadrao = new cliente();

contaPadrao.nome = "Alessandro";
contaPadrao.cpf = "20030040056";
contaPadrao.profissão = "analista";

contaCorrente contaPadrao2 = new contaCorrente();

contaPadrao2.titular = contaPadrao;
contaPadrao2.conta = "1010-x";
contaPadrao2.numero_agencia = 15;
contaPadrao2.saldo = 100;

Console.WriteLine("Titular   : " + contaPadrao2.titular.nome);
Console.WriteLine("CPF       : " + contaPadrao2.titular.cpf);
Console.WriteLine("Profissão : " + contaPadrao2.titular.profissão);
Console.WriteLine("Conta N.  : " + contaPadrao2.conta);
Console.WriteLine("saldo     : " + contaPadrao2.saldo);
Console.WriteLine("Agencia N.: " + contaPadrao2.numero_agencia);
