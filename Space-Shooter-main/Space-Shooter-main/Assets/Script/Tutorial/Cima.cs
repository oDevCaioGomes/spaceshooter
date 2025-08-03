using UnityEngine;

public class Cima : MonoBehaviour
{
    private Animator anim;

    [SerializeField] private GameObject go;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Aperta_Cima();
    }

    private void Aperta_Cima()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetBool("Aperta_Cima", true);
        }
        else anim.SetBool("Aperta_Cima", false);

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            GameObject effect = Instantiate(go, transform.position, Quaternion.identity);
            Destroy(effect, 0.3f);
        }
        
    }
}
