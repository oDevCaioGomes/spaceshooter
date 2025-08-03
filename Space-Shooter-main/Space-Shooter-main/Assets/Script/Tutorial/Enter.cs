using UnityEngine;

public class Enter : MonoBehaviour
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
        Aperta_Enter();
    }
    private void Aperta_Enter()
    {
        if (Input.GetKey(KeyCode.Return)) anim.SetBool("Aperta_Enter", true);
        else anim.SetBool("Aperta_Enter", false);
        if (Input.GetKeyDown(KeyCode.Return))
        {
            GameObject effect = Instantiate(go, transform.position, Quaternion.identity);
            Destroy(effect, 0.3f);
        }
    }
}
