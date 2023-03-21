using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CountdownDisplay : MonoBehaviour
{
    //[SerializeField] TextMeshProUGUI text;
    int totalTime;
    DateTime initialTime;
    TimeSpan timeElapsed;
    int minutesRemaining;
    int secondsRemaining;
    int timeRemaining;
    bool isLearningRoom;

    void Start()
    {
        initialTime = DateTime.Now;
        isLearningRoom = tag == "LearningRoom";

        if (!isLearningRoom)
        {
            totalTime = MainManager.Instance.displayDuration;
        }

        else
        {
            totalTime = gameObject.GetComponent<ChangeScene>().roomDurationInMinutes;
        }
    }

    void Update()
    {
        timeElapsed = DateTime.Now - initialTime;
        timeRemaining = totalTime * 60 - (int)timeElapsed.TotalSeconds;
        minutesRemaining = timeRemaining / 60;
        secondsRemaining = timeRemaining % 60;
        string min = minutesRemaining > 1 ? "minutes" : "minute";
        string sec = secondsRemaining > 1 ? "secondes" : "seconde";

        if (tag == "EndRoom")
        {
            gameObject.GetComponent<TextMeshProUGUI>().text = string.Format("Cette expérience est désormais terminée, merci d'y avoir participé. Cette application s'auto-détruira dans {0:00} " + min + " et {1:00} " + sec + ".", minutesRemaining, secondsRemaining);
        }
        else if (!isLearningRoom)
        {
            gameObject.GetComponent<TextMeshProUGUI>().text = string.Format("Vous êtes en pause pendant encore {0:00} " + min + " et {1:00} " + sec + ".", minutesRemaining, secondsRemaining);
        }

        else
        {
            if (timeRemaining <= 90 && timeRemaining >= 0)
            {
                gameObject.GetComponent<TextMeshProUGUI>().text = string.Format("Cette salle se fermera dans {0:00} " + min + " et {1:00} " + sec + ". Rends-toi à la radio pour un petit test.", minutesRemaining, secondsRemaining);
            }
        }

    }

    void NextAction()
    {

    }
}
