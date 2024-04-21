using System;
using System.Globalization;
using Hotel;

class Program
{
    static void Main(string[] args)
    {

        //CRIANDO AS PESSOAS
        Pessoa personOne = new Pessoa("Seto","Kaiba");
        Pessoa personTwo = new Pessoa("Yami", "Yugi");
        Pessoa personThree = new Pessoa("Joey", "Wheler");


        //CRIANDO E PREENCHENDO A LISTA DE HOSPEDES
        List<Pessoa> guestList = new List<Pessoa>();
        guestList.Add(personOne);
        guestList.Add(personTwo);
        guestList.Add(personThree);

        //CRIANDO A SUITE
        Suite suite = new Suite("Executiva",4,5.00M);


        //CRIANDO A RESERVA
        Reserva reservation = new Reserva(20);
        reservation.RegisterSuites(suite);
        reservation.RegisterGuests(guestList);

        //MOSTRANDO QUANTIDADE DE HOSPEDES E PREÇO TOTAL A PAGAR

        Console.WriteLine($"NUMBER OF GUESTS: {reservation.getGuestQuantity()}");
        Console.WriteLine($"TOTAL PRICE: {reservation.calculateDailyPrice().ToString("#,0.00")}");







    }
}
