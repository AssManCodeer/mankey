using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen2 : MonoBehaviour
{
    public GameObject enemy;
    public Animator DoorR;
    public Animator DoorL;
    public BoxCollider coller;
    public GameObject EnemyPrefab;
    public GameObject enemyspawn;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        enemy = GameObject.FindGameObjectWithTag("Science");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if(enemy == null)
            {
                enemy = Instantiate(EnemyPrefab, enemyspawn.transform.position, enemyspawn.transform.rotation);
            }
            DoorL.SetTrigger("Open");
            DoorR.SetTrigger("Open");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            DoorL.SetTrigger("Close");
            DoorR.SetTrigger("Close");
        }
    }
}