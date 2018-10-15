using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ContactUs : MonoBehaviour {

    public string backToMenu;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void BackToMainMenu ()
    {
        SceneManager.LoadScene(backToMenu);
    }
}

