using Unity.VisualScripting;
using UnityEngine;

public static class SaveSystemWoho
{
    private const string STRING_KEY = "stringKey";
    private const string INT_KEY = "intKey";
    private const string FLOAT_KEY = "floatKey";

    // Primjer vrijednosti varijabli koje bi se poslale
    //private static string water = "Jana";
    //private static int beer = 5;
    //private static float wine = 2f;

   public static void SaveUselessData(string water, int beer, float wine)
    {
        PlayerPrefs.SetString(STRING_KEY, water);
        PlayerPrefs.SetInt(INT_KEY, beer);
        PlayerPrefs.SetFloat(FLOAT_KEY, wine);
        PlayerPrefs.Save();
    }

    public static string GetWater()
    {
        return PlayerPrefs.GetString(STRING_KEY, "");
    }
    public static int GetBeer()
    {
        return PlayerPrefs.GetInt(INT_KEY, 0);
    }
    public static float GetWine()
    {
        return PlayerPrefs.GetFloat(FLOAT_KEY, 0f);
    }
}
