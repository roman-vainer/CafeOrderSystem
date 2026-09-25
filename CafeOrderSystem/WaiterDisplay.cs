using System;
using System.Collections.Generic;
using System.Text;

namespace CafeOrderSystem;

public class WaiterDisplay
{
    public void Update(Oder oder)
    {
        Console.WriteLine($"[Waiter Display Update] - {oder.Id}");
    }
}
