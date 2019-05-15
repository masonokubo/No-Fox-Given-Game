using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class IntroLevel : MonoBehaviour {

	public void PlayButtonClick()
    {
        SceneManager.LoadScene("FoxRunScene");
    }

    public void ExitButtonClick()
    {
        Application.Quit();
    }
}
