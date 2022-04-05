using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManger : MonoBehaviour
{
    public string sceneName;

    public void SceneCange()
    {
        SceneManager.LoadScene(sceneName);
    }
}
