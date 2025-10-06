using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject Canvas;

    public void PlayGame()
    {
        // Desactivar el Canvas antes de cargar la nueva escena
        if (Canvas != null)
            Destroy(Canvas);

        SceneManager.LoadScene("GameScene");
    }
}
