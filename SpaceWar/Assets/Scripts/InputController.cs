using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    [SerializeField] private GameObject _astreoidprefab;
    List<GameObject> _asteroidsList = new List<GameObject>();
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
            for (int i = 0; i < 10; i++)
            {
                _asteroidsList.Add(Instantiate(_astreoidprefab, position, Quaternion.identity));
            }
        }
        else if (Input.GetButtonDown("Fire2"))
        {

            foreach (var asteroid in _asteroidsList)
            {
                Destroy(asteroid);
            }
            _asteroidsList.Clear();
        }
    }
}
