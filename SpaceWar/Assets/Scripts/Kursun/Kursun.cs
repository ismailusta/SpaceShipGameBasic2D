using UnityEngine;

public class Kursun : MonoBehaviour
{
    GeriSayma _geriSayma;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rigidbody2D _rigidbody = GetComponent<Rigidbody2D>();
        _rigidbody.AddForce(new Vector2(0, 10), ForceMode2D.Impulse);
        // başlar başlamaz gerisayma sınıfını bu oyun objesine ekliyoz.
        _geriSayma = gameObject.AddComponent<GeriSayma>();
        _geriSayma.ToplamSure = 3;
        _geriSayma.Baslat();
    }

    // Update is called once per frame
    void Update()
    {
        if (_geriSayma.BittiMi())
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Astreoid")
        {
            Destroy(gameObject);
        }
    }
}
