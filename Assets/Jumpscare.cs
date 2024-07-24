using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jumpscare : MonoBehaviour
{
    public GameObject player, jumpscarecam;
    public Animator monsteranim;
    public float jumpscaretime;
    //public string sceneName;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player.SetActive(false);
            jumpscarecam.SetActive(true);
            StartCoroutine(changescene());
            monsteranim.SetTrigger("jumpscare");
        }
    }

    IEnumerator changescene()
    {
        yield return new WaitForSeconds(jumpscaretime);
        SceneManager.LoadScene(2);
    }
}
