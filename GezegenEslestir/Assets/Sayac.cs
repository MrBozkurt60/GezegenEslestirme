using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sayac : MonoBehaviour
{
   /* int yerlestirilen_gezegen = 0;
    int toplam_golge = 7;
    public GameObject win;
    

    public void sayi_arttir()
    {
        yerlestirilen_gezegen++;
        Debug.Log(yerlestirilen_gezegen);

        if (yerlestirilen_gezegen == toplam_golge)
        {
            win.SetActive(true);
        }
    } */

    AudioSource m�z�k;

    private void Start()
    {
        m�z�k = GetComponent<AudioSource>();
        m�z�k.Play();

    }


}