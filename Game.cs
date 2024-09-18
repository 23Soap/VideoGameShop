using System.Reflection.Metadata;
using System.Threading.Channels;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameShop;



public class Game
{
    private double itemNumber;
    private string itemName;
    private double itemPrice;
    private int numberOfStock;
    private double userRating;
    

    public Game(double itemNumber, string itemName,double itemPrice,int numberOfStock,double userRating)
    {
        this.itemNumber = itemNumber;
        this.itemName = itemName;
        this.itemPrice = itemPrice;
        this.numberOfStock = numberOfStock;
        this.userRating = userRating;
    }

    public string getItemName()
    {
        return itemName;
    }

    public double getItemNumber()
    {
        return itemNumber;
    }

    public double getItemPrice()
    {
        return itemPrice;
    }

    public int getNumberOfStock()
    {
        return numberOfStock;
    }

    public double getUserRating()
    {
        return userRating;
    }
}