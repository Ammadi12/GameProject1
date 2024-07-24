using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Playtime()
    {
        SceneManager.LoadScene(1);
    }
    public void Main()
    {
        SceneManager.LoadScene(0);
    }
}
