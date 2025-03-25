using UnityEngine;

public class SesKontrol : MonoBehaviour
{
    [SerializeField] AudioClip _astreoidPatlamaSesi;
    [SerializeField] AudioClip _gemiPatlamaSesi;
    [SerializeField] AudioClip _kursunSesi;
    AudioSource audioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void AstreoidPatlamaSesi()
    {
        audioSource.PlayOneShot(_astreoidPatlamaSesi);
    }
    public void GemiPatlamaSesi()
    {
        audioSource.PlayOneShot(_gemiPatlamaSesi);
    }
    public void KursunSesi()
    {
        audioSource.PlayOneShot(_kursunSesi, 0.4f);
    }
}
