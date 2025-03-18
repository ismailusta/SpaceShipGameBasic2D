using System.Collections.Generic;
using UnityEngine;

public class Toplayici : MonoBehaviour
{
    [SerializeField] GameObject _yildizprefab;

    List<GameObject> _yildizlar = new List<GameObject>();

    public GameObject HedefYildiz
    {
        get
        {
            if (_yildizlar.Count > 0)
            {
                return _yildizlar[0];
            }
            else
            {
                return null;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 position = Input.mousePosition;
        position.z = -Camera.main.transform.position.z;
        position = Camera.main.ScreenToWorldPoint(position);
        if (Input.GetButtonDown("Fire1"))
        {
            _yildizlar.Add(Instantiate(_yildizprefab, position, Quaternion.identity));
        }
    }
    public void YildizSil(GameObject yildiz)
    {
        _yildizlar.Remove(yildiz);
        Destroy(yildiz);
    }
}
