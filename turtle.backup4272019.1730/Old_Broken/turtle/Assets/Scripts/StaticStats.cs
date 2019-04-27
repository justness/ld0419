public static class StaticStats
{
    private static double life = 1000;
    private static double air = 100;
    private static double hunger = 99999;
    private static bool plasticRing = false;
    private static bool poisoned = false;

    public static double getLife()
    {
        return life;
    }
    public static void setLife(double value) //Do we want this to be "changeLife" with a += for - and + values?
    {
        life = value;
    }

    public static double getAir()
    {
        return air;
    }
    public static void setAir(double value)
    {
        air = value;
    }

    public static double getHunger()
    {
        return hunger;
    }
    public static void setHunger(double value)
    {
        hunger = value;
    }

    public static bool getRing()
    {
        return plasticRing;
    }
    public static void setRing(bool value)
    {
        plasticRing = value;
    }

    public static bool getPois()
    {
        return poisoned;
    }
    public static void setPois(bool value)
    {
        poisoned = value;
    }
}
