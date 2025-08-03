using UnityEngine;

public class Press_Z : MonoBehaviour
{
    private Animator anim;
    [SerializeField] private GameObject go;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        Aperta_Z();
    }
    private void Aperta_Z()
    {
        if (Input.GetKey(KeyCode.Z)) anim.SetBool("Aperta_Z", true);
        else anim.SetBool("Aperta_Z", false);

        if (Input.GetKeyDown(KeyCode.Z))
        {
            GameObject effect = Instantiate(go, transform.position, Quaternion.identity);
            Destroy(effect, 0.3f);
        }
    }
}
