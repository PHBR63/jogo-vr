using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FPSwalk : MonoBehaviour
{
    public AudioSource steps;
    public CharacterController character;
    public Vector3 positionToGo;
    bool safe = false;
 
    public AudioSource warning;
    // Start is called before the first frame update
    void Start()
    {
        positionToGo = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 diftowalk = positionToGo - transform.position;
        character.SimpleMove(diftowalk.normalized);

        steps.volume = diftowalk.magnitude - 1;

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Walkable"))
        {
            print("Safe");
            safe = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Walkable"))
        {
            print("notSafe");
            safe = false;
        }

    }
}
    
