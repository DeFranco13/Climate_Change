using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SetScore : MonoBehaviour
{
    private int score;

    void Start()
    {
        GetComponent<TextMeshProUGUI>().text = $"Survived until: {score}";
    }

    void OnEnable()
    {
        score = PlayerPrefs.GetInt("score");
    }
}
