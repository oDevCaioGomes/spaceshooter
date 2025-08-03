using UnityEngine;

public class Esquerda : MonoBehaviour
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
        Aperta_Esquerda();
    }
    private void Aperta_Esquerda()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) anim.SetBool("Aperta_Esquerda", true);
        else anim.SetBool("Aperta_Esquerda", false);
        
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GameObject effect = Instantiate(go, transform.position, Quaternion.identity);
            Destroy(effect, 0.3f);
        }
    }
}
