using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ResetAll : MonoBehaviour {

    public LevelManagerNew theLevelManagerNew;

    public bool clicked;

    public GameObject ResetLevel;

	// Use this for initialization
	void Start () {

        theLevelManagerNew = FindObjectOfType<LevelManagerNew>();
        clicked = false;
	}
	
	// Update is called once per frame
	void Update () {

        if(!clicked)
        {
            PlayerPrefs.SetInt("LevelSelect",1);
//            clicked = !clicked;
        }
        else
        {
//            clicked = !clicked;
//           clicked = true;
            Reset();
	    }
	}

    void Reset ()
    {
        clicked = true;
//
//        if (clicked)
//        {
            theLevelManagerNew.DeleteAll();
//        }
//
    }
}
