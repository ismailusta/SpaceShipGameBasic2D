using UnityEngine;

public class ShipController : MonoBehaviour
{

    void Start()
    {
        Rigidbody2D _rigidbody2D = GetComponent<Rigidbody2D>();
        _rigidbody2D.AddForce(new Vector2(3, 5), ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D collision)//Parametre kendisi bu yazılan yerin collider ile çarpışan objeyi alır.
    {
        Debug.Log("Çarptiğin obje: " + collision.collider.name);
    }
}
