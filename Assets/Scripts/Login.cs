using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    [SerializeField] string motDePasse;
    [SerializeField] TextMeshProUGUI infoText;
    [SerializeField] TMP_InputField inputTextField;

    void Start()
    {
        
    }

    public void CheckPasswordAndLoadScene()
    {
        if (inputTextField.text == motDePasse)
        {
            SceneManager.LoadScene(1);
        }

        else
        {
            inputTextField.text = "";
            infoText.text = "Le mot de passe saisi est erroné, ressaisis-le en faisant attention à la casse.";
        }
    }
}
