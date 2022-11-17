using TicketDispenser;
using TicketDispenser.EventData;
//*************************************************************************************************************************************
DispenserMachine dispenserMachine = new DispenserMachine();
Event _event = new Event();
//*************************************************************************************************************************************
List<string> answers = new List<string>();
answers.Add("Sí");
answers.Add("No");
//*************************************************************************************************************************************
List<string> eventType = new List<string>();
eventType.Add("Music");
eventType.Add("Sport");
//*************************************************************************************************************************************
List<string> paymentInfo = new List<string>();
paymentInfo.Add("Debit/Credit");
paymentInfo.Add("PayPal");
paymentInfo.Add("QR code");
//*************************************************************************************************************************************
string typeOfEvent;
string zone;
string? numberOfTicketsInput;
int numberOfTickets;
string? name;
string? lastName;
string? ageInput;
int age;
string? email;
string? phoneNumberInput;
int phoneNumber;
string? paymentInfoInput;
double? ticketPriceOut;
int zoneInput;
//*************************************************************************************************************************************
dispenserMachine.Introduction("Bienvenido al servicio para compras de entradas de TRUEXTEND");
dispenserMachine.ShowInfo("Escoge al tipo de evento que te gustaria asistir:", eventType);
string? choosenEventIndexInput = Console.ReadLine();
int choosenEvent = Convert.ToInt32(choosenEventIndexInput);
switch (choosenEvent)
{
    case (int)TypeOfEvent.Music:
        typeOfEvent = "Music Event";
        break;
    case (int)TypeOfEvent.Sport:
        typeOfEvent = "Sport Event";
        break;
    default:
        typeOfEvent = "N/A";
        break;
}
//*************************************************************************************************************************************
Event currentEvent = choosenEvent == 1 ? new MusicEvent() : new SportEvent();
Console.WriteLine("******************************************");
dispenserMachine.ShowZones("Selecciona el sector:", currentEvent.Zones);
zoneInput = Convert.ToInt32(Console.ReadLine()) - 1;
Zone choosenZone = currentEvent.Zones[zoneInput];
Console.WriteLine("******************************************");
dispenserMachine.AskSomething("El costo de cada ticket es de: " + choosenZone.TicketPrice + " bs");
dispenserMachine.AskSomething("Tienes un límite de 6 entradas por usuario");
dispenserMachine.AskSomething("Ingresa la cantidad de tickets que deseas:");
numberOfTicketsInput = Console.ReadLine();
dispenserMachine.ValidateInput(numberOfTicketsInput, out numberOfTickets);
while (numberOfTickets <= 0 || numberOfTickets > 6)
{
    dispenserMachine.AskSomething("RECUERDE que tienes un límite de 6 entradas por usuario");
    numberOfTicketsInput = Console.ReadLine();
    dispenserMachine.ValidateInput(numberOfTicketsInput, out numberOfTickets);
}
Console.WriteLine("******************************************");
dispenserMachine.ConfirmInput("Usted seleccionó " + numberOfTickets + " tickets");
double totalCost = numberOfTickets * choosenZone.TicketPrice;
dispenserMachine.AskSomething("Su pedido tendria un costo total de: " + totalCost + " bs");
Console.WriteLine("******************************************");
dispenserMachine.AskSomething("Ahora registraremos sus datos y su metodo de pago: ");
dispenserMachine.AskSomething("Ingrese su nombre:");
name = Console.ReadLine();
name = dispenserMachine.ValidateInput(name);
dispenserMachine.AskSomething("Ingrese sus apellidos:");
lastName = Console.ReadLine();
lastName = dispenserMachine.ValidateInput(lastName);
dispenserMachine.AskSomething("Ingrese su edad:");
ageInput = Console.ReadLine();
dispenserMachine.ValidateInput(ageInput, out age);
dispenserMachine.AskSomething("Ingrese su e-mail:");
email = Console.ReadLine();
email = dispenserMachine.ValidateInput(email);
dispenserMachine.AskSomething("Ingrese su numero de telefono:");
phoneNumberInput = Console.ReadLine();
dispenserMachine.ValidateInput(phoneNumberInput, out phoneNumber);
dispenserMachine.ShowInfo("Ingrese el metodo de pago:", paymentInfo);
string? choosenPaymentIndexInput = Console.ReadLine();
int choosenPayment = Convert.ToInt32(choosenPaymentIndexInput) - 1;
switch (choosenPayment)
{
    case (int)PaymentInfo.Debito_o_Credito:
        paymentInfoInput = "Debit/Credit";
        break;
    case (int)PaymentInfo.PayPal:
        paymentInfoInput = "PayPal";
        break;
    case (int)PaymentInfo.QR_code:
        paymentInfoInput = "QR Code";
        break;
    default:
        paymentInfoInput = "N/A";
        break;
}
User user = new User()
{
    Name = name,
    LastName = lastName,
    Age = age,
    Email = email,
    PhoneNumber = phoneNumber,
    PaymentInfo = paymentInfoInput,
    NumberOfTickets = numberOfTickets,
    UID = Guid.NewGuid()
};
List<Tickets> ticketList = new List<Tickets>();
for (int i = 0; i < numberOfTickets; i++)
{
    ticketList.Add(new Tickets()
    {
        Zone = currentEvent.Zones[zoneInput].ZoneName,
        TID = Guid.NewGuid(),
        Price = choosenZone.TicketPrice,
        Location = currentEvent.Location,
        Date = currentEvent.EventDate
    });
}
Console.WriteLine("***********************************************************************************************************");
dispenserMachine.AskSomething("Su Pedido es el siguiente:");
// Console.WriteLine("UID: {0}", user.UID);
Console.WriteLine($"UID: {user.UID} algo mas");
// Console.WriteLine("Nombre y Apellido: {0} {1}", user.Name, user.LastName);
// string nameLastToShow = String.Format("Nombre y Apellido: {0} {1}", user.Name, user.LastName);
Console.WriteLine($"Nombre y Apellido: {user.Name} {user.LastName}");

string variableOne = "Hola mundo" + " " + user.Name; // concatenacion
string variableTwo = String.Format("Hola mundo {0}", user.Name); // string format
string variableThree = $"Hola mundo {user.Name}"; // string template

Console.WriteLine("E-mail: {0}", user.Email);
Console.WriteLine("Numero de telefono: {0}", user.PhoneNumber);
Console.WriteLine("Edad: {0}", user.Age);
Console.WriteLine("Metodo de pago: {0}", user.PaymentInfo);
Console.WriteLine("Event Name: {0}", currentEvent.EventName);
Console.WriteLine("Date: {0}", currentEvent.EventDate);
// Console.WriteLine("Location: {0}", currentEvent.Location.LocationName + " , " + currentEvent.Location.LocationCity + " , " + currentEvent.Location.LocationState);
Console.WriteLine($"Location: {currentEvent.Location.LocationName} , {currentEvent.Location.LocationCity} , {currentEvent.Location.LocationState}");
Console.WriteLine("Zone: {0}", choosenZone.ZoneName);
Console.WriteLine("Number of tickets: {0}", numberOfTickets);
Console.WriteLine("Price: {0}", choosenZone.TicketPrice);
Console.WriteLine("***********************************************************************************************************");
dispenserMachine.AskSomething("Gracias por su compra!!");
dispenserMachine.AskSomething("A continuación sus tickets:");
Console.WriteLine("***********************************************************************************************************");
foreach (Tickets tickets in ticketList)
{
    Console.WriteLine("TID: {0}", tickets.TID);
    Console.WriteLine("Location: {0}", tickets.Location.LocationName);
    Console.WriteLine("Date: {0}", tickets.Date);
    Console.WriteLine("Zone: {0}", tickets.Zone);
    Console.WriteLine("Price: {0}", tickets.Price);
}
