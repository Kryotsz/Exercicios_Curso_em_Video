// variável que armazena o número de caracteres do nome mais longo, que posteriormente será usada pra formatar o "Console.WriteLine"
int maior=0;

Console.WriteLine("------------------");
Console.WriteLine("CAMPEONATO FUTEBOL");
Console.WriteLine("------------------");

// array que armazena nomes de times de futebol
string[] times = new string[3];
// loop que lê os nomes e armazena no array
for(int i=0;i<3;i++){
    Console.Write("Nome do "+(i+1)+"° time: ");
    times[i]=Console.ReadLine();

    // variável que armazena o número de caracteres do nome do time
    int tamanho = times[i].Length;
    // compara qual o nome mais longo
    if(tamanho>maior){
        maior=tamanho;
    }
}

Console.WriteLine("------------------");
Console.WriteLine("TABELA DE PARTIDAS");
Console.WriteLine("------------------");

// loop que escreve todas as combinações de jogos possíveis
for(int i=0;i<3;i++){
    for(int j=0;j<3;j++){
        if(times[i]!=times[j]){
            // a variável é utilizada aqui pra formatar os espaços entre os nomes dos times e o placar
            Console.WriteLine(times[i].PadRight(maior)+" [ ] x [ ] "+times[j]);
        }
    }
}