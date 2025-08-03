using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] float spawn_rate;
    [SerializeField] GameObject enemy;
    [SerializeField] bool invoke = true;

    float x_min, x_max, x_rand, y_spawn;
    void Start()
    {
        Spawn_Position();
    }

    // Update is called once per frame
    void Update()
    {
        if (invoke)
        {  
            Invoking_Spawn();
        }
    }

    //Make the spawner of the enemys appear above and out of the screen.
    void Spawn_Position()
    {
        x_min = Camera.main.ViewportToWorldPoint(new Vector3(0.3f, 0, 0)).x;
        x_max = Camera.main.ViewportToWorldPoint(new Vector3(0.7f, 0, 0)).x;
        y_spawn = Camera.main.ViewportToWorldPoint(new Vector3(0, 1.25f, 0)).y;
    }

    void Invoking_Spawn()
    {
        if (Game_Counter.counter)
        {
            InvokeRepeating("Spawn_Enemy", 1f, spawn_rate); //Pick the method and say where is going to spawn the enemys
            invoke = false;
        }
    }

    void Spawn_Enemy()
    {
        x_rand = Random.Range(x_min, x_max); //Make the enemy spawn on random places
        Instantiate(enemy, new Vector3(x_rand, y_spawn, 0), Quaternion.identity);
    }
}
