using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameWin : MonoBehaviour
{

    public void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene("WinMenu");
    }

    public void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("WinMenu");

    }

}
