using csharptreino;

contaCorrente contadaYvonne = new contaCorrente();
contadaYvonne.titular = "Yvonne Strahovsky";
contadaYvonne.numero_agencia = 15;
contadaYvonne.conta = "007-X";
contadaYvonne.saldo = 1000;

Console.WriteLine("Saldo da Conta da Yvonne Strahovsky = " + contadaYvonne.saldo);

// tipagem por referencia duas contas mesmos valores mas com objetos diferentes na memoria pois
// contadayvonne e contadaYvonne2 tem enderecos de memoria diferentes

contaCorrente contadaYvonne2 = new contaCorrente();
contadaYvonne2.titular = "Yvonne Strahovsky";
contadaYvonne2.numero_agencia = 15;
contadaYvonne2.conta = "007-x";
contadaYvonne2.saldo = 1000;

Console.WriteLine("Saldo da Conta da Yvonne Strahovsky = " + contadaYvonne2.saldo);

Console.WriteLine(contadaYvonne == contadaYvonne2);
// return false pois cada objeto na memoria tem endereço unicos 
// a comparação é com endereço de memoria e não conteudo do objeto









