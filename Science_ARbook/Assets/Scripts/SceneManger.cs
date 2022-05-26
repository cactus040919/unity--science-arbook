using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManger : MonoBehaviour
{
    public string sceneName;
    int reloadSceneName;

    public void SceneCange()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void SceneReload()
    {
        reloadSceneName = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(reloadSceneName);
    }


}
