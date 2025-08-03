using UnityEngine;

public class Direita : MonoBehaviour
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
        Aperta_Direita();
    }
    private void Aperta_Direita()
    {
        if (Input.GetKey(KeyCode.RightArrow)) anim.SetBool("Aperta_Direita", true);
        else anim.SetBool("Aperta_Direita", false);
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GameObject effect = Instantiate(go, transform.position, Quaternion.identity);
            Destroy(effect, 0.3f);
        }
    }
}
