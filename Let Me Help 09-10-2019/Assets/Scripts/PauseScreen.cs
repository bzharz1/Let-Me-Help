using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PauseScreen : MonoBehaviour {

    public string levelSelect;
    public string mainMenu;

    public GameObject thePauseScreen;

    private PlayerController thePlayer;

    public bool paused;


	// Use this for initialization
	void Start () {

        thePlayer = FindObjectOfType <PlayerController>();	

        paused = false;
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void PauseGame ()
    {
        paused = !paused;

        if (paused)
        {
            Time.timeScale = 0;

            thePauseScreen.SetActive(true);

            thePlayer.canMove = false;

            paused = false;

        } 
//        else 
//        {
//            Time.timeScale = 1f;
//
//            thePauseScreen.SetActive(false);
//
//            thePlayer.canMove = true;
//
//
//        }
    }


    public void ResumeGame()
    {
        Time.timeScale = 1f;

        thePauseScreen.SetActive(false);

        thePlayer.canMove = true;
    }

    public void LevelSelect ()
    {
        SceneManager.LoadScene(levelSelect);

        Time.timeScale = 1f;
    }

    public void MainMenu ()
    {
        SceneManager.LoadScene (mainMenu);

        Time.timeScale = 1f;
    }
}
