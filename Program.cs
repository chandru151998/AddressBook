namespace AddressBookSystem
{
    class Program
    {
        //creating list of contact
        public static List<Contact> contactList = new List<Contact>();
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Sytem.");

            //ability to creating contacts
            Contact contact1 = new Contact();
            contact1.firstName = "Chandru";
            contact1.lastName = "Kalahalamath";
            contact1.address = "Gadag Karnataka";
            contact1.phone = 1234567890;
            contact1.city = "Gadag";
            contact1.state = "Karnataka";
            contact1.zipcode = 582103;
            contactList.Add(contact1);

        }
    }
}
