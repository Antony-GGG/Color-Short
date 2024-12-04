using System;

public static class RewardEvent
{
    public static event Action OnRewardCollected;

    public static void TriggerRewardCollected()
    {
        OnRewardCollected?.Invoke();
    }
}