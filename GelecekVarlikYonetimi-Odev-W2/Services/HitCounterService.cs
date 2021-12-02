namespace GelecekVarlikYonetimi_Odev_W2.Services
{
    public class HitCounterService : IPageHitCounter
    {
        public static int counter;

        public int Increase()
        {
            counter = counter + 1;
            return counter;
        }
    }
}
