using TMPro;
using UnityEngine;

public class Points : MonoBehaviour
{

    private int score; //Cuida da pontuação

    public static Points instance;

    [SerializeField] TextMeshProUGUI score_text;

    void Awake()
    {
        if (instance == null) instance = this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Increase_Score(int amount) //Cuida da pontuação
    {
        score += amount;
        score_text.text = "Score: " + score; //Cuida do texto da pontuação
    }
}
