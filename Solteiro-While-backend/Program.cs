// Entrada

//Faça um programa que leia e valide as seguintes informações:

// 1. Nome: diferente de vazio;

// 2. Idade: entre 0 e 100 anos;

// 3. Salário: maior que zero;

// 4. Estado Civil: 's'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd'(divorciado(a));onsole.WriteLine($"Bem vindo ao Aplicativo S0lt3ir0s.");

Console.WriteLine($"Bem vindo ao Aplicativo PotatoDate. Aqui você encontrará o seu PotetoPar perfeito :D");

Console.WriteLine($"Digite o seu nome");
string nome = Console.ReadLine();

while (nome == "")
{
    Console.WriteLine($"Digite um nome apropriado, se não você nunca irá encontar o seu Potato(a/e)");
    nome = Console.ReadLine();
}

Console.WriteLine($"Agora nos fale sua idade.");
int idade = int.Parse(Console.ReadLine());

while (idade <= 0 && idade >= 100)
{
    Console.WriteLine($"Porfavor digita uma idade apropriada ao aplicátivo");
    idade = int.Parse(Console.ReadLine());
}

while( idade <=17)
{
    Console.WriteLine($"O senhor não pode usar este app, digite uma idade apropriada");
    idade = int.Parse(Console.ReadLine());
}

Console.WriteLine($"Agora nos fale seu salário");
float salaraio = float.Parse(Console.ReadLine());

while (salaraio <= 0)
{
    Console.WriteLine($"Porfavor digita um salário apropriado");
    salaraio = float.Parse(Console.ReadLine());
}

Console.WriteLine(@$"

            NOS FALE O SEU ESTÁDO CEVIL
        -(S)Solteiro
        -(C)Casado
        -(D)Divorciado
        -(V)Viuvo 
");
char EC =char.Parse(Console.ReadLine().ToUpper());
while(EC != 'S' && EC !='C' && EC != 'D' && EC != 'V')
{
    Console.WriteLine(@$"
    A Letra que você escoheu está errada. ESCOLHA ENTRE 
    -S = SOLTEIRO(A) 
    -C = CASADA(O) 
    -D = DIVORCIADO(A) 
    -V = VIUVO(A)
    ");
    EC =char.Parse(Console.ReadLine().ToUpper());
}

Console.WriteLine($"Você é {nome}, tem {idade} anos, ganha {salaraio} e seu Estado civil é {EC}");
