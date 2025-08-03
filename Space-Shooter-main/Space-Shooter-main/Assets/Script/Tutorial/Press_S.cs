using UnityEngine;

public class Press_S : MonoBehaviour
{
    private Animator anim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        S();
    }

    private void S()
    {
        if (Input.GetKey(KeyCode.S)) anim.SetBool("Press_S", true);
        else anim.SetBool("Press_S", false);
    }
}
