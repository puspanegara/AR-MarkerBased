using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    //Inisialisasi GameObject plane
    public GameObject plane;
    //Inisialisasi GameObject spawn 
    public GameObject spawnPoint;

    // Update is called once per frame
    void Update()
    {
        //Menentukan posisi bola saat akan spawn
        if(transform.position.y < plane.transform.position.y - 1)
        {
            transform.position = spawnPoint.transform.position;
        }
    }
}
