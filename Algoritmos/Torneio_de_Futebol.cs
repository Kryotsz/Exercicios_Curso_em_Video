// variavel de controle de tamanho que posteriormente será usada na formatação do Console.WriteLine
int maior=0;

Console.WriteLine("------------------");
Console.WriteLine("CAMPEONATO FUTEBOL");
Console.WriteLine("------------------");

// array pra armazenas nome dos times
string[] times = new string[3];
// loop pra ler o nome dos times e adicionar no array
for(int i=0;i<3;i++){
    Console.Write("Nome do "+(i+1)+"° time: ");
    times[i]=Console.ReadLine();
    
    // variavel pra armazenar o numero de caracteres do nome do time
    int tamanho = times[i].Length;
    // comparação pra estabelecer qual nome é maior
    if(tamanho>maior){
        maior=tamanho;
    }
}

Console.WriteLine("------------------");
Console.WriteLine("TABELA DE PARTIDAS");
Console.WriteLine("------------------");

// loop pra escrever na tela todas as combinações de jogos possíveis
for(int i=0;i<3;i++){
    for(int j=0;j<3;j++){
        if(times[i]!=times[j]){
            Console.WriteLine(times[i].PadRight(maior)+" [ ] x [ ] "+times[j]);
        }
    }
}
