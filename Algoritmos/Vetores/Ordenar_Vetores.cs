// array que armazena números inteiros em qualquer ordem
int[] vetor = new int[10];
// loop que lê números inteiros e armazena no array na ordem em que foram lidos
for(int i=0;i<10;i++){
    vetor[i]=int.Parse(Console.ReadLine());
}

// loop que ordena o array em ordem crescente
for(int i=0;i<9;i++){
    for(int j=i+1;j<10;j++){
        if(vetor[i]>vetor[j]){
            int aux = vetor[i];
            vetor[i]=vetor[j];
            vetor[j]=aux;
        }
    }
}
// loop que mostra no console o array já ordenado em ordem crescente
for(int i=0;i<10;i++){
    Console.Write(vetor[i]+" ");
}