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
        if (Input.GetMouseButtonDown(1))
        {
            Vector3 pos = Input.mousePosition;
            pos.z = -Camera.main.transform.position.z;
            Vector3 worldpos = Camera.main.ScreenToWorldPoint(pos);
            _yildizlar.Add(Instantiate(_yildizprefab, worldpos, Quaternion.identity));
        }
    }
    public void YildizSil(GameObject yildiz)
    {
        _yildizlar.Remove(yildiz);
        Destroy(yildiz);
    }
}
