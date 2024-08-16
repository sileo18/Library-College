using PTI.Models;

namespace PTI;

class Operation
{
    public static void chooseAction(int operatorChoose)
    {
        switch (operatorChoose)
        {
            case 1:
                Book.createBook();
                break;
            case 2:
                Book.listProducts();
                break;
            case 3:
                Book.removeBook();
                break;
            case 4:
                Book.addStock();
                break;
            case 5:
                Book.leftStock();
                break;
            case 0:
                Console.WriteLine("Volte sempre!");
                break;
        }
    }
}