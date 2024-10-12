using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{

    public PlayerScore Score; 
    public Slider OxygenTimer;

    //timer
    //0.00416

    public float TimerValue = 1f;

    void Start()
    {
        TimerValue = 1f;
        StartCoroutine(TimerWait());
    }

    void Update()
    {
        if(TimerValue < 0)
        {
            SceneManager.LoadScene("DieMenu");
        }

        Score.timervalue = TimerValue;
    }

    IEnumerator TimerWait()
    {
        yield return new WaitForSeconds(1f);
        TimerValue = TimerValue - 0.00416f;
        OxygenTimer.value = TimerValue;
        StartCoroutine(TimerWait());
    }
}
