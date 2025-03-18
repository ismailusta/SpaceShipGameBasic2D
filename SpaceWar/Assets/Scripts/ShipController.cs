using UnityEngine;

public class ShipController : MonoBehaviour
{
    float hiz = 10;
    bool topluyor = false;

    GameObject hedefyildiz;

    Rigidbody2D _rigidbody2D;
    Toplayici _toplayici;
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _toplayici = Camera.main.GetComponent<Toplayici>();
    }
    private void OnMouseDown()
    {
        if (!topluyor)
        {
            GitveTopla();
        }
    }
    void GitveTopla()
    {
        hedefyildiz = _toplayici.HedefYildiz;
        if (hedefyildiz != null)
        {
            Vector2 yon = new Vector2(hedefyildiz.transform.position.x - transform.position.x,
            hedefyildiz.transform.position.y - transform.position.y);
            yon.Normalize();
            _rigidbody2D.AddForce(yon * hiz, ForceMode2D.Impulse);
            return;
        }

    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject == hedefyildiz)
        {
            _toplayici.YildizSil(hedefyildiz);
            _rigidbody2D.linearVelocity = Vector2.zero;
            GitveTopla();

        }
    }
    // Update is called once per frame
    void Update()
    {
        // Vector3 position = transform.position;
        // float yatayinput = Input.GetAxis("Horizontal");
        // float dikeyinput = Input.GetAxis("Vertical");
        // if (yatayinput != 0)
        // {
        //     position.x += yatayinput * hiz * Time.deltaTime;
        // }
        // if (dikeyinput != 0)
        // {
        //     position.y += dikeyinput * hiz * Time.deltaTime;
        // }
        // if (Input.GetKeyDown(KeyCode.Space))
        // {
        //     DoForceSpaceShip();
        // }
        // transform.position = position;
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
