using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class OyunKontrol : MonoBehaviour
{
    [SerializeField] GameObject _uzaygemisiPrefab;
    [SerializeField] List<GameObject> _astreoidPrefabs = new List<GameObject>();
    List<GameObject> asteroidList = new List<GameObject>();
    [SerializeField] int zorluk; //1
    [SerializeField] int carpan; //5
    GameObject _uzaygemisi;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _uzaygemisi = Instantiate(_uzaygemisiPrefab);
        _uzaygemisi.transform.position = new Vector3((EkranBoyutu.Sol + EkranBoyutu.Sag) / 2, EkranBoyutu.Alt + 1.5f);
        AstreoidUret(5);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void AstreoidUret(int maksadet)
    {
        Vector3 position = new Vector3();

        for (int i = 0; i < maksadet; i++)
        {
            position.z = -Camera.main.transform.position.z;
            position = Camera.main.ScreenToWorldPoint(position);
            position.x = Random.Range(EkranBoyutu.Sol, EkranBoyutu.Sag);
            position.y = EkranBoyutu.Ust - 1.5f;

            GameObject astreoid = Instantiate(_astreoidPrefabs[Random.Range(0, 3)], position, Quaternion.identity);
            asteroidList.Add(astreoid);
        }
    }
    public void AstreoidYokOldu(GameObject astreoid)
    {
        asteroidList.Remove(astreoid);
        if (asteroidList.Count <= zorluk)
        {
            zorluk++;
            AstreoidUret(zorluk * carpan);
        }
    }
}
