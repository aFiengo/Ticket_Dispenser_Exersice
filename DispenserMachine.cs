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
        public void ShowInfo(string question, List<string> options, bool showIndex = true)
        {
            Console.WriteLine(question);
            for (int optionIndex = 0; optionIndex < options.Count; optionIndex++)
            {
                if (showIndex)
                {
                    int numberToShow = optionIndex + 1;
                    Console.Write(numberToShow + ":");
                }
                Console.WriteLine(options[optionIndex]);
            }
        }
        public void ShowZones(string question, List<Zone> zones)
        {
            Console.WriteLine(question);
            for (int i = 0; i < zones.Count; i++)
            {
                Console.WriteLine("{0}: {1}", i + 1, zones[i].ZoneName);
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