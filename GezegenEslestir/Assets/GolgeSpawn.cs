using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GolgeSpawn : MonoBehaviour
{
    public Transform[] SpawnPoints;
    public GameObject[] golgeler;

    void Start()
    {

        List<int> AvailableIndex = new List<int>();

        for(int i = 0; i < golgeler.Length; i++)
        {
            AvailableIndex.Add(i);
        }

        for(int i = 0; i < SpawnPoints.Length; i++)
        {
            int RandomIndex = Random.Range(0 ,AvailableIndex.Count);
            int SelectedIndex = AvailableIndex[RandomIndex];
            AvailableIndex.RemoveAt(RandomIndex);
            Instantiate(golgeler[SelectedIndex], SpawnPoints[i].position, Quaternion.identity);
        }
    }
}
