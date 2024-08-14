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
            chooseAction(operatorChoose);
        }


    }

    public static void chooseAction(int operatorChoose)
    {
        switch (operatorChoose)
        {
            case 1:
                addNewBook();
                break;
            case 2:
                listProducts();
                break;
            case 3:
                removeProduct();
                break;
            case 4:
                addStock();
                break;
            case 5:
                leftStock();
                break;
            case 0:
                Console.WriteLine("Volte sempre!");
                break;
        }
    }


    public static void addNewBook()
    {

        Console.WriteLine("Qual nome do livro?");
        String name = Console.ReadLine();

        Console.WriteLine("Qual preço do livro?");
        Double price = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Quem é o autor?");
        String author = Console.ReadLine();

        Console.WriteLine("Qual é o gênero?");
        String genre = Console.ReadLine();

        Console.WriteLine("Qual é a editora?");
        String editora = Console.ReadLine();

        Console.WriteLine("Quantas páginas tem?");
        int size = Convert.ToInt32(Console.ReadLine());

        int qtStock = 0;

        Book book = new Book(
            name,
            qtStock,
            price,
            author,
            genre,
            size,
            editora
        );

        Console.WriteLine($"O Livro {name} foi criado com sucesso!");

    }

    public static void listProducts()
    {
        List<Book> books = Book.listProduct();

        if (!books.Any())
        {
            Console.WriteLine("Não há livros adicionados!");
            return;
        }

        foreach (Book book in books)
        {
            Console.WriteLine(book);
        };

    }

    public static void addStock()
    {

        Console.WriteLine("Informe a posição do livro: ");
        int bookPosition = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe a quantidade de entrada: ");
        int bookQt = Convert.ToInt32(Console.ReadLine());

        Book.addStock(bookPosition - 1, bookQt);
    }

    public static void leftStock()
    {

        Console.WriteLine("Informe a posição do livro: ");
        int bookPosition = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe a quantidade de saída: ");
        int bookQt = Convert.ToInt32(Console.ReadLine());

        Book.leftStock(bookPosition - 1, bookQt);
    }

    public static void removeProduct()
    {
        Console.WriteLine("Informe a posição do livro: ");
        int bookPosition = Convert.ToInt32(Console.ReadLine());

        Book.removeBook(bookPosition - 1);

    }
}
