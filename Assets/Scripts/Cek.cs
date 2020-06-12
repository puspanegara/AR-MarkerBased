using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cek : MonoBehaviour
{
    public string nameScene;
    
    void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Ball"))
        {
            SceneManager.LoadScene(nameScene);
        }    
    }
}
