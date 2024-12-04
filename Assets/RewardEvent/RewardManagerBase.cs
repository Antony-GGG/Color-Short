using System.Collections.Generic;
using UnityEngine;

public abstract class RewardManagerBase : MonoBehaviour
{
    private void OnEnable()
    {
        RewardEvent.OnRewardCollected += HandleReward;
    }

    private void OnDisable()
    {
        RewardEvent.OnRewardCollected -= HandleReward;
    }

    protected virtual void HandleReward() { }
}
