using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGhost : MonoBehaviour
{

public Transform enemy;
public Transform SpawnPoint;
    void Start()
    {
        
    }
void RespawnEnemy ()
{
Instantiate(enemy, SpawnPoint.transform.position, SpawnPoint.transform.rotation);
}
void OnTriggerEnter2D (Collider2D other)
{
if (other.gameObject.tag == "Player")
{
RespawnEnemy();
}
}
    void Update()
    {
        
    }
}
