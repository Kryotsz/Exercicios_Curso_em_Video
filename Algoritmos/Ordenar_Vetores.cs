// cria um array pra armazenar números inteiros em qualquer ordem
int[] vetor = new int[10];
// preenche o array com os números digitados pelo usuário
for(int i=0;i<10;i++){
    vetor[i]=int.Parse(Console.ReadLine());
}

// organiza o array de forma crescente
for(int i=0;i<9;i++){
    for(int j=i+1;j<10;j++){
        if(vetor[i]>vetor[j]){
            int aux = vetor[i];
            vetor[i]=vetor[j];
            vetor[j]=aux;
        }
    }
}

// escreve na tela o array que agora está em ordem crescente
for(int i=0;i<10;i++){
    Console.Write(vetor[i]+" ");
}
