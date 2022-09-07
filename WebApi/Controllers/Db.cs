namespace WebApi.Controllers
{
    public class Db
    {
        public Db()
        {
            Addresses = new List<AddressBook>()
            {
                new AddressBook(){ Id=1,Name= "shujat",Address="gulshan",PostCode=19436,City="uppsala",Country="Sweden"},
                 new AddressBook(){ Id=2,Name= "Talha",Address="Johar",PostCode=17336,City="Karachi",Country="Pakistan"},
                new AddressBook(){ Id=3,Name= "Sarah",Address="Palace",PostCode=20436,City="QatarCity",Country="Qatar"}
           };
        }
        public List<AddressBook> Addresses { get; set; }
    }
}
