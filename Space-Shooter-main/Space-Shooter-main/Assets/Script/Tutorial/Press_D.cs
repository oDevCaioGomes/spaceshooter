using UnityEngine;

public class Press_D : MonoBehaviour
{

    private Animator anim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        D();
    }
    private void D()
    {
        if (Input.GetKey(KeyCode.D)) anim.SetBool("Press_D", true);
        else anim.SetBool("Press_D", false);
    }
}
