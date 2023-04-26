namespace ObserverDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new mailing list
            MailingList mailingList = new MailingList("News");

            // Create some users and subscribe them to the mailing list
            User alice = new User("Alice", mailingList);
            alice.Subscribe();

            User bob = new User("Bob", mailingList);
            bob.Subscribe();

            User charlie = new User("Charlie", mailingList);
            charlie.Subscribe();

            // Add some emails to the mailing list
            mailingList.AddEmail("Hello World!");
            mailingList.AddEmail("Breaking news!");

            // Unsubscribe Bob from the mailing list
            bob.Unsubscribe();

            // Add another email to the mailing list
            mailingList.AddEmail("This is a test.");

            
        }
    }
}