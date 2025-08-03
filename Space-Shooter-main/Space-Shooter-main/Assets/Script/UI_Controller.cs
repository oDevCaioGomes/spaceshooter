using UnityEngine;
using UnityEngine.UI;

public class UI_Controller : MonoBehaviour
{

    public static UI_Controller instance;
    [SerializeField] private Sprite empty_heart, full_heart;
    [SerializeField] private Image[] hearts_icon;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        if (instance == null) instance = this;
    }

    public void Update_Space_Display(int health, int max_health)
    {
        for (int i = 0; i < hearts_icon.Length; i++)
        {
            if (i < health) hearts_icon[i].enabled = true;
            else hearts_icon[i].enabled = false;

            if (i < max_health) hearts_icon[i].enabled = true;
            else hearts_icon[i].enabled = false;
        }
    }
}
