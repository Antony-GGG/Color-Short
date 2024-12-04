using UnityEngine;

public static class ColorUtility
{
    public static Color GetColor(ColorType colorType)
    {
        switch (colorType)
        {
            case ColorType.Red: return Color.red;
            case ColorType.Blue: return Color.blue;
            case ColorType.Green: return Color.green;
            case ColorType.Yellow: return Color.yellow;
            case ColorType.Orange: return new Color(1.0f, 0.5f, 0.0f);
            case ColorType.Purple: return new Color(0.5f, 0.0f, 0.5f);
            case ColorType.Cyan: return Color.cyan;
            case ColorType.Magenta: return Color.magenta;
            case ColorType.White: return Color.white;
            case ColorType.Black: return Color.black;
            default: return Color.clear; // Default to transparent
        }
    }
}
