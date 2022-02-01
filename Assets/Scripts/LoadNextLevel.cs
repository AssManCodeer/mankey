using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextLevel : MonoBehaviour
{

   
    public GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        Debug.Log("Trigger");
        if (collision.gameObject.tag == "Player")
        {
            
            StartCoroutine(Winne());
        }
    }
    public IEnumerator Winne()
    {
        yield return new WaitForSeconds(2);

        
        DontDestroyOnLoad(player);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
