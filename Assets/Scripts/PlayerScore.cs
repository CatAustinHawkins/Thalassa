using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerScore : MonoBehaviour
{

    public float timervalue;

    public GameObject WinScreenScore;

    public Win WinScript;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    private void Update()
    {
        WinScreenScore = GameObject.FindGameObjectWithTag("Win");
        if (WinScreenScore)
        {
            WinScript = WinScreenScore.GetComponent<Win>();
            WinScript.ScoreValue = timervalue;
        }
    }
}
