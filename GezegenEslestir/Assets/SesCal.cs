using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SesCal : MonoBehaviour
{
    AudioSource m�z�k;
    void Start()
    {
        m�z�k = GetComponent<AudioSource>();
        m�z�k.Play();
    }
}
