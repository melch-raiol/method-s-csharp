using demo_video_11;

Console.WriteLine($"Digite o primeiro numero:");
int numeroUsuario = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Digite o segundo número numero:");
int numeroUsuario2 = Convert.ToInt32(Console.ReadLine());

int soma = Calculadora.CalcularSoma(numeroUsuario, numeroUsuario2, 30);
int subtracao = Calculadora.CalcularSubtracao(numeroUsuario, numeroUsuario2);
int multiplicacao = Calculadora.CalcularMultiplicacao(numeroUsuario, numeroUsuario2);
int divisao = Calculadora.CalcularDivisao(numeroUsuario, numeroUsuario2);

Console.WriteLine($"{numeroUsuario} + {numeroUsuario2} = {soma}");
Console.WriteLine($"{numeroUsuario} - {numeroUsuario2} = {subtracao}");
Console.WriteLine($"{numeroUsuario} x {numeroUsuario2} = {multiplicacao}");
Console.WriteLine($"{numeroUsuario} / {numeroUsuario2} = {divisao}");



