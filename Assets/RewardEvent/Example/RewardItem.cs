using UnityEngine;

public class RewardItem : RewardBase
{
    [Header("Effects")]
    public ParticleSystem collectEffect; // Particle effect when the reward is collected
    public AudioClip collectSound;       // Sound effect for collection
    public Animator rewardAnimator;      // Animator for any animation effects

    public override void CollectReward()
    {
        Debug.Log($"Reward Collected: {RewardName}, Value: {RewardValue}");

        // Triggering post-reward effects
        TriggerPostRewardEffects();

        // Trigger the reward event
        RewardEvent.TriggerRewardCollected();

        Destroy(gameObject); // Optionally destroy the object after collection
    }

    public override void TriggerPostRewardEffects()
    {
        // Trigger particle effect
        if (collectEffect != null)
        {
            collectEffect.Play();
        }

        // Play sound effect
        if (collectSound != null)
        {
            AudioSource.PlayClipAtPoint(collectSound, transform.position);
        }

        // Trigger any animations
        if (rewardAnimator != null)
        {
            rewardAnimator.SetTrigger("Collect");  // Assume "Collect" is an animation trigger
        }

        base.TriggerPostRewardEffects();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Check for player collision
        {
            CollectReward();
        }
    }
}
