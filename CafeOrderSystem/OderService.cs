using System;
using System.Collections.Generic;
using System.Text;

namespace CafeOrderSystem;

public class OderService
{
    List<Oder> oders;
    KitchenDisplay kitchenDisplay;
    WaiterDisplay waiterDisplay;
    Statistic statistic;
    CustomerNotifier customerNotifier;

    public OderService(KitchenDisplay kitchenDisplay, WaiterDisplay waiterDisplay, Statistic statistic, CustomerNotifier customerNotifier) { 
        this.kitchenDisplay = kitchenDisplay;
        this.waiterDisplay = waiterDisplay;
        this.statistic = statistic;
        this.customerNotifier = customerNotifier;
        oders = new List<Oder>();
    }
    public void receiveOder()
    {

    }


}


