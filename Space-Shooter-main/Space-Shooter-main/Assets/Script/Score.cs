using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static Score instance;
    public TextMeshProUGUI scoreText;
    //public TextMeshProUGUI highScoreText;
    int score = 0;
    //int highScore = 0;

 
    private void Awake()
    {
        instance = this;   
    }

    void Start()
    {
        scoreText.text = score.ToString() + "SCORE";
        //highScoreText.text = "HIGHSCORE:" + highScore.ToSafeString();
    }

    public void AddPoint()
    {
        score += 1;
        scoreText.text = score.ToString() + "Score:";
    }
}
