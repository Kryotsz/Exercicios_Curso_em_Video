int[] vetor = new int[10];

for(int i=0;i<10;i++){
    vetor[i]=int.Parse(Console.ReadLine());
}

for(int i=0;i<9;i++){
    for(int j=i+1;j<10;j++){
        if(vetor[i]>vetor[j]){
            int aux = vetor[i];
            vetor[i]=vetor[j];
            vetor[j]=aux;
        }
    }
}

for(int i=0;i<10;i++){
    Console.Write(vetor[i]+" ");
}