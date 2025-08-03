using Unity.VisualScripting;
using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] float speed;

    [SerializeField] GameObject laser;

    [SerializeField] Rigidbody2D rb;

    [SerializeField] private bool next_shot;

    private GameObject player;

    private Points point;

    //Preciso chegar se o objeto do player realmente exite.

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, speed, 0) * Time.deltaTime;
        if (player)
        {
            Shot();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Points.instance.Increase_Score(10); //Ao morrer, dará 10 pontos ao jogador.
        
        if (collision.CompareTag("Shot")) Destroy(gameObject);
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void Shot()
    {
        if (next_shot)
        {
            Instantiate(laser, transform.position, Quaternion.identity);
            next_shot = false;
            StartCoroutine(Next_Shot());
        }
    }

    private IEnumerator Next_Shot()
    {
        yield return new WaitForSeconds(1.0f);
        next_shot = true;
    }
}
