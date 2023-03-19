using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterTrigger : MonoBehaviour
{

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(CompareTag("Player") && other.CompareTag("Death"))
        {
            SceneManager.LoadScene("LVL");
        }
    }
}
