using UnityEngine;

public class Cursor_Manager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor_Locked();
        Cursor.lockState = CursorLockMode.Confined;
    }

    // Update is called once per frame
    void Update()
    {
        if (Game_Counter.counter) Cursor_Unlocked();
        if (Input.GetKeyDown(KeyCode.Escape)) Cursor.visible = true;
    }

    private void Cursor_Locked()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Cursor_Unlocked()
    {
        Cursor.lockState = CursorLockMode.None;
    }

}
