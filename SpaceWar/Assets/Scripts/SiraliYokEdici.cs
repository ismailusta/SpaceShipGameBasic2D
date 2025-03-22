using System.Collections.Generic;
using UnityEngine;

public class SiraliYokEdici : MonoBehaviour
{
    [SerializeField] private GameObject _astreoidprefab;
    GameObject _uzaygemisi;
    List<GameObject> asteroidList;
    GameObject targetAsteroid;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        asteroidList = new List<GameObject>();
        _uzaygemisi = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = Input.mousePosition;
            pos.z = -Camera.main.transform.position.z;
            pos = Camera.main.ScreenToWorldPoint(pos);

            GameObject _currentAsteroid = Instantiate(_astreoidprefab, pos, Quaternion.identity);
            asteroidList.Add(_currentAsteroid);
        }
        if (Input.GetMouseButtonDown(1))
        {
            HedefiYokEt();
        }
    }
    public void HedefiYokEt()
    {
    }
}
