using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void SwitchScene()
    {
        SceneManager.LoadScene(1);
    }
}
