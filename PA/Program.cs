//Renan Bezerra Fernandes Morato
int a1 = 10; // Ataque inicial
int r = 5;   // Ganho por nível
int n = 20;  // Nível desejado

int an = a1 + (n - 1) * r;

Console.WriteLine("O ataque no nível " + n + " será: " + an);

