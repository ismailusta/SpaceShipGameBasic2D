using UnityEngine;

public class AsteroidController : MonoBehaviour
{
    private float _colliderWithHalf;
    private float _colliderHeightHalf;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rigidbody2D _astreroidRigidbody2D = GetComponent<Rigidbody2D>();
        _astreroidRigidbody2D.AddForce(new Vector2(Random.Range(-5, 5), Random.Range(-5, 5)), ForceMode2D.Impulse);

        BoxCollider2D _asteroidBoxCollider2D = GetComponent<BoxCollider2D>();
        _colliderWithHalf = _asteroidBoxCollider2D.size.x / 2;
        _colliderHeightHalf = _asteroidBoxCollider2D.size.y / 2;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Asteroid çarptklari obje: " + collision.collider.name);
    }
    // Update is called once per frame
    void Update()
    {
        // Vector3 position = Input.mousePosition;
        // position.z = -Camera.main.transform.position.z;
        // position = Camera.main.ScreenToWorldPoint(position);
        // transform.position = position;
        StayScreen();
    }
    void StayScreen()
    {
        Vector3 pos = transform.position;
        if (pos.x - _colliderWithHalf < ScreenSizeCalculator.Sol)
        {
            pos.x = ScreenSizeCalculator.Sol + _colliderWithHalf;
        }
        else if (pos.x + _colliderWithHalf > ScreenSizeCalculator.Sag)
        {
            pos.x = ScreenSizeCalculator.Sag - _colliderWithHalf;
        }
        if (pos.y - _colliderHeightHalf < ScreenSizeCalculator.Alt)
        {
            pos.y = ScreenSizeCalculator.Alt + _colliderHeightHalf;
        }
        else if (pos.y + _colliderHeightHalf > ScreenSizeCalculator.Ust)
        {
            pos.y = ScreenSizeCalculator.Ust - _colliderHeightHalf;
        }
        transform.position = pos;
    }
}
