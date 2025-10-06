using UnityEngine;

public class KeepHabitat : MonoBehaviour
{
    private static KeepHabitat instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject); // evita duplicados
        }
    }
}