using UnityEngine;

public class PatlamaAnimasyonIptali : MonoBehaviour
{
    GeriSayma geriSayma;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        geriSayma = gameObject.AddComponent<GeriSayma>();
        geriSayma.ToplamSure = 1;
        geriSayma.Baslat();
    }

    // Update is called once per frame
    void Update()
    {
        if (geriSayma.BittiMi())
        {
            Destroy(gameObject);
        }
    }
}
