using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManagerNew : MonoBehaviour {

    public int level;
    public Image locked;
    public Text text;

    private string levelString;


    private string resetAll;
    public ResetAll theResetAll;


	// Use this for initialization
	void Start () {

        theResetAll = FindObjectOfType<ResetAll>();
        
// TO LOCK (EXCEPT LVL -1) ALL THE LEVELS BEFOR EXPORT THE GAME
//        DeleteAll();
    
        if (ButtonSetting.releaseLevelStatic >= level)
        {
            LevelUnlocked ();
        } else {
            LevelLocked ();
        }
	}
	
    public void LevelSelect(string _level)
    {
        levelString = _level;
        SceneManager.LoadScene (levelString);
    } 


    void LevelLocked ()
    {
        GetComponent<Button> ().interactable = false;

        locked.enabled = true;
        text.enabled = false;
    }

    public void LevelUnlocked ()
    {
        GetComponent<Button> ().interactable = true;

        locked.enabled = false;
        text.enabled = true;
    }

    public void DeleteAll()
    {
//        SceneManager.LoadScene(DeleteAll);
        PlayerPrefs.DeleteAll();
//        theResetAll.clicked = true;

    }
}
