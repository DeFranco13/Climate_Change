using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public string levelToLoad;

    public void LevelLoader()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
