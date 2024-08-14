namespace PTI.Models;

public abstract class Item
{

    private String name { get; set; }
    private int qtStock { get; set; }
    private Double price { get; set; }

    public Double GetPrice() {
        return price;
    }

    public string GetName()
    {
        return name;
    }

    public int SetStock(int qtBook)
    {
        qtStock += qtBook;
        return qtStock;
    }

    public int GetStock()
    {
        return qtStock;
    }

    public Item(String name, int qtStock, Double price)
    {
        this.name = name;
        this.qtStock = qtStock;
        this.price = price;
    }

}