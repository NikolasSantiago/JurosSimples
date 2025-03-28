
double capital, tempo, juros, total;

Console.Clear();

Console.WriteLine("capital {c}______");
capital = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("juros {j} (%)______:");
juros = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("tempo {t}______");
tempo = Convert.ToDouble(Console.ReadLine());

juros = capital * (juros /100) * tempo;

total = capital + juros;

Console.WriteLine($"montante (R$)..: {total}");

