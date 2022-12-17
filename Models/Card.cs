/* name: Jackson
 * date: 12/28/02
 * Description: Lab5 NETD
 * */



namespace Lab5Sub.Models
{
    public class Card
    {
        //declaring data memebers and getter/setter properties.
        public int CardID { get; set; }

        public string Type { get; set; }

        public int EstimatedMarketPrice { get; set; }

        public int PurchasePrice { get; set; }

        public string Info { get; set; }

    }

    public class User
    {
        public int UserID { get; set; }
        public int CardID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
