int cadeira = 0;
char continuar = 'S';
string[] cadeirasDisponiveis = {"[B 1]", "[B 2]", "[B 3]", "[B 4]", "[B 5]", "[B 6]", "[B 7]", "[B 8]", "[B 9]", "[B 10]"};

do{
    Console.Clear();
    Console.WriteLine(cadeirasDisponiveis[0]+" "+cadeirasDisponiveis[1]+" "+cadeirasDisponiveis[2]+" "+cadeirasDisponiveis[3]+" "+
    cadeirasDisponiveis[4]+" "+cadeirasDisponiveis[5]+" "+cadeirasDisponiveis[6]+" "+cadeirasDisponiveis[7]+" "+cadeirasDisponiveis[8]+" "+cadeirasDisponiveis[9]);
    Console.WriteLine("-------------------------------------------");
    Console.Write("Reservar a cadeira: B ");
    cadeira = int.Parse(Console.ReadLine());

    if(cadeirasDisponiveis[cadeira-1]!="---"){
        Console.WriteLine("Cadeira [B "+cadeira+"] RESERVADA!");
        cadeirasDisponiveis[cadeira-1]="---";
    }else{
        Console.WriteLine("ERRO: Lugar Ocupado!");
    }

    Console.Write("Quer reservar outra? [S/N]: ");
    continuar = char.Parse(Console.ReadLine().ToUpper().Trim());
}

while(continuar=='S');
