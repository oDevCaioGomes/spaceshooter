using UnityEngine;

public class Baixo : MonoBehaviour
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
        Aperta_Baixo();
    }
    private void Aperta_Baixo()
    {
        if (Input.GetKey(KeyCode.DownArrow)) anim.SetBool("Aperta_Baixo", true);
        else anim.SetBool("Aperta_Baixo", false);

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            GameObject effect = Instantiate(go, transform.position, Quaternion.identity);
            Destroy(effect, 0.3f);
        }
    }
}
