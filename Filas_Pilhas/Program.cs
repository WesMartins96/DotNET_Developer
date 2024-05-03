

//Coleções

//Fila - Queue - FIFO
Queue<int> fila = new Queue<int>();
//adicionar na fila
fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);
fila.Enqueue(10);

//remover da fila (sempre removerá o primeiro, respeitando a fila)
fila.Dequeue();

foreach (var item in fila)
{
    Console.WriteLine($"Fila: {item}");
}

Console.WriteLine();

//Pilha - Stack - LIFO
Stack<int> pilha = new Stack<int>();
//adicionar na pilha
pilha.Push(2);
pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);

//Remover da pilha (sempre removerá o ultimo, respeitando a pilha)
pilha.Pop();
foreach (var item in pilha)
{
    Console.WriteLine($"Pilha: {item}");
}

Console.WriteLine();

//Dictionary
Dictionary<string, string> estados = new Dictionary<string, string>();
//adicionar ao dictionary
estados.Add("SP", "São Paulo");
estados.Add("RJ", "Rio de Janeiro");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");

foreach (var item in estados)
{
    Console.WriteLine($"Dictionary: {item.Key} - {item.Value}");
}

Console.WriteLine();

//remover da dictionary (sempre removerá o valor pela chave informada)
estados.Remove("BA");

//alterar o valor no dictionary (alteração realizado pela key informada. [não é possivel alterar a key])
estados["SP"] = "Mauá[alterado com sucesso!]";

foreach (KeyValuePair<string, string> item in estados)
{
    Console.WriteLine($"Dictionary atualizado: {item.Key} - {item.Value}");
}