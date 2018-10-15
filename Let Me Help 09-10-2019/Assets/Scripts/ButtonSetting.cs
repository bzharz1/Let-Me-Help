using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonSetting : MonoBehaviour {

    public static int releaseLevelStatic = 1;
    public int releaseLevel;

    public string nextLevel;


	// Use this for initialization
	void Awake () {

        if (PlayerPrefs.HasKey ("Level"))
        {
            releaseLevelStatic = PlayerPrefs.GetInt("Level", releaseLevelStatic);
        }
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ButtonNextLevel ()
    {
        SceneManager.LoadScene (nextLevel);

        if (releaseLevelStatic <= releaseLevel)
        {
            releaseLevelStatic = releaseLevel;
            PlayerPrefs.SetInt("Level", releaseLevelStatic);
        }
    }

    public void LevelSelect ()
    {
        SceneManager.LoadScene ("LevelSelect");
    }
}
