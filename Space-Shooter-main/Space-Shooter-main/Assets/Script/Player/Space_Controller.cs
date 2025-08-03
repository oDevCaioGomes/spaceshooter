using System.Collections;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using UnityEngine.UI;

public class Space_Controller : MonoBehaviour
{
    [SerializeField] private int character_velocity = 5;

    [SerializeField] private bool mouse;


    [SerializeField] private bool next_shot;

    [SerializeField] private int imunity_quantity;

    [SerializeField] GameObject laser;
    private Collider2D col;
    private Animator anim;

    public int currentLife;
    public int maximumLife;

    public bool hasShield;
    
    public Image[] Vida;


    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
        col = GetComponent<Collider2D>();
        rb = GetComponent<Rigidbody2D>();

        currentLife = maximumLife;
    }

    // Update is called once per frame
    void Update()
    {
        if (Game_Counter.counter)
        {
            Keyboard_Move();
            Mouse_Move();
            Keyboard_Shot();
            Mouse_Shot();
            Imunity();
        }
        HealthLogic();

    }
    

void HealthLogic()
    {
        for (int i = 0; i < Vida.Length; i++)
        {
            if (Vida[i] == null) continue; // Evita erro se algum slot estiver vazio
            if (i < currentLife)
            {
                Vida[i].enabled = true;
            }
            else
            {
                Vida[i].enabled = false;
            }

        }

    }

    public void DamageToTheEnemy(int damagetake)
    {
        if (hasShield == false)
        {
            currentLife -= damagetake;


            if (currentLife <= 0)
            {
                Time.timeScale = 0;
               //GameOverTeste.SetActive(true);
            }
        }
    }


    public void Keyboard_Move()
    {
        if (!mouse)
        {
            rb.linearVelocity = new Vector2(Input.GetAxisRaw("Horizontal") * character_velocity, Input.GetAxisRaw("Vertical") * character_velocity);
        }
    }
    private void Mouse_Move()
    {
        if (mouse)
        {
            Vector3 converted_position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(converted_position.x, converted_position.y, 0);
        }
    }

    private void Keyboard_Shot()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            if (next_shot)
            {
                Instantiate(laser, transform.position, Quaternion.identity);
                next_shot = false;
                StartCoroutine(Next_Shot());
            }
        }
    }
    private void Mouse_Shot()
    {

        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (next_shot)
            {
                Instantiate(laser, transform.position, Quaternion.identity);
                next_shot = false;
                StartCoroutine(Next_Shot());
            }
        }
    }

    private IEnumerator Next_Shot()
    {
        yield return new WaitForSeconds(0.5f);
        next_shot = true;
    }

    private void Imunity()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            if (imunity_quantity > 0)
            {
                col.enabled = false;
                StartCoroutine(Imunity_Time());
                anim.SetBool("Escudo", true);
                imunity_quantity--;
            }
        }
    }

    private IEnumerator Imunity_Time()
    {
        yield return new WaitForSeconds(1f);
        col.enabled = true;
        anim.SetBool("Escudo", false);
    }
}


