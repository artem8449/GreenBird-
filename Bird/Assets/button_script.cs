using UnityEngine;
using UnityEngine.UI;

public class button_script : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    
  
 /*   // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        btnOn = GetComponent<Button>();
        btnOff = GetComponent<Button>();

        btnOn.onClick.AddListener(() => PlayAudio());
        btnOff.onClick.AddListener(() => StopAudio());
    }

    void PlayAudio()
    {
        audioSource.volume = 0.003f;
    }

    void StopAudio()
    {
        audioSource.volume = 0f;
    }*/
}
