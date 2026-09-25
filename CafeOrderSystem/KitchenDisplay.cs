using System;
using System.Collections.Generic;
using System.Text;

namespace CafeOrderSystem;

public class KitchenDisplay
{
    public void Update(Oder oder)
    {
        Console.WriteLine($"[KitchenDisplay Update] - {oder.Id}");
    }
}
