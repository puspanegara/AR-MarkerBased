using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChange : MonoBehaviour
{
    public string nameScene;
    
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }    
    public void NextLevelScene()
    {
        SceneManager.LoadScene(nameScene);
    }
}
