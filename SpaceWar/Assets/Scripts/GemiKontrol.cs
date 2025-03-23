using UnityEngine;

public class GemiKontrol : MonoBehaviour
{
    [SerializeField] GameObject _kursunPrefab;
    [SerializeField] GameObject _patlamaPrefab;
    const float hiz = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        //-1.0 → Sol ok tuşu (Left Arrow) veya "A" tuşuna tam basıldığında veya "S" aşağı oka basıldığında.
        // 0.0 → Hiçbir tuşa basılmadığında veya giriş sıfırlandığında.
        // 1.0 → Sağ ok tuşu (Right Arrow) veya "D" tuşuna tam basıldığında veya "W" yukarı oka basıldığında.
        float yatayinput = Input.GetAxis("Horizontal");
        float dikeyinput = Input.GetAxis("Vertical");
        if (yatayinput != 0)
        {
            position.x += yatayinput * hiz * Time.deltaTime; // Her pcye fps e göre aynı olsun diye
        }
        if (dikeyinput != 0)
        {
            position.y += dikeyinput * hiz * Time.deltaTime;
        }
        transform.position = position;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 kursunPosition = gameObject.transform.position;
            kursunPosition.y += 1.0f;
            Instantiate(_kursunPrefab, kursunPosition, Quaternion.identity);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Astreoid")
        {
            Instantiate(_patlamaPrefab, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
