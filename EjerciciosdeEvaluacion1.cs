
static void Procesar(List<int> lote, int contador)
{
    lote.Add(contador);
    contador ++;
    lote =new List<int> {0};
    lote.Add(contador);
}

List<int> piezas = new List<int> {5};
int n=1;

Procesar(piezas, n);

Console.WriteLine(n);
Console.WriteLine(string.Join(",", piezas));


