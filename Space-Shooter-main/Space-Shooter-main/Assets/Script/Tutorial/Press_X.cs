using UnityEngine;

public class Press_X : MonoBehaviour
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
        Aperta_X();
    }
    private void Aperta_X()
    {
        if (Input.GetKey(KeyCode.X)) anim.SetBool("Aperta_X", true);
        else anim.SetBool("Aperta_X", false);

        if (Input.GetKeyDown(KeyCode.X))
        {
            GameObject effect = Instantiate(go, transform.position, Quaternion.identity);
            Destroy(effect, 0.3f);
        }
    }
}
