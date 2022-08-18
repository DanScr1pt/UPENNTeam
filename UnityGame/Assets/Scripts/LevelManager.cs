using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance;

    void Awake ()
    {
        Instance = this; 
    }

    public void loadLevel( int BuildIndex)
    {
        SceneManager.LoadScene(BuildIndex);
    }
}
