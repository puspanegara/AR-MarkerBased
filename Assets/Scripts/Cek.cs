using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cek : MonoBehaviour
{
    
    //Menggunakan int untuk memamnggil scene yang akan digunakan
    public int numberScene;

    /*Membuat methode saat bola mengenai kotak merah akan berganti
    ke Level selanjutnya*/
    void OnTriggerEnter(Collider other) 
    {
        //Saat mendeteksi Tag Ball
        if(other.CompareTag("Ball"))
        {
            //Scene yang di tuju akan di ganti
            SceneManager.LoadScene(numberScene);
        }    
    }
}
