using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour
{
    public string levelToLoad;

    public void LevelLoader()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
