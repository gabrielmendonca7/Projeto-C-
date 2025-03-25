using Desafio;

public class RentalService
{
    public double PricePerHour{get;private set;}
    public double PricePerDay{get;private set;}

    private ITax _Itax;

    public RentalService(double pricePerHour,double pricePerDay,ITax itax){
        PricePerHour = pricePerDay;
        PricePerDay = pricePerDay;
        _Itax = itax;
    }

    public void ProcessInvoice(CarRental carRental)
    {
        TimeSpan duration = carRental.End.Subtract(carRental.Start);
        double basicPay = 0;

        if(duration.TotalHours <= 12){
            basicPay = Math.Ceiling(duration.TotalHours) * PricePerHour;
        }
        else
        {
            basicPay = Math.Ceiling(duration.TotalDays) * PricePerDay;
        }

        double tax = _Itax.Tax(basicPay);
        
        carRental.Invoice = new Invoice(basicPay,tax);
    }
}