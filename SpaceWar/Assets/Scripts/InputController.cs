using UnityEngine;

public class InputController : MonoBehaviour
{
    [SerializeField] private GameObject _astreoidprefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log(Input.mousePosition);
            Vector3 position = Input.mousePosition;
            position.z = -Camera.main.transform.position.z;
            position = Camera.main.ScreenToWorldPoint(position);
            Instantiate(_astreoidprefab, position, Quaternion.identity);
        }
    }
}
