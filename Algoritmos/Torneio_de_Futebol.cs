int maior=0;

Console.WriteLine("------------------");
Console.WriteLine("CAMPEONATO FUTEBOL");
Console.WriteLine("------------------");

string[] vetor = new string[3];

for(int i=0;i<3;i++){
    Console.Write("Nome do "+(i+1)+"° time: ");
    vetor[i]=Console.ReadLine();

    int tamanho = vetor[i].Length;
    if(tamanho>maior){
        maior=tamanho;
    }
}

Console.WriteLine("------------------");
Console.WriteLine("TABELA DE PARTIDAS");
Console.WriteLine("------------------");

for(int i=0;i<3;i++){
    for(int j=0;j<3;j++){
        if(vetor[i]!=vetor[j]){
            Console.WriteLine(vetor[i].PadRight(maior)+" [ ] x [ ] "+vetor[j]);
        }
    }
}