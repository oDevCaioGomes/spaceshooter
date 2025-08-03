using System.Collections;
using UnityEngine;

public class Game_Counter : MonoBehaviour
{

    private IEnumerator coroutine;
    public static bool counter = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        coroutine = Start_Game(5.0f);
        StartCoroutine(coroutine);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public IEnumerator Start_Game(float wait_time)
    {
        yield return new WaitForSeconds(wait_time);
        counter = true;
    }
}
