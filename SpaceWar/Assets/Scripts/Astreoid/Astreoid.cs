using UnityEngine;

public class Astreoid : MonoBehaviour
{
    [SerializeField] private GameObject _exploidPrefab;
    Rigidbody2D _rb2d;
    OyunKontrol _oyunKontrol;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb2d = GetComponent<Rigidbody2D>();
        _oyunKontrol = Camera.main.GetComponent<OyunKontrol>();
        float yon = Random.Range(0f, 1f);
        if (yon < 0.5f)
        {
            // sol-aşağı
            _rb2d.AddForce(new Vector2(Random.Range(-2.5f, -1f), Random.Range(-2.5f, -1f)), ForceMode2D.Impulse);
            // tork değeri
            _rb2d.AddTorque(yon * 10f);
        }
        else
        {
            // sag-aşağı
            _rb2d.AddForce(new Vector2(Random.Range(1f, 2.5f), Random.Range(-2.5f, -1f)), ForceMode2D.Impulse);
            // tork değeri 
            _rb2d.AddTorque(-yon * 10f);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Kursun") // eğer kursun tag'ıyle temas ederse
        {
            GameObject.FindGameObjectWithTag("Audio").GetComponent<SesKontrol>().AstreoidPatlamaSesi();
            _oyunKontrol.AstreoidYokOldu(gameObject);
            YokOldu();
        }
    }
    public void YokOldu()
    {
        Instantiate(_exploidPrefab, gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
