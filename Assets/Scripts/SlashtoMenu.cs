using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SlashtoMenu : MonoBehaviour
{
    public static int SceneNumber;

    // Start is called before the first frame update
    void Start()
    {
        if(SceneNumber == 0)
        {
            StartCoroutine(ToSplashTwo());
        }
        if (SceneNumber == 1)
        {
            StartCoroutine(ToMenu());
        }
    }

    IEnumerator ToSplashTwo()
    {
        yield return new WaitForSeconds(15);
        SceneNumber = 1;
        SceneManager.LoadScene(1);
    }

    IEnumerator ToMenu()
    {
        yield return new WaitForSeconds(8);
        SceneNumber = 2;
        SceneManager.LoadScene(2);
    }
}
