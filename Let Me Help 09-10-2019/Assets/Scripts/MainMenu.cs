using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public string startGame;
    public string levelSelect;
    public string contactUs;

    public string [] levelNames;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void StartGame ()
    {
        SceneManager.LoadScene(startGame);

        for(int i=0; i < levelNames.Length; i++)
        {
            PlayerPrefs.SetInt(levelNames[i],0);
        }
    }

    public void ContinueGame ()
    {
        SceneManager.LoadScene(levelSelect);
    }

    public void ContactUs ()
    {
        SceneManager.LoadScene(contactUs);
    }
}
