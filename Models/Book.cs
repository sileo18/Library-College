
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

    public Double GetPrice() {
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
        return "\n\nName: " + base.GetName() + " (" + GetPrice() + ") - " +  GetStock() + " no estoque" + 
        "\nAuthor:" + author + "\n";
    }

    public static void addStock(int bookPosition, int bookQt)
    {
        Book book = books[bookPosition];

        book.SetStock(bookQt);

        Console.WriteLine(book.GetName() + "\nNova quantidade estoque: " + book.GetStock());
    }

    public static void leftStock(int bookPosition, int bookQt)
    {
        Book book = books[bookPosition];

        book.SetStock(-bookQt);

        Console.WriteLine(book.GetName() + "\nNova quantidade estoque: " + book.GetStock());
    }

    public static void removeBook(int bookPosition) {

        books.RemoveAt(bookPosition);

        Console.WriteLine("Livro removido com sucesso!");
    }

}

