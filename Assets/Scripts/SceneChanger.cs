using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {

    public void ChangeScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}
