using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Bar_Controller : MonoBehaviour
{

    [SerializeField] private Image bar;
    private bool time = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //bar = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            if (time)
            {
                bar.fillAmount -= 0.044f;
                time = false;
                StartCoroutine(Next_Shield());
            }
        }
        if (bar.fillAmount <= 0.01f) bar.fillAmount = 0;
    }

    private IEnumerator Next_Shield()
    {
        yield return new WaitForSeconds(1f);
        time = true;
    }
}
