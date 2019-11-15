using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelExit : MonoBehaviour
{
    [SerializeField] float levelLoadDelay = 2f;
    [SerializeField] float levelExitSlowMotion = 0.2f;
    private void OnTriggerEnter2D(Collider2D otherColider)
    {
        StartCoroutine(LoadNextLeveL());
    }

    IEnumerator LoadNextLeveL()
    {
        Time.timeScale = levelExitSlowMotion;
        yield return new WaitForSecondsRealtime(levelLoadDelay);
        Time.timeScale = 1f;

        var currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
        
    }
}
