using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicDestroyProtection : MonoBehaviour
{
    private static MusicDestroyProtection instance = null;

    private void Awake()
    {
        // Check if there is already an instance of this script attached to a game object
        if (instance != null && instance != this)
        {
            // If an instance already exists, destroy this game object
            Destroy(this.gameObject);
            return;
        }
        else
        {
            // If there is no instance, set this script as the instance
            instance = this;
        }

        // Set this game object to not be destroyed on scene change
        DontDestroyOnLoad(this.gameObject);
    }

    private void Update()
    {
        // Check if the current scene is the game scene
        if (SceneManager.GetActiveScene().name != "GamePlay")
        {
            // If the current scene is not the game scene, destroy this game object
            Destroy(this.gameObject);
        }
    }
}
