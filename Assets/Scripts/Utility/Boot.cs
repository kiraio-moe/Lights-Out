using Eflatun.SceneReference;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Aili.LightsOut.Utility
{
    [AddComponentMenu("Lights Out/Utility/Boot")]
    public class Boot : MonoBehaviour
    {
        [SerializeField] static string m_BootScene = "Boot";
        [SerializeField] static string m_FirstScene = "Main";

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        static void Init()
        {
            // If currently not in "Boot" scene
            if (SceneManager.GetSceneByName(m_BootScene).isLoaded != true)
                SceneManager.LoadScene(m_BootScene);

            #if UNITY_EDITOR
            Scene currentlyLoadedEditorScene = SceneManager.GetActiveScene();
            if (currentlyLoadedEditorScene.IsValid())
            {
                if (currentlyLoadedEditorScene.name != m_BootScene)
                    SceneManager.LoadSceneAsync(currentlyLoadedEditorScene.name, LoadSceneMode.Additive);
                else
                    SceneManager.LoadSceneAsync(m_FirstScene, LoadSceneMode.Additive);
            }
            #else
            SceneManager.LoadSceneAsync(m_FirstScene, LoadSceneMode.Additive);
            #endif
        }

        void Awake()
        {
            Application.runInBackground = true;
        }
    }
}
