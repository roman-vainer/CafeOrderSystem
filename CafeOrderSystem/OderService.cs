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
    OderLogger logger;
    CustomerNotifier customerNotifier;

    public OderService(
        KitchenDisplay kitchenDisplay,
        WaiterDisplay waiterDisplay,
        Statistic statistic,
        CustomerNotifier customerNotifier,
        OderLogger logger
        )
    {
        this.kitchenDisplay = kitchenDisplay;
        this.waiterDisplay = waiterDisplay;
        this.statistic = statistic;
        this.customerNotifier = customerNotifier;
        this.logger = logger;

        oders = new List<Oder>();
    }
    public void receiveOder()
    {
        Oder oder = new Oder("Bob", 56.7m);
        oders.Add( oder );
        waiterDisplay.Update( oder );
        kitchenDisplay.Update( oder );
        statistic.Update( oder );
        logger.LogOderChange( oder );
        customerNotifier.Notify(oder);
    }
}


