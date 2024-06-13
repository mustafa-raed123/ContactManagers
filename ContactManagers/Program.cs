namespace ContactManagers
{
    public class Program
    {

        public static List<string> Contacts = new List<string> { };
        static void Main(string[] args)
        {
            bool Again = true;
            while (Again)
            {
                ContactsManager();
                Console.WriteLine("Do you wont add new Contact (y/n) ");
                string rr = Console.ReadLine().ToUpper();
                if (!(rr == "YES" || rr == "Y"))
                {
                    Again = false;
                }
            }
        }


        public static void ContactsManager()
        {

            Console.WriteLine(Contacts.Count);
            Console.WriteLine("Do you want to add a new contact? Enter A,\n" +
             "if you want to remove a contact, enter B,\n" +
             "if you want to view all contacts, enter C.");
            string User = Console.ReadLine().ToUpper();

            if (User == "A")
            {
                Console.WriteLine("Enter the Contact that you want to add ");
                string Contact = Console.ReadLine();
                PrintList(AddContact(Contact));

            }
            else if (User == "B")
            {
                Console.WriteLine("Enter the Contact that you want to Remove ");
                string Contact = Console.ReadLine();
                PrintList(RemoveContact(Contact));
            }
            else if (User == "C")
            {
                Console.WriteLine("List of Contacts ");
                PrintList(ViewAllContacts(Contacts));
            }
        }
        public static List<string> AddContact(string Contact)
        {
            if (string.IsNullOrWhiteSpace(Contact))
            {
                Console.WriteLine("can't add");
                return Contacts;
            }
            bool Exist = Contacts.Contains(Contact);
            if (Exist)
            {
                Console.WriteLine("the Contact already Exist");
                return Contacts;
            }
            Console.WriteLine("updated Contact");
            Contacts.Add(Contact);
            return Contacts;
        }
        public static List<string> RemoveContact(string Contact)
        {
            if (string.IsNullOrWhiteSpace(Contact))
            {
                Console.WriteLine("can't removed");
                return Contacts;
            }
            bool Exist = Contacts.Contains(Contact);

            if (!Exist)
            {
                Console.WriteLine("the Contact is not found");

                return Contacts;
            }
            Console.WriteLine("updated Contact");

            Contacts.Remove(Contact);

            return Contacts;
        }
        public static List<string> ViewAllContacts(List<string> list)
        {
            return list;
        }

        public static void PrintList(List<string> list)
        {
            Console.Write("[");
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine("]");
        }
    }
}
