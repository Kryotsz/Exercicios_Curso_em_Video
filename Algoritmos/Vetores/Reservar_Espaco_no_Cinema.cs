// variavel pra escolher a cadeira
int cadeira = 0;
// variavel de controle do loop
char continuar = 'S';
// array de cadeiras
string[] cadeirasDisponiveis = {"[B 1]", "[B 2]", "[B 3]", "[B 4]", "[B 5]", "[B 6]", "[B 7]", "[B 8]", "[B 9]", "[B 10]"};

do{
    // limpa o console
    Console.Clear();
    // mostra no console as opções de cadeiras que o usuário tem
    Console.WriteLine(cadeirasDisponiveis[0]+" "+cadeirasDisponiveis[1]+" "+cadeirasDisponiveis[2]+" "+cadeirasDisponiveis[3]+" "+
    cadeirasDisponiveis[4]+" "+cadeirasDisponiveis[5]+" "+cadeirasDisponiveis[6]+" "+cadeirasDisponiveis[7]+" "+cadeirasDisponiveis[8]+" "+cadeirasDisponiveis[9]);
    Console.WriteLine("-------------------------------------------");
    // lê a escolha de cadeira do usuário e armazena na variável
    Console.Write("Reservar a cadeira: B ");
    cadeira = int.Parse(Console.ReadLine());

    // se a cadeira escolhida estiver disponível
    if(cadeirasDisponiveis[cadeira-1]!="---"){
        // a cadeira é reservada e passa a se tornar indisponível
        Console.WriteLine("Cadeira [B "+cadeira+"] RESERVADA!");
        cadeirasDisponiveis[cadeira-1]="---";
    }else{
        // se não, mostra mensagem de erro
        Console.WriteLine("ERRO: Lugar Ocupado!");
    }
    // pergunta ao usuário se ele quer continuar reservando
    Console.Write("Quer reservar outra? [S/N]: ");
    continuar = char.Parse(Console.ReadLine().ToUpper().Trim());
}

// se o usuário escolher reservar outra cadeira, o loop continua
while(continuar=='S');
