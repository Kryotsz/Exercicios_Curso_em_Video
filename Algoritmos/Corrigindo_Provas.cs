Console.WriteLine("PASSO 1 - Cadastro de Gabarito");
Console.WriteLine("------------------------------");

// cria um array pra guardar o gabarito com as respostas corretas
string[] gabarito = new string[5];

// loop pra formular o gabarito
for(int i=0;i<5;i++){
    Console.Write("Questão "+(i+1)+": ");
    gabarito[i]=Console.ReadLine();
}

// cria um array pra guardar o nome dos alunos
string[] alunos = new string[3]; 
// cria um array pra armazenar as notas dos alunos
double[] notas = new double[3];

// loop pra ler as informações dos alunos
for(int i=0;i<3;i++){
    Console.WriteLine("------------------------------");
    Console.WriteLine("ALUNO "+(i+1));
    Console.WriteLine("------------------------------");

    // le o nome do aluno e adiciona no array
    Console.Write("Nome: ");
    alunos[i] = Console.ReadLine();

    Console.WriteLine("RESPOSTAS DADAS");

    // cria um array pra guardar o gabarito do aluno
    string[] gabaritoAluno = new string[5];

    // loop pra ler as respostas do aluno e adicionar no gabarito
    for(int j=0;j<5;j++){
        Console.Write("Questão "+(j+1)+": ");
        gabaritoAluno[j] = Console.ReadLine();
    }

    // cria uma variável pra contar os acertos de cada aluno
    int acertos=0;
    // loop pra comparar gabaritos e contar acertos
    for(int j=0;j<5;j++){
        if(gabarito[j]==gabaritoAluno[j]){
            acertos+=1;
        }
    }

    // calcula a nota do aluno e adiciona no array "notas"
    notas[i] = (acertos*10.0)/5.0;
}

Console.WriteLine("------------------------------");
Console.WriteLine("NOTAS FINAIS");
Console.WriteLine("------------------------------");

// loop pra escrever os nomes e notas dos alunos
for(int i=0;i<3;i++){
    Console.WriteLine(alunos[i].PadRight(10)+" "+notas[i].ToString("F1"));
}

// cria uma variável pra armazenar a soma das notas
double soma=0;
// loop pra somar as notas
for(int i=0;i<3;i++){
    soma+=notas[i];
}
// cria uma variável pra armazenar a média da turma
double media = soma/3.0;

Console.WriteLine("------------------------------");
Console.WriteLine("Média da Turma: "+media.ToString("F1"));