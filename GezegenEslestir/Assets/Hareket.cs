using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{
    Camera kamera;
    GameObject[] golgeler;
    Vector2 baslangic_pozisyon;
    Sayac sayac;
    AudioSource alkis;

    int yerlestirilen_gezegen;
    int toplam_golge = 7;
    public GameObject win;

    void Start()
    {
        yerlestirilen_gezegen = 0;

        kamera = GameObject.Find("camera").GetComponent<Camera>();
        golgeler = GameObject.FindGameObjectsWithTag("golge");
        baslangic_pozisyon = transform.position;
        alkis = kamera.GetComponent<AudioSource>();


    }


    private void OnMouseDrag()
    {

        Vector3 pozisyon = kamera.ScreenToWorldPoint(Input.mousePosition);
        pozisyon.z = 0;
        transform.position = pozisyon;
    }


    void Update()
    {



        if (Input.GetMouseButtonUp(0))
        {
            foreach (GameObject golge in golgeler)
            {
                float mesafe = Vector3.Distance(golge.transform.position, transform.position);
                if (mesafe <=1)
                {
                    
                    if (gameObject.name == golge.name)
                    {
                        transform.position = golge.transform.position;
                        Sayac();
                        alkis.Play();

                        Destroy(this);
                        
                    }
                    else
                    {
                        transform.position = baslangic_pozisyon;
                    }
                }
            }


        }



    }

    public void Sayac()
    {
            yerlestirilen_gezegen++;
            Debug.Log(yerlestirilen_gezegen);

            if (yerlestirilen_gezegen == toplam_golge)
            {
                win.SetActive(true);
            }
    }


}
