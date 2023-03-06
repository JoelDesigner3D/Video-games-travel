using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class TestManager : MonoBehaviour
{

    [SerializeField] Canvas userMessage;
    [SerializeField] GameObject exercice;

    public bool testPassed = false;

    // Start is called before the first frame update
    void Start()
    {
        userMessage.enabled = false;
        exercice.SetActive(false);
    }


    public void displayEnigme()
    {
        /*
        if (testPassed)
        {
            return;
        }
        */
        userMessage.enabled = true;
        exercice.SetActive(true);
    }

    public void hideEnigme()
    {
        /*
        if (testPassed)
        {
            return;
        }
        */
        userMessage.enabled = false;
        exercice.SetActive(false);
    }

    public void SetPassedTest(bool result)
    {
        if (result == true)
        {
            Debug.Log("the door is unlocked!");
            //testPassed = true;
            //userMessage.enabled = false;
        }
        else
        {
            Debug.Log("the door is locked!");
        }
    }


}
