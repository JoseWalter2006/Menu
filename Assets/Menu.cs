using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    
    public void ComeçarJogo()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void SairDoJogo()
    {
        Application.Quit();
    }
}
