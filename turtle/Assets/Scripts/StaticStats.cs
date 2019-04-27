public static class StaticStats
{
    private static double life = 1000;
    private static int air = 0;
    private static int hunger = 0;
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

    public static int getAir()
    {
        return air;
    }
    public static void setAir(int value)
    {
        air = value;
    }

    public static int getHunger()
    {
        return hunger;
    }
    public static void setHunger(int value)
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
