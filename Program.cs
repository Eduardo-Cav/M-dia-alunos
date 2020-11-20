using System;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string [10];
            float[] nota1 = new float [10];
            float[] nota2 = new float [10];
            float[] nota3 = new float [10];
            float[] nota4 = new float [10];
            float[] media = new float [10];
            
            for (var i= 0; i < 10; i++)
            {
                Console.WriteLine("Digite o nome do aluno: ");
                nomes[i] = Console.ReadLine();
                Console.WriteLine("Digite a nota 1 do aluno: ");
                nota1[i] = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite a nota 2 do aluno: ");
                nota2[i] = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite a nota 3 do aluno: ");
                nota3[i] = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite a nota 4 do aluno: ");
                nota4[i] = float.Parse(Console.ReadLine());

                media[i] = (nota1[i] + nota2[i] + nota3[i] + nota4[i]) /4;
                
                if(media[i] > 7){
                        Console.WriteLine($"O aluno {nomes[i]} está aprovado e sua média é: {media[i]}");
                }else{
                    Console.WriteLine($"O aluno {nomes[i]} está reprovado e sua média é: {media[i]}");
                }

            }
               
                // for (var i = 0; i < 10; i++)
                // {
                //     if(media[i] > 7){
                //         Console.WriteLine($"O aluno {nomes[i]} está aprovado e sua média é: {media[i]}");
                //     }else{
                //         Console.WriteLine($"O aluno {nomes[i]} está reprovado e sua média é: {media[i]}");
                //     }
                // }  //caso for testar esse for apague o if e else acima
            
        }    
    }
}
