Console.WriteLine("Números em C#!");

int maxInteger = int.MaxValue;
int minInteger = int.MinValue;
System.Console.WriteLine($"Inteiros tem valor mínimo = {minInteger} e valor máximo = {maxInteger}");

double maxDouble = double.MaxValue;
double minDouble = double.MinValue;
System.Console.WriteLine($"Double tem valor mínimo = {minDouble} e valor máximo = {maxDouble}");

decimal maxDecimal = decimal.MaxValue;
Decimal minDecimal = decimal.MinValue;
System.Console.WriteLine($"Decimal tem valor mínimo = {minDecimal} e valor máximo = {maxDecimal}");

System.Console.WriteLine("O range do double é maior que o decimanl");

System.Console.WriteLine($"Tamanhos em bytes de inteiro {sizeof(int)}, double {sizeof(double)}, e decimal {sizeof(decimal)}");

double numeradorDouble = 1.0;
double denominadoDouble = 3.0;
double divisaoDouble = numeradorDouble/denominadoDouble;

decimal numeradorDecimal= 1.0M;
decimal denominadorDecimal = 3.0M;
decimal divisaoDecimal = numeradorDecimal/denominadorDecimal;

System.Console.WriteLine($"A precisao do decimal {divisaoDecimal} é maior que a do double {divisaoDouble}");