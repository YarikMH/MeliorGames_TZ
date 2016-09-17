using System;

public static class EventsManager
{
    public static event Action OnOutOfRange = delegate { };
    public static void RaiseOnOutOfRange()
    {
        OnOutOfRange();
    }

}
