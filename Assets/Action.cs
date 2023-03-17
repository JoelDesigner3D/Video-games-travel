using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action : MonoBehaviour
{
    private TouchScreenKeyboard screenKeyboard;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowText()
    {
        Debug.Log("Clavier ou es tu ?");

        //screenKeyboard = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);

        TouchScreenKeyboard.Open("");
    }
}
