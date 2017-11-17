using UnityEngine;
using UnityEngine.SceneManagement;

namespace Menus
{
    public class SceneChanger : MonoBehaviour {

        public void ChangeScene(int scene)
        {
            SceneManager.LoadScene(scene);
        }
    }
}
