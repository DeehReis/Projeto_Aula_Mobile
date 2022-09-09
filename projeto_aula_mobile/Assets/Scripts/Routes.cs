using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Routes : MonoBehaviour
{
    public void goToSubscribe()
    {
        SceneManager.LoadScene("Subscribe", LoadSceneMode.Single);
    }

    public void goToOpening()
    {
        SceneManager.LoadScene("Opening", LoadSceneMode.Single);
    }

    public void goToWorkshops()
    {
        SceneManager.LoadScene("Workshop", LoadSceneMode.Single);
    }

    public void goToLectures()
    {
        SceneManager.LoadScene("Lecture", LoadSceneMode.Single);
    }

    public void goToCine()
    {
        SceneManager.LoadScene("CineBarao", LoadSceneMode.Single);
    }

    public void goToCredits()
    {
        SceneManager.LoadScene("Credits", LoadSceneMode.Single);
    }
}