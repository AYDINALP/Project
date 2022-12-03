using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject Dead, Starrt;
    public bird kus;
    void Start()
    {
        Time.timeScale = 0;
        Dead.SetActive(false);
    }
    public void Play()
    {
        Time.timeScale = 1;
        Starrt.SetActive(false);
    }
    void Update()
    {
        if (kus.ddead == true)
        {
            Dead.SetActive(true);
        }
    }
    public void Deaad()
    {
        SceneManager.LoadScene("Level");
    }
}
