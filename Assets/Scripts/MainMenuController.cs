using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void OnPlayBtn()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void OnOptionsBtn()
    {
        Debug.Log("Options Pressed. Implementation TBD");
    }
}
