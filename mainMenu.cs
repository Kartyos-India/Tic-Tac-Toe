using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public void PlayGame2v2()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void PlayGameVsAI(){
        SceneManager.LoadSceneAsync(2);
    }
}

