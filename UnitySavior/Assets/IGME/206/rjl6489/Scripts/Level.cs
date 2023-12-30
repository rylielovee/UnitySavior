using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    public string requiredKey1 = "";
    public string nextRoom1 = "";
    public string requiredKey2 = "";
    public string nextRoom2 = "";

    public bool HasRightKey1(List<string> keys)
    {
        return keys.Contains(requiredKey1.ToLower());
    }

    public bool HasRightKey2(List<string> keys)
    {
        return keys.Contains(requiredKey2.ToLower());
    }

    public IEnumerator GoToNextLevel1()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadSceneAsync(nextRoom1);
    }

    public IEnumerator GoToNextLevel2()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadSceneAsync(nextRoom2);
    }
}
