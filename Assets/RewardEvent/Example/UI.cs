using System.Collections;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI itemCountText;
    [SerializeField] private TextMeshProUGUI itemPickupText;

    [SerializeField] private float fadeDuration = 1;
    private int currentItemCount = 0;

    private void OnEnable()
    {
        RewardEvent.OnRewardCollected += UpdateItemCount;
    }

    private void OnDisable()
    {
        RewardEvent.OnRewardCollected -= UpdateItemCount;
    }

    public void UpdateItemCount()
    {
        currentItemCount++;
        itemCountText.text = currentItemCount.ToString();
        PickedUpItem();
    }

    // Call this method to show the item pickup message with fade animation
    public void PickedUpItem()
    {
        itemPickupText.text = "Picked up item ";
        StartCoroutine(FadeText(itemPickupText, fadeDuration));
    }

    private IEnumerator FadeText(TextMeshProUGUI textElement, float duration)
    {
        float elapsedTime = 0f;
        Color originalColor = textElement.color;
        Color targetColor = new Color(originalColor.r, originalColor.g, originalColor.b, 0f); // Fully transparent

        // Fade out the text
        while (elapsedTime < duration)
        {
            textElement.color = Color.Lerp(originalColor, targetColor, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // Ensure the text is completely transparent after fade-out
        textElement.color = targetColor;
    }
}
