namespace condicionais;

class Program
{
    static void Main(string[] args)
    {
        // int numero = -297;

        // if (numero>0)
        // {
        //     Console.WriteLine("O número é positivo");
        // }

        // Console.WriteLine("O número é negativo");

        // Console.WriteLine("Digite um número");
        // int numero = int.Parse(Console.ReadLine());

        // if(numero>0)
        // {
        //     Console.WriteLine("Positivo");
        // }
        // else if (numero == 0)
        // {
        //     Console.WriteLine("O número é zero");
        // }
        // else
        // {
        //     Console.WriteLine("O número é negativo");
        // }

        // Console.Write("Digite sua idade: ");
        // int idade = int.Parse(Console.ReadLine());

        // if(idade<16)
        // {
        //     Console.WriteLine("Não pode votar");
        // }
        // else if(idade <18)
        // {
        //     Console.WriteLine("Voto opcional");
        // }
        // else
        // {
        //     Console.WriteLine("Voto obrigatório");
        // }

        //   Console.Write("Digite sua nota: ");
        //   double nota = double.Parse(Console.ReadLine());

        //   if(nota>=7)
        //   {
        //     Console.WriteLine("Aprovado!");

        //     if(nota>=9)
        //     {
        //         Console.WriteLine("Aprovado e ganhou estrelinha");
        //     }
        //   }
        //   else if(nota>=5)
        //   {
        //     Console.WriteLine("Recuperação");
        //   }
        //   else 
        //   {
        //     Console.WriteLine("Reprovado");
        //   }

        // int n1 = 35;
        // int n2 = 5;
        
        // if(n1>n2){
        //     Console.WriteLine("Primeiro é maior");
        // }
        // else if(n2>n1){
    
        //     Console.WriteLine("Segundo é maior");
        // }
        // else{
        //     Console.WriteLine("IGUAIS");
        // }

        // Console.Write("Usuário: ");
        // string usuario = Console.ReadLine();

        // Console.Write("Senha: ");
        // string senha = Console.ReadLine();

        // if(usuario == "admin" && senha == "1234")
        // {
        //     Console.WriteLine("Usuário logado");
        // }
        // else
        // {
        //     Console.WriteLine("Acesso Negado");
        // }

        // Console.Write("Digite um número: ");
        // int numero = int.Parse(Console.ReadLine());

        // If ternário:
        // string resultado = numero % 2 == 0 ? "Par" : "Impar";
        // Console.WriteLine(resultado);


        // If simples:
        // if(numero % 2 == 0)
        // {
        //     Console.WriteLine("Par");
        // }
        // else
        // {
        //     Console.WriteLine("Impár");
        // }

        // int idade = 12;
        // Console.WriteLine(idade>=18 ? "Maior de idade" : "Menor de idade");


        // Switch Case
        // Console.WriteLine("Digite um número de 1 a 3: ");
        // int opcao = int.Parse(Console.ReadLine());

        // switch(opcao)
        // {
        //     case 1:
        //         Console.WriteLine("Você escolheu a opção 1");
        //         break;

        //     case 2:
        //         Console.WriteLine("Você escolheu a opção 2");
        //         break;

        //     case 3:
        //         Console.WriteLine("Você escolheu a opção 3");
        //         break;
            
        //     default:
        //         Console.WriteLine("Opção inválida!!!!");
        //         break;
        // }

        Console.WriteLine("Digite uma opção: (A, B ou C)");
        string escolha = Console.ReadLine().ToUpper();

        switch(escolha)
        {
            case "A": 
                Console.WriteLine("Você escolheu a opção A.");
                break;
            case "B":
                Console.WriteLine("Você escolheu a opção B");
                break;
            case "C":
                Console.WriteLine("Você escolheu a opção C");
                break;
            default:
                Console.WriteLine("inválida");
                break;
        }
    }
}