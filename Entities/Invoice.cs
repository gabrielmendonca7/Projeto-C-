using System;
using System.Globalization;
using System.Text;

namespace Desafio
{
    

public class Invoice{
    public double BasicPay{get;set;}
    public double Tax {get;set;}

    public Invoice(double basicPay, double tax){
        BasicPay = basicPay;
        Tax = tax;
    }

    private double TotalPay() => BasicPay + Tax;

    public override string ToString(){
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Basic payment: {BasicPay.ToString("F2",CultureInfo.InvariantCulture)}");
        sb.AppendLine($"Tax: {Tax.ToString("F2",CultureInfo.InvariantCulture)}");
        sb.AppendLine($"Total pay: {TotalPay().ToString("F2",CultureInfo.InvariantCulture)}");
        return sb.ToString();
    }
}
}