using System;
using System.Collections.Generic;
using System.Text;

namespace CafeOrderSystem;

public class CustomerNotifier
{
    public void Notify(Oder oder)
    {
        Console.WriteLine($"[CustomerNotify Notify] - {oder.Id}");
    }
}
