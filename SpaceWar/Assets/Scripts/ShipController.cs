using UnityEngine;

public class ShipController : MonoBehaviour
{
    float hiz = 10;
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        float yatayinput = Input.GetAxis("Horizontal");
        float dikeyinput = Input.GetAxis("Vertical");
        if (yatayinput != 0)
        {
            position.x += yatayinput * hiz * Time.deltaTime;
        }
        if (dikeyinput != 0)
        {
            position.y += dikeyinput * hiz * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DoForceSpaceShip();
        }
        transform.position = position;
    }

    void OnCollisionEnter2D(Collision2D collision)//Parametre kendisi bu yazılan yerin collider ile çarpışan objeyi alır.
    {
        Debug.Log("Çarptiğin obje: " + collision.collider.name);
    }
    void DoForceSpaceShip()
    {
        Rigidbody2D _rigidbody2D = GetComponent<Rigidbody2D>();
        _rigidbody2D.AddForce(new Vector2(3, 5), ForceMode2D.Impulse);

    }
}
