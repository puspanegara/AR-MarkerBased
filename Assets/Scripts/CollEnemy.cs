using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollEnemy : MonoBehaviour
{
    public GameObject losePanel;

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ball")
        {
            losePanel.SetActive(true);
        }
    }
}
