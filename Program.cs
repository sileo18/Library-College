using PTI.Models;

namespace PTI;

class Program
{
    static void Main(string[] args)
    {
        int operatorChoose = 1;

        while (operatorChoose != 0)
        {

            Console.WriteLine("1 - Novo Livro\n" +
                    "2 - Listar Produtos\n" +
                    "3-  Remover Produtos\n" +
                    "4 - Entrada Estoque\n" +
                    "5 - Saída Estoque\n" +
                    "0 - Sair");
            Console.WriteLine("Escolha o que deseja fazer!");

            operatorChoose = Convert.ToInt32(Console.ReadLine());
            
            Operation.chooseAction(operatorChoose);
        }


    }


}
