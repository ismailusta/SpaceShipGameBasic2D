using UnityEngine;

public class EkranBoyutu
{
    public static float sol, sag, ust, alt;
    // Dışarıdan sadece okunması için property
    public static float Sol => sol;
    public static float Sag => sag;
    public static float Ust => ust;
    public static float Alt => alt;

    public static void EkraniHesapla()
    {
        Camera cam = Camera.main;
        if (cam.orthographic)
        {
            float ortoYukseklik = cam.orthographicSize;
            float ortoGenislik = ortoYukseklik * cam.aspect;

            sol = cam.transform.position.x - ortoGenislik;
            sag = cam.transform.position.x + ortoGenislik;
            ust = cam.transform.position.y + ortoYukseklik;
            alt = cam.transform.position.y - ortoYukseklik;
            Debug.Log("Sol: " + sol + " Sag: " + sag + " Ust: " + ust + " Alt: " + alt);
        }
        else
        {
            var ekraninZekseni = -Camera.main.transform.position.z;
            Vector3 solAltKose = new Vector3(0, 0, ekraninZekseni);
            Vector3 sagUstKose = new Vector3(Screen.width, Screen.height, ekraninZekseni);

            Vector3 solAltKoseWorld = Camera.main.ScreenToWorldPoint(solAltKose);
            Vector3 sagUstKoseWorld = Camera.main.ScreenToWorldPoint(sagUstKose);

            sol = solAltKoseWorld.x;
            sag = sagUstKoseWorld.x;
            ust = sagUstKoseWorld.y;
            alt = solAltKoseWorld.y;
        }
    }
}
