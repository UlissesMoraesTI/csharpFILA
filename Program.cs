Queue<int> fila = new Queue<int>();

fila.Enqueue(02);
fila.Enqueue(04);
fila.Enqueue(06);
fila.Enqueue(08);
fila.Enqueue(10);
fila.Enqueue(12);

foreach (int item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

foreach (int item in fila)
{
    Console.WriteLine(item);
}
