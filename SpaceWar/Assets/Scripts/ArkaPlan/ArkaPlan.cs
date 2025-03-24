using UnityEngine;

public class ArkaPlan : MonoBehaviour
{
    //arka planı sürekli yukarı veya aşağıya doğruymuş gibi
    MeshRenderer meshRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float yeniYdegeri = 0.2f * Time.time;
        meshRenderer.material.mainTextureOffset = new Vector2(0, yeniYdegeri);
    }
}
