namespace TicketDispenser
{
    public class User
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email {get ; set; }
        public int PhoneNumber { get; set; }
        public string PaymentInfo { get; set; }
        public Guid UID { get; set; }
        public int NumberOfTickets { get; set; }
        public List<Tickets> Tickets { get; set; } = new List<Tickets>();
    }
}