using System.ComponentModel.Design;
using System.Numerics;
using Desafio;

public class CarRental{
    public DateTime Start { get; set; }
    public DateTime End { get; set; } 

    public Vehicle Vehicle { get; set; } 
    public Invoice Invoice{get;set; }


public  CarRental(DateTime start, DateTime end, Vehicle vehicle)
{
    Start = start;
    End = end;
    Vehicle = vehicle;
}
}