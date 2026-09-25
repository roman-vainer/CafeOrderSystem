using System;
using System.Collections.Generic;
using System.Text;

namespace CafeOrderSystem;

public class Statistic
{
    public void Update(Oder oder)
    {
        Console.WriteLine($"[Statistic Update] - {oder.Id}");
    }
}
