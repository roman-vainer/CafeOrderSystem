using System;
using System.Collections.Generic;
using System.Text;

namespace CafeOrderSystem;

public class Oder
{
    private static int id = 0;
    public string CustomerName { get; }
    public decimal TotalPrice { get; private set; }
    public OderStatus status { get; private set; }

    public Oder(string customerName, decimal totalPrice)
    {
        id++;
        CustomerName = customerName;
        TotalPrice = totalPrice;
        status = OderStatus.New;
    }

    private void newOrder()
    {

    }

    public void Comfirm()
    {

    }

    public void StartCooking()
    {

    }

    public void MarkReady()
    {

    }

    public void Complete()
    {

    }

    public void Cancel()
    {

    }
}
