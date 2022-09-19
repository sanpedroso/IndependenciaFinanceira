decimal gastosMensais, valorAInvestir;
double dividendYield;

Console.WriteLine("---Vivendo de Dividendos---\n");

Console.Write("Gastos mensais (em R$)....: ");
gastosMensais = Convert.ToDecimal(Console.ReadLine());

Console.Write("Rendimento mensais (%)...: ");
dividendYield = Convert.ToDouble(Console.ReadLine());

valorAInvestir = gastosMensais / Convert.ToDecimal(dividendYield / 100);

Console.WriteLine($"\nPara receber {gastosMensais:C} por mês com rendimenrto de {dividendYield:N1}% voçê precisa ter investido {valorAInvestir:C}.");

