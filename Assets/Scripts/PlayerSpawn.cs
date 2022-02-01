using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    public Transform SpawnPoint;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Player, SpawnPoint.transform.position, SpawnPoint.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
