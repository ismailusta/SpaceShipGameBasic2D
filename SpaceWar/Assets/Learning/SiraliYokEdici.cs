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
        targetAsteroid = EnYakinAsteroidiBul();
        if (targetAsteroid != null)
        {
            targetAsteroid.GetComponent<Exploid>().AsteroidYokEdici(1);
            asteroidList.Remove(targetAsteroid);
        }
    }
    GameObject EnYakinAsteroidiBul()
    {
        GameObject enYakinAsteroid;
        float enKucukMesafe;
        if (asteroidList.Count == 0)
        {
            return null;
        }
        else
        {
            enYakinAsteroid = asteroidList[0];
            enKucukMesafe = MesafeHesapla(enYakinAsteroid);
        }
        foreach (var asteroid in asteroidList)
        {
            float mesafe = MesafeHesapla(asteroid);
            if (mesafe < enKucukMesafe)
            {
                enYakinAsteroid = asteroid;
                enKucukMesafe = mesafe;
            }

        }
        return enYakinAsteroid;
    }
    float MesafeHesapla(GameObject hedefAstreoid)
    {
        return Vector3.Distance(_uzaygemisi.transform.position, hedefAstreoid.transform.position);
    }
}
