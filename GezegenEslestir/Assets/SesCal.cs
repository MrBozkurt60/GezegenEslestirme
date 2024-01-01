using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SesCal : MonoBehaviour
{
    AudioSource müzük;
    void Start()
    {
        müzük = GetComponent<AudioSource>();
        müzük.Play();
    }
}
