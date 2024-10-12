using UnityEngine;
using TMPro;
public class Win : MonoBehaviour
{
    //0.875 - S
    //0.75 - A+
    //0.625 - A
    // 0.5 - B
    //0.375 - C
    //0.25 - D
    //0.125 - E

    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI GradeText;
    public float ScoreValue;

    public float Maths;

    void Update()
    {

        Maths = 1 - ScoreValue;
        if(ScoreValue > 0.125f)
        {
            GradeText.text = "E";
            ScoreText.text = (Maths / 0.00416f).ToString();
        }

        if (ScoreValue > 0.25f)
        {
            GradeText.text = "D";
            ScoreText.text = (Maths / 0.00416f).ToString();

        }

        if (ScoreValue > 0.375f)
        {
            GradeText.text = "C";
            ScoreText.text = (Maths / 0.00416f).ToString();

        }

        if (ScoreValue > 0.5f)
        {
            GradeText.text = "B";
            ScoreText.text = (Maths / 0.00416f).ToString();

        }

        if (ScoreValue > 0.625f)
        {
            GradeText.text = "A";
            ScoreText.text = (Maths / 0.00416f).ToString();

        }

        if (ScoreValue > 0.75f)
        {
            GradeText.text = "A+";
            ScoreText.text = (Maths / 0.00416f).ToString();

        }

        if (ScoreValue > 0.825f)
        {
            GradeText.text = "S";
            ScoreText.text = (Maths / 0.00416f).ToString();

        }
    }
}
