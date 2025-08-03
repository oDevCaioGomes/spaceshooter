using UnityEngine;

public class Press_W : MonoBehaviour
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
        W();
    }

    private void W()
    {
        if (Input.GetKey(KeyCode.W)) anim.SetBool("Press_W", true);
        else anim.SetBool("Press_W", false);
    }
}
