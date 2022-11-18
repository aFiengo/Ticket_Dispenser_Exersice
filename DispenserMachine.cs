namespace TicketDispenser
{
    public class DispenserMachine
    {
        public DispenserMachine()
        {
        }
        public void Introduction(string introduction)
        {
            Console.WriteLine(introduction);
        }
        public void AskSomething(string question)
        {
            Console.WriteLine(question);
        }
       public void ShowEventTypes(string question, List<EventType> types)
        {
            Console.WriteLine(question);
            for (int i = 0; i < types.Count; i++)
            {
                Console.WriteLine("{0}: {1}", i + 1, types[i].Name);
            }
        }
        public void ShowEventNames(string question, List<EventName> names)
        {
            Console.WriteLine(question);
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine("{0}: {1}", i + 1, names[i].Name);
            }
        }
        public void ShowZones(string question, List<Zone> zones)
        {
            Console.WriteLine(question);
            for (int i = 0; i < zones.Count; i++)
            {
                Console.WriteLine("{0}: {1}", i + 1, zones[i].Name);
            }
        }
        public string ValidateInput(string? input)
        {
            string validatedInput;
            if (input != null && input.Trim() != "")
            {
                validatedInput = input;
            }
            else
            {
                validatedInput = "-------";
            }
            return validatedInput;
        }
        public void ValidateInput(string? input, out int output)
        {
            if (input != null && input.Trim() != "")
            {
                output = Convert.ToInt32(input);
            }
            else
            {
                output = 1;
            }
        }
        public void ConfirmInput(string comment)
        {
            Console.WriteLine(comment);
        }
    }
}