namespace TicketDispenser
{
    enum Answers
    {
        Yes = 1,
        No = 0
    }
    enum TypeOfEvent
    {
        Music = 0,
        Sport = 1
    }
    enum MusicEventZones
    {
        Super_VIP = 0,
        VIP = 1,
        Pista = 2,
        Preferencia = 3,
        General = 4, 
        Curva_Norte = 5
    }
    enum SportEventZones
    {
        Butaca = 0,
        Preferencia = 1,
        General = 2,
        Curva_Norte = 3,
        Curva_Sur = 4
    }
    enum PaymentInfo
    {
        Debito_o_Credito = 0,
        PayPal = 1,
        QR_code = 2
    }
}