
namespace PTI.Models;
using System.Collections.Generic;
public class Book : Item
{

    private String author { get; set; }
    private String genre { get; set; }
    private int size { get; set; }

    private String editora;
    private static List<Book> books = new List<Book>();

    public Book(String name, int qtStock, Double price, String autor, String genre, int size, String editora)
        : base(name, qtStock, price)
    {
        this.editora = editora;
        this.author = autor;
        this.genre = genre;
        this.size = size;
        addItem();
    }

    public void SetStock(int qtAdd)
    {
        base.SetStock(qtAdd);
    }

    public int GetStock()
    {
        return base.GetStock();
    }

    public Double GetPrice()
    {
        return base.GetPrice();
    }

    public void addItem()
    {
        books.Add(this);
    }

    public static List<Book> listProduct()
    {
        return books;
    }

    public override string ToString()
    {
        return "\n\nName: " + base.GetName() + " (" + GetPrice() + ") - " + GetStock() + " no estoque" +
        "\nAuthor:" + author + "\n";
    }

    public static void createBook()
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

    public static void addStock()
    {

        Console.WriteLine("Informe a posição do livro: ");
        int bookPosition = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe a quantidade de entrada: ");
        int bookQt = Convert.ToInt32(Console.ReadLine());

        Book book = books[bookPosition - 1];

        book.SetStock(bookQt);

        Console.WriteLine(book.GetName() + "\nNova quantidade estoque: " + book.GetStock());
    }

    public static void leftStock()
    {
        Console.WriteLine("Informe a posição do livro: ");
        int bookPosition = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe a quantidade de saída: ");
        int bookQt = Convert.ToInt32(Console.ReadLine());

        Book book = books[bookPosition - 1];

        book.SetStock(-bookQt);

        Console.WriteLine(book.GetName() + "\nNova quantidade estoque: " + book.GetStock());
    }

    public static void removeBook()
    {
        Console.WriteLine("Informe a posição do livro: ");
        int bookPosition = Convert.ToInt32(Console.ReadLine());

        books.RemoveAt(bookPosition - 1);

        Console.WriteLine("Livro removido com sucesso!");
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

}

