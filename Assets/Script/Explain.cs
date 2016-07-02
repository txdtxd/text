using UnityEngine;
using System.Collections;

public class Explain : MonoBehaviour
{
    public GameObject panle;
    public GameObject expl;
    public GameObject cap;
    public GameObject panle2;
    public GameObject over;

    public UILabel label;


    public void Over(string str)
    {
        label.text = str;
        over.SetActive(true);
        panle2.SetActive(false);
        Time.timeScale = 0;
    }

    public void GameExplain()
    {
        panle.SetActive(false);
        expl.SetActive(true);
    }
    public void Ret()
    {
        panle.SetActive(true);
        expl.SetActive(false);
    }

    public void Restart()
    {
        Application.LoadLevel(0);
    }

    public void StartGame()
    {
        panle.SetActive(false);
        panle2.SetActive(true);
        cap.SetActive(true);
        Time.timeScale = 1;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
