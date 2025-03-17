using System.Security.Cryptography;
using UnityEngine;

public static class ScreenSizeCalculator
{
    public static float sol;
    public static float sag;
    public static float ust;
    public static float alt;

    public static float Sol
    {
        get
        {
            return sol;
        }
    }

    public static float Sag
    {
        get
        {
            return sag;
        }
    }

    public static float Ust
    {
        get
        {
            return ust;
        }
    }

    public static float Alt
    {
        get
        {
            return alt;
        }
    }

    public static void CalculateScreenSize()
    {
        var screenZeksen = -Camera.main.transform.position.z;
        Vector3 solaltkose = new Vector3(0, 0, screenZeksen);
        Vector3 sagustkose = new Vector3(Screen.width, Screen.height, screenZeksen);

        Vector3 solaltkoseWorld = Camera.main.ScreenToWorldPoint(solaltkose);
        Vector3 sagustkoseWorld = Camera.main.ScreenToWorldPoint(sagustkose);

        sol = solaltkoseWorld.x;
        sag = sagustkoseWorld.x;
        ust = sagustkoseWorld.y;
        alt = solaltkoseWorld.y;

        Debug.Log("Sol: " + sol + " Sag: " + sag + " Ust: " + ust + " Alt: " + alt);
    }
}
