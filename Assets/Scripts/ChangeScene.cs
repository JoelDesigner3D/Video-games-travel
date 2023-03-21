using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class ChangeScene : MonoBehaviour
{
    public int roomDurationInMinutes = 30;
    [SerializeField] int breakDurationAtTheEnd = 0;
    bool isLearningRoom;
    
    private void Start()
    {
        isLearningRoom = tag == "LearningRoom";

        if (!isLearningRoom)
        {
            roomDurationInMinutes = MainManager.Instance.displayDuration;
        }

        StartCoroutine(gameObject.GetComponent<Timer>().InvokeDelayed(roomDurationInMinutes, MoveToNextRoom));
    }

    public void MoveToNextRoom()
    {
        if (tag == "EndRoom")
        {
#if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
#else
            Application.Quit();
#endif
        }

        else if (!isLearningRoom)
        {
            SceneManager.LoadScene(MainManager.Instance.sceneIndex + 1);
        }
        
        else if (SceneManager.GetActiveScene().buildIndex == SceneManager.sceneCountInBuildSettings - 3)
        {
            SceneManager.LoadScene(SceneManager.sceneCountInBuildSettings - 1);
        }
        
        else if (breakDurationAtTheEnd == 0) {
            SceneManager.LoadScene(++MainManager.Instance.sceneIndex);
        }

        else
        {
            MainManager.Instance.displayDuration = breakDurationAtTheEnd;
            SceneManager.LoadScene(SceneManager.sceneCountInBuildSettings - 2);
        }

    }
}
