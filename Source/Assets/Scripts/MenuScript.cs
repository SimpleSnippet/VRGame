using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {
    private int buttonWidth = 400;
    private int buttonHeight = 25;

    void OnGUI()
    {
        Rect instructionsbutton = new Rect(
            Screen.width / 2 - (buttonWidth / 2), (2 * Screen.height / 3) - (buttonHeight / 2)+buttonHeight, buttonWidth, buttonHeight);
        Rect oneplayerstartbutton = new Rect(
             Screen.width / 2 - (buttonWidth / 2), (2 * Screen.height / 3) - (buttonHeight / 2)+2*buttonHeight, buttonWidth, buttonHeight);
        Rect twoplayerstartbutton = new Rect(
             Screen.width / 2 - (buttonWidth / 2), (2 * Screen.height / 3) - (buttonHeight / 2)+(3)*buttonHeight, buttonWidth, buttonHeight);
        Rect quitbutton = new Rect(
            Screen.width / 2 - (buttonWidth / 2), (2 * Screen.height / 3) - (buttonHeight / 2)+4*buttonHeight, buttonWidth, buttonHeight);

        if (GUI.Button(instructionsbutton, "How to Play"))
        {
            SceneManager.LoadScene("HowToMenu");
        }
        if (GUI.Button(oneplayerstartbutton, "1 Player"))
        {
           SceneManager.LoadScene("MainGame");

        }
        if (GUI.Button(twoplayerstartbutton, "2 Players"))
        {
            SceneManager.LoadScene("TwoPGame");
        }
        else if(GUI.Button(quitbutton, "Quit"))
        {
            Application.Quit();
        }
    }
}
