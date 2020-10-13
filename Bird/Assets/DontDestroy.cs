using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    private static int  status = 0; 
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        AudioSource audio1 = GetComponent<AudioSource>();
        if (status == 0)
        {
            audio1.Play();
            status = 1;
        }
        else
        {
            audio1.Stop();
            Destroy(gameObject);
        }
    }
}
