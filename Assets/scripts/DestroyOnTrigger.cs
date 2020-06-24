using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class DestroyOnTrigger : MonoBehaviour
{
    public GameObject objToDestroy;
    public GameObject effect;
    public string leveltoload;
    private bool counter = false;
    private float timer = 7f;
   


    // Use this for initialization
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") { 

            Instantiate(effect, objToDestroy.transform.position, objToDestroy.transform.rotation);

            Destroy(objToDestroy, 6.5F);
            counter = true;
        }

        
    }

    void Update()
    {
        

        if (counter == true)
        {
            timer -= Time.deltaTime;

            if (timer < 0)
            {
                Application.LoadLevel(leveltoload);
            }
            
        }

        
    }

}
