namespace CafeOrderSystem;

public class Program
{
    static void Main(string[] args)
    {
        KitchenDisplay kitchenDisplay = new KitchenDisplay();
        WaiterDisplay waiterDisplay = new WaiterDisplay();
        OderLogger logger = new OderLogger();
        Statistic statistic = new Statistic();
        CustomerNotifier customerNotifier = new CustomerNotifier();

        OderService oderService = new OderService
            (
            kitchenDisplay,
            waiterDisplay,
            statistic,
            customerNotifier,
            logger
            );

        oderService.receiveOder();
    }
}
