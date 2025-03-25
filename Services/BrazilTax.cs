public class BrazilTax : ITax{
    
    public double Tax(double amount) => amount <= 100 ? amount * 0.2 : amount * 0.15;
}