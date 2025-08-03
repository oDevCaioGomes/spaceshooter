using UnityEngine;

public class Space_Laser : MonoBehaviour
{

    [SerializeField] float laser_speed;
    public int dano;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Laser();
    }

    public void Laser()
    {
        transform.position += new Vector3(0, laser_speed, 0) * Time.deltaTime;
    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
