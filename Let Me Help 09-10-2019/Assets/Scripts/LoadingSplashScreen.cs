using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingSplashScreen : MonoBehaviour {

    public float loadingTime;
    public Image loadingBar;
//    public Text percent;
    public string loadLevel;

	// Use this for initialization
	void Start () {

        loadingBar.fillAmount = 0;

    }

	
	// Update is called once per frame
	void Update () {

	    if (loadingBar.fillAmount <= 1)
        {
            loadingBar.fillAmount += 1.0f / loadingTime * Time.deltaTime;
        }
        if (loadingBar.fillAmount == 1.0f)
        {
//            Destroy (gameObject);
            SceneManager.LoadScene (loadLevel);
        }
//        percent.text = (loadingBar.fillAmount * 100).ToString ("f0");
	}
    
}
