using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    // Update is called once per frame  
    public void ExitGame()
    {
        Application.Quit();
    }
}
