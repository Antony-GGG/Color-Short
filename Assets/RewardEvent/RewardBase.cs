using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public abstract class RewardBase : MonoBehaviour
{
    public string RewardName;   // Name or identifier for the reward
    public int RewardValue;     // Value associated with the reward (points, currency, etc.)

    public abstract void CollectReward();

    // This method can be overridden to trigger additional effects after collecting the reward
    public virtual void TriggerPostRewardEffects()
    {
        // Default behavior: no effects, but subclasses can override this.
        Debug.Log($"Post-reward effects triggered for: {RewardName}");
    }
}