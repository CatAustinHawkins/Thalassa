using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    public float timervalue;

    public GameObject WinScreenScore;

    public Win WinScript;

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
