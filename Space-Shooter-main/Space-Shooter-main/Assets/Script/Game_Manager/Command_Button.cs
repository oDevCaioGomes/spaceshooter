using UnityEngine;
using UnityEngine.SceneManagement;

public class Command_Button : MonoBehaviour
{

    [SerializeField] private string menu;
    [SerializeField] private string reset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Reset_Button();
        Menu_Screen();
    }


    private void Reset_Button()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(reset);
        }
    }

    private void Menu_Screen()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(menu);
        }
    }

}
