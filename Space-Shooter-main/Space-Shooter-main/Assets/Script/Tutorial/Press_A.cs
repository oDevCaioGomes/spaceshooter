using UnityEngine;

public class Press_A : MonoBehaviour
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
        A();
    }

    private void A()
    {
        if (Input.GetKey(KeyCode.UpArrow)) anim.SetBool("Aperta_Cima", true);
        else anim.SetBool("Aperta_Cima", false);
    }
}
