using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player = null;
    public GameObject Enemy = null;
    public GameObject[] monsterspawnpoint = null;


    // Start is called before the first frame update
    void Start()
    {
        SpawnPlayer();
        SpawnEnemy();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnPlayer()
    {
            player = Instantiate(player, transform.position, transform.rotation);
            player.AddComponent<movement>();
        player.AddComponent<health>();
    }
    void SpawnEnemy()
    {
        GameObject Spawngroup = new GameObject("spawngroup");
        foreach (GameObject gameObject in monsterspawnpoint)
        {
            Enemy = Instantiate(Enemy, gameObject.transform.position, gameObject.transform.rotation, Spawngroup.transform);
        }
    }
}
