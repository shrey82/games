using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpwaner : EnemyDamage
{

    public GameObject obstacle;
    public float maxX, minX, maxY, minY, TimeBetweenSpawn, SpawnTime;
    [SerializeField] private LayerMask playerLayer;

    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > SpawnTime)
        {
            Spawn();
            SpawnTime = Time.time + TimeBetweenSpawn;
        }
    }

    
    void Spawn()
    {
        float x = Random.Range(minX, maxX);
        float y = Random.Range(minY, maxY);
        Instantiate(obstacle, transform.position + new Vector3(x, transform.position.y, 0), Quaternion.identity);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D(collision);
        //Stop(); //Stop spikehead once he hits something
    }
}




