using att_aula_02;
// using att_aula_02._09;

// ////////////////////////1///////////////////////////

// Calculadora calculadora = new Calculadora();

// Console.WriteLine("Entre com o valor A");
// double A = double.Parse(Console.ReadLine());

// Console.WriteLine("Entre com o valor B");
// double B = double.Parse(Console.ReadLine());

// calculadora.CalculoMais(A,B);
// calculadora.CalculoSub(A,B);
// calculadora.CalculoDiv(A,B);
// calculadora.CalculoMult(A,B);


// ///////////////////////////////////////////////////

// Console.WriteLine("Entre com um numero ");
// double numero = double.Parse(Console.ReadLine());

// double dobro = numero + numero;
// double triplo = numero + numero + numero;

// Console.WriteLine($"O dobro de {numero} é: {dobro}, o triplo de {numero } é {triplo}");


// /////////////////////////////////////////////////////

// Console.WriteLine("Qual seu nome?");
// string N = Console.ReadLine();

// Console.WriteLine($"Olá {N}!, é um prazer te conhecer. ");



// /////////////////////////////////////////////////

// Console.WriteLine("Entre com a idade");
// int idade = int.Parse(Console.ReadLine());

// int calc = idade + 10;

// Console.WriteLine($"Daqui a 10 anos tera {calc} anos");




/////////////////////// 2 /////////////////////////////


// Console.WriteLine("Entre com um número");
// int Num = int.Parse(Console.ReadLine());

// if(Num % 2 == 0)
// {
//     Console.WriteLine($"O numero {Num} é par");
// }
// else
// {
//     Console.WriteLine($"O numero {Num} é impar");
// }


// ////////////////////////////////////////////

// Console.WriteLine("Entre com valor X ");
// double X = double.Parse(Console.ReadLine());

// Console.WriteLine("Entre com valor Y ");
// double Y = double.Parse(Console.ReadLine());

// if(X > Y)
// {
//     Console.WriteLine($"O valor {X} é maior");
// }
// else if(X < Y)
// {
//     Console.WriteLine($"O valor {Y} é maior");
// }
// else
// {
//     Console.WriteLine("Os valores são iguais");
// }


// //////////////////////////////////////////////////

// Console.WriteLine("Qual a mota do aluno?");
// double NotaA = double.Parse(Console.ReadLine());

// if(NotaA >= 7)
// {
//     Console.WriteLine("Aprovado");
// }
// else if ( NotaA >4 && NotaA <7)
// {
//     Console.WriteLine("Recuperação");
// }
// else
// {
//     Console.WriteLine("Reprovado");
// }

////////////////////////////////////////////////////////


// Console.WriteLine("Digite a idade");
// int idade = int.Parse(Console.ReadLine());

// if (idade < 18)
// {
//     Console.WriteLine("Menor de idade");
// }
// else if (idade < 60)
// {
//     Console.WriteLine("Adulto");
// }
// else
// {
//     Console.WriteLine("Idoso");
// }


///////////////////////////////////////////////////////

// Console.WriteLine("Entre com um numero");
// double numero = double.Parse(Console.ReadLine());

// if (numero > 0)
// {
//     Console.WriteLine($"O Número {numero} é positivo");
// }
// else if (numero < 0)
// {
//     Console.WriteLine($"O Número {numero} é negativo");
// }
// else
// {
//     Console.WriteLine($"O Numero {numero} é igual a zero");
// }


////////////////////////// 3 /////////////////////////////////

// for(int i = 0; i < 11; i++)
// {
//     Console.WriteLine("Os numeros são : " + i);
// }


///////////////////////////////////////////////////////////////

// for(int i = 0; i < 51; i++)
// {
//     if(i %2 == 0)
//     {
//         Console.WriteLine("Os pares são  " + i);
//     }
// }


/////////////////////////////////////////////////////////////

// Console.WriteLine("entre com um valor");
// int valor = int.Parse(Console.ReadLine());

// for(int i = 0; i < 11; i++)
// {
//     Console.WriteLine($"O valor na tabuada do {valor} é: {valor*i}");
// }


///////////////////////////////////////////////


// Console.WriteLine("Insira 5 valores:");
// Console.WriteLine("valor um:");
// int v1 = int.Parse(Console.ReadLine());
// Console.WriteLine("valor dois: ");
// int v2 = int.Parse(Console.ReadLine());
// Console.WriteLine("valor tres: ");
// int v3 = int.Parse(Console.ReadLine());
// Console.WriteLine("valor quatro: ");
// int v4 = int.Parse(Console.ReadLine());
// Console.WriteLine("valor cinco: ");
// int v5 = int.Parse(Console.ReadLine());

// if (v1 > 0) Console.WriteLine(v1);
// if (v2 > 0) Console.WriteLine(v2);
// if (v3 > 0) Console.WriteLine(v3);
// if (v4 > 0) Console.WriteLine(v4);
// if (v5 > 0) Console.WriteLine(v5);








////////////////////////////////4//////////////////////////////////////

// Console.WriteLine("Entre com o primeiro numero");
//  double n1 = double.Parse(Console.ReadLine());

//  Console.WriteLine("entre com o segundo numero");
//  double n2 = double.Parse(Console.ReadLine());


//  Console.WriteLine("escolha uma operação:");
//  Console.WriteLine("1 - Adição");
//  Console.WriteLine("2 - Subtração");
//  Console.WriteLine("3 - Multiplicação");
//  Console.WriteLine("4 - Divisão");
//  int opcao = int.Parse(Console.ReadLine());


//   double resultado = 0;


//  switch (opcao)
//  {
//      case 1 :
//      resultado = n1 + n2;
//      Console.WriteLine("o resultado é " + resultado);
//     break;

//     case 2 : 
//     resultado = n1 - n2;
//        Console.WriteLine("o resultado é " + resultado);
//      break;

//      case 3 :
//     resultado = n1 * n2;
//          Console.WriteLine("o resultado é " + resultado);
//     break;

//     case 4 :
//     resultado = n1 / n2;
//         Console.WriteLine("o resultado é " + resultado);
//     break;

//      default:
//      Console.WriteLine("opção Invalida");
//      break;
//  }



//////////////////////////////////////////////////////


// Console.WriteLine("Escolha um numero para coreesponder a um dia da semana");
// int semana = int.Parse(Console.ReadLine());

// int opcao = 0;
// switch (semana)
// {
//     case 1 : 
//     opcao = 1;
//     Console.WriteLine("O dia da semana é segunda feira");
//     break;

//     case 2 :
//     opcao = 2;
//     Console.WriteLine("O dia da semana é terça feira");
//     break;

//     case 3 :
//     opcao = 3;
//     Console.WriteLine("O dia da semana é quarta feira");
//     break;

//     case 4 :
//     opcao = 4;
//     Console.WriteLine("O dia da semana é quinta feira");
//     break;

//     case 5 :
//     opcao = 5;
//     Console.WriteLine("O dia da semana é sexta feira");
//     break;

//     case 6 :
//     opcao = 6;
//     Console.WriteLine("O dia da semana é sabado");
//     break;

//     case 7 :
//     opcao = 7;
//     Console.WriteLine("O dia da semana é domingo");
//     break;

//     default : 
//     Console.WriteLine("Opção invalida");
//     break;

// }


/////////////////////////////////////////////////////////////

// Console.WriteLine("Escolha um numero até 3 para escolher o setor de produdos");
// int numero = int.Parse(Console.ReadLine());

// int opcao = 0;
// switch (numero)
// {
//     case 1 :
//     Console.WriteLine("O setor é alimento");
//     break;

//     case 2 :
//     Console.WriteLine("O setor é bebida");
//     break;

//     case 3 :
//     Console.WriteLine("O setor é limpeza");
//     break;
// }



///////////////////////////5////////////////////////////////

// double soma = 0;
// double maior = 0;

// for (int i = 1; i <= 10; i++)
// {
//     Console.Write($"Digite o {i}º número: ");
//     double numero = double.Parse(Console.ReadLine());

//     soma = soma + numero;

//     if(i == 1 || numero > maior)
//     {
//         maior = numero;
//     }
//     double media = soma / 10;

//     Console.WriteLine("A soma é :" + soma);
//     Console.WriteLine("A media é :" + media);
//     Console.WriteLine("O maior numero é :" + maior);

// }





////////////////////////////////////////////////////////////////

// Console.WriteLine("Entre com as idades");
// int idades = int.Parse(Console.ReadLine());

// int soma = 0;
// int contador = 0;

// while(idades >= 0)
// {
//     soma = soma + idades;
//     contador++;

//     idades = int.Parse(Console.ReadLine());
    
// }
// int media = soma / contador;
// if(contador > 0)
// {
//     Console.WriteLine("A media é : " + media);
// }


/////////////////////////////////////////////////

// int contador1 = 0;
// int contador2 = 0;

// for(int i = 0; i < 10; i++)
// {

//     Console.WriteLine("Entre com 10 numeros");
//     int N = int.Parse(Console.ReadLine());
    

//     if( N %2 == 0)
//     {
//         contador1++;
//     }
//     else
//     {
//         contador2++;
//     }
//     Console.WriteLine("Numeros pares:" + contador1);
//     Console.WriteLine("NUmeros impares:" + contador2);

// }



/////////////////////// DESAFIO ////////////////////


////////////////////
// Console.WriteLine("Entre com um numero");
// int primo = int.Parse(Console.ReadLine());

// if (primo %==1 || primo %primo == primo )
///////////////////////////////////////






// Console.WriteLine("Entre com um valor");
// int valor = int.Parse(Console.ReadLine());
// int soma = 0;
// int contador = 1;

// for (int i = valor;i >= 1; i--)
// {
//     contador *= i;
   
// }

//  Console.WriteLine("O valor é:" + contador);



///////////////////////////////////////////

// Console.WriteLine("Ente com a senha");
// int senha = int.Parse(Console.ReadLine());

// int contador = 0;

// if(senha == 1234)
// {
//     Console.WriteLine("Logado");
// }
// else
// {
//     while(senha != 1234)
//     {
//         contador++;
//         Console.WriteLine("NEgado,tente novamente");
//         senha = int.Parse(Console.ReadLine());
    
//     if(contador == 3)
//     {
//         break;
//     }
// }
// if(contador == 3)
// {
//     Console.WriteLine("Acesso negado");
// }
//     else
//     {
//         Console.WriteLine("Acesso liberado");
//     }
// }

// Console.WriteLine("Entre com o saldo");
// double saldo = double.Parse(Console.ReadLine());

// Console.WriteLine("Quanto deseja sacar?");
// double saque = double.Parse(Console.ReadLine());

// if (saldo > saque)
// {
//     Console.WriteLine("Saque aprovado");
// }
// else
// {
//     Console.WriteLine("Saque negado,você nao tem saldo suficiente");
// }


//////////////////////////////////////////


