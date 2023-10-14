namespace AllStructsAndInterfaces
{
    public enum Roles : long
    {
        USER,
        MODERATOR,
        ADMIN
    }

    public enum Seasons
    {
        FALL = 1,
        SPRING = 2,
        SUMMER = 4,
        WINTER = 8,
        ALL = FALL | SPRING | WINTER | SUMMER
    }
}