
using UnityEngine;

public class Shot : MonoBehaviour
{

    [SerializeField] float laser_speed;
    public int dano;


    [SerializeField] private GameObject player;
    private Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Pick_Components();
        Laser();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Pick_Components()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Laser()
    {
        Vector3 direction = player.transform.position - transform.position;
        rb.linearVelocity = direction;
        //transform.position += new Vector3(0, laser_speed, 0) * Time.deltaTime;
    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        other.gameObject.GetComponent<Space_Controller>().DamageToTheEnemy(dano);
    }
    
}
