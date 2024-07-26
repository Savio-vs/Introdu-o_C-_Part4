/*
//Usar as propriedades MinValue e MaxValue para cada tipo integral com sinal
Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

//Usar as propriedades MinValue e MaxValue para cada tipo integral sem sinal
Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

//Usar as propriedades MinValue e MaxValue para cada tipo de float com sinal
Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
*/
/*
//o vetor faturamento será iniciado com 34 valores aleatorios para representar os calculos , os dias com 0 foi considerado como domingo e sem faturamento.

decimal[] faturamento = {1695,3234,9067,5303,1185,0,3888,7861,6691,3775,0,6178,2720,3305,4187,7667,0,1387,5573,6151,7387,6621,
8531,0,234,4327,3347,3023,116,7689,0,4214,6551,4830};

//ignorar os valores com 0 de faturamento para saber o menor faturamento:
var ignorarZero = faturamento.Where(a => a != 0);
Console.WriteLine($"Menor faturamento: {ignorarZero.Min()}");
Console.WriteLine($"Maior faturamento: {faturamento.Max()}");

decimal mediaAnual =(decimal) (ignorarZero.Sum() / ignorarZero.Count());

Console.WriteLine($"Média anual de faturamento: {Math.Round(mediaAnual,4)}");
int dias = 0;

for (int i = 0;i<faturamento.GetLength(0);i++){
    if (faturamento[i]>mediaAnual){
        dias++;
    }
}
Console.WriteLine($"Dias que superaram a media anual: {dias}");
*/
/*

//função padrão:
static int CalcularValores(int valor1, int valor2)
{ 
    return  valor1 + valor2;
}

//Alteração da função CalcularValores:
static void CalcularValores2(int valor1, int valor2)
{ 
    Console.WriteLine($"Soma: {valor1+valor2}\nMultiplicação: {valor1*valor2}");
    
}

Console.WriteLine($"Soma dos dois valores: {CalcularValores(17,23)}");

CalcularValores2(17,23);    
*/
/*
int somaNumImpar =0;

for (int i = 100; i <= 200;i++){
    if (i % 2 != 0)
    {   Console.WriteLine(i);
        somaNumImpar +=i ;
    }
}
Console.WriteLine($"Soma dos números impares entre 100 e 200: {somaNumImpar}");
*/
/*
int indice=13,soma=0,k=0;

while (k<indice)
{
    k+=1;
    Console.WriteLine("valor de k "+k);
    soma+=k;
    Console.WriteLine("valor de soma "+soma);
}
Console.WriteLine(soma);
*/

//using System.Numerics;
/*
string[] values = { "12,3", "45", "ABC", "11", "DEF" };
decimal total = 0m;
decimal num ;
string frase ="" ;
foreach (var value in values)
{
    if (decimal.TryParse(value,out num)){
        total+= num;
        
    }
    else
    {
        frase += value;
        
    }
}

Console.WriteLine($"Caracteres concatenados: {frase}");
Console.WriteLine($"Inteiros somados: {total}");
*/
/*
int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

// The Convert class is best for converting the fractional decimal numbers into whole integer numbers
// Convert.ToInt32() rounds up the way you would expect.
int result1 = Convert.ToInt32(value1 / value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
*/
// >>>>Criar uma matriz de paletes, depois classificá-los
/*
string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
*/
// >>> Função Clear.
/*
string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets, 0, 2); //para limpar os valores armazenados nos elementos da matriz pallets, começando no índice 0 e limpando os 2 elementos.
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
*/

// >>> Redimensionar a matriz para adicionar mais elementos
/*
string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
*/
// >>> Escrever código para inverter cada palavra de uma mensagem
/*
string pangram = "The quick brown fox jumps over the lazy dog";

string [] palavras = pangram.Split(' ');
foreach (string palavra in palavras)
{   
    char[] ch = palavra.ToCharArray();
    Array.Reverse(ch);
    string palavraReverse = new string(ch);
    Console.Write(palavraReverse+" ");
}
*/
//>>>  Concluir um desafio em que é preciso analisar uma cadeia de caracteres de pedidos, classificá-los e marcar possíveis erros
/*
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] idProduto = orderStream.Split(",");
Array.Sort(idProduto);
for (int i = 0;i< idProduto.Length;i++)
{
   
    if (idProduto[i].Length == 4)
    {
        Console.WriteLine($"{idProduto[i]}");
    }else
    {
        Console.WriteLine($"{idProduto[i]}\t- Erro");
    }
}
*/
// >>> Metodos string
/*
Métodos que adicionam espaços em branco para fins de formatação (PadLeft(), PadRight())
Métodos que comparam duas cadeias de caracteres ou facilitam a comparação (Trim(), TrimStart(), TrimEnd(), GetHashcode(), a propriedade Length)
Métodos que ajudam a determinar o que há dentro de uma cadeia de caracteres ou até mesmo recuperar apenas uma parte da cadeia de caracteres (Contains(), StartsWith(), EndsWith(), Substring())
Métodos que alteram o conteúdo da cadeia de caracteres substituindo, inserindo ou removendo partes (Replace(), Insert(), Remove())
Métodos que transformam uma cadeia de caracteres em uma matriz de cadeias de caracteres ou de caracteres (Split(), ToCharArray())
*/
/*
string input = "Pad this";
Console.WriteLine(input.PadLeft(12));
Console.WriteLine(input.PadLeft(12,'-'));
Console.WriteLine(input.PadLeft(12,'-'));

string paymentId = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);

Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);

// >>>> Desafio
string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");

Console.WriteLine($"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.\n");

Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be ¤{newProfit:N2}.\n");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = string.Format($"Magic Yield         {currentReturn:P2}   {currentProfit:C} \nGlorious Future     {newReturn:P2}   {newProfit:C}");



Console.WriteLine(comparisonMessage);


*/
/*
string message = "Find what is (inside the parentheses)";
// Identificar qual a posição dos parenteses em message.
int openingPosition = message.IndexOf('('); 
int closingPosition = message.IndexOf(')');

openingPosition+=1;
int length = closingPosition - openingPosition; // o +1 faz com que os parenteses sejam ignorados na hora de saber o tamanho da frase entre parentese.
//imprimir somento o que estiver entre os parenteses de message.
Console.WriteLine(message.Substring(openingPosition, length));
*/

// Recuperar a última ocorrência de uma subcadeia de caracteres
/*
string message = "(What if) I am (only interested) in the last (set of parentheses)?";
int openingPosition = message.LastIndexOf('(');

openingPosition += 1;
int closingPosition = message.LastIndexOf(')');
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));
*/

//Recuperar todas as instâncias de subcadeias de caracteres dentro de parênteses
/*
string message = "(What if) there are (more than) one (set of parentheses)?";
while (true)
{
    int openingPosition = message.IndexOf('(');// se o caractere não for achado IndexOf retornará -1.
    if (openingPosition == -1) break;

    openingPosition += 1;
    int closingPosition = message.IndexOf(')');
    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));

    // Note the overload of the Substring to return only the remaining 
    // unprocessed message:
    message = message.Substring(closingPosition + 1);
}
*/

// Trabalhar com diferentes tipos de conjuntos de símbolos
/*
string message = "Help (find) the {opening symbols}";
Console.WriteLine($"Searching THIS Message: {message}");
char[] openSymbols = { '[', '{', '(' };
int startPosition = 5;
//Pesquise com .IndexOfAny() para retornar o índice do primeiro símbolo da matriz openSymbols encontrada na cadeia de caracteres message.
int openingPosition = message.IndexOfAny(openSymbols);
Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

openingPosition = message.IndexOfAny(openSymbols, startPosition);
Console.WriteLine($"Found WITH using startPosition {startPosition}:  {message.Substring(openingPosition)}");

*/

// >>> Desafio: extrair, substituir e remover os dados de uma cadeia de caracteres de entrada

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

int startPosition = input.IndexOf("<span>");
startPosition +=6;
int endPosition = input.IndexOf("</span>");
int length = endPosition - startPosition;

string quantity = input.Substring(startPosition, length);

startPosition = input.IndexOf("<h2>");
length = (endPosition + 7) - startPosition;
string output = input.Substring(startPosition, length);

// Your work here

Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output}");