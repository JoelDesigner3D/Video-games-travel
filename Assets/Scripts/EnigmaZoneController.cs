using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnigmaZoneController : MonoBehaviour
{

    [SerializeField] TestManager testManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("EnigmaZoneController > onTriggerEnter event");
        if (other.tag == "Player")
        {
            Debug.Log("EnigmaZoneController > onTriggerEnter > "+ other.tag);
            testManager.displayEnigme();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            testManager.hideEnigme();
        }
    }
    
}
