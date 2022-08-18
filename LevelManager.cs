using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

//singleton: only one copy of script, not on > 1 object

public class LevelManager : MonoBehaviour //change unity scene w/ built in scene manager 
{
    public static LevelManager Instance; //variable

    void Awake()
    {
        Instance = this; //save LevelManager copy to Instance var
    }

    public void LoadLevel(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex);
    }

}
