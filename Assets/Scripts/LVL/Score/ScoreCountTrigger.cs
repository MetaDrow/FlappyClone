using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreCountTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (CompareTag("ScoreTrigger") && other.CompareTag("Player"))
        {
            EventManager.instance.CountScoreTrigger();
        }
    }

}
