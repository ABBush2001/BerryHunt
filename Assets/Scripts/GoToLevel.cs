using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToLevel : MonoBehaviour
{
    //method takes build index (integer) and loads the scene
    public void loadTheLevel(int buildNum)
    {
        SceneManager.LoadScene(buildNum);
    }
}
