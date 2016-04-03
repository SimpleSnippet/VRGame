using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour {
    private int buttonWidth = 200;
    private int buttonHeight = 50;

    void OnGUI()
    {
        Rect restartbutton = new Rect(
             Screen.width / 2 - (buttonWidth / 2)-(3/2)*buttonWidth, (2 * Screen.height / 3) - (buttonHeight / 2)+3*buttonHeight, buttonWidth, buttonHeight);
        Rect menubutton = new Rect(
             Screen.width / 2 - (buttonWidth / 2)+(3/2)*buttonWidth, (2 * Screen.height / 3) - (buttonHeight / 2)+3*buttonHeight, buttonWidth, buttonHeight);
        Rect resumebutton = new Rect(
             Screen.width / 2 - (buttonWidth / 2), (2 * Screen.height / 3) - (buttonHeight / 2) + 3 * buttonHeight, buttonWidth, buttonHeight);
        if (GUI.Button(restartbutton, "Restart"))
        {
            SceneManager.LoadScene("MainGame");

        }
        else if (GUI.Button(menubutton, "Back to Menu"))
        {
            SceneManager.LoadScene("Menu");
        }
        else if (GUI.Button(resumebutton, "Resume"))
        {

        }
    }
}
