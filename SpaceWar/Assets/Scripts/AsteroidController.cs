using UnityEngine;

public class AsteroidController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Rigidbody2D _astreroidRigidbody2D = GetComponent<Rigidbody2D>();
        // _astreroidRigidbody2D.AddForce(new Vector2(3, 5), ForceMode2D.Impulse);

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Asteroid çarptklari obje: " + collision.collider.name);
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 position = Input.mousePosition;
        position.z = -Camera.main.transform.position.z;
        position = Camera.main.ScreenToWorldPoint(position);
        transform.position = position;
    }
}
