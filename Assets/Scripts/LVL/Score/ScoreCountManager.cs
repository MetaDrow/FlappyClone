using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreCountManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _score;
    private int _scoreCount;

    private void Update()
    {
        // OnScoreCount();
        _score.text = _scoreCount.ToString();
    }
    private void Start()
    {
        EventManager.instance.onCountScoreTriggerEnter += OnScoreCount;
    }

    private void OnScoreCount()
    {
        _scoreCount++;
    }
}
