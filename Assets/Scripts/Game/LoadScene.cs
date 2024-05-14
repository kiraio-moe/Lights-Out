using Eflatun.SceneReference;
using WSWhitehouse.TagSelector;
using UnityEngine;

namespace Aili.LightsOut.Game
{
    [AddComponentMenu("Lights Out/Game/Load Scene")]
    [RequireComponent(typeof(SceneLoader))]
    [RequireComponent(typeof(BoxCollider2D))]
    internal class LoadScene : MonoBehaviour
    {
        [Header("Interact")]
        [SerializeField]
        [TagSelector]
        string m_InteractWith = "Player";

        [SerializeField]
        bool m_AutoTrigger;
        bool onRange;

        BoxCollider2D boxCollider2D;
        SceneLoader sceneLoader;
        // InputManager inputManager;
        // DialogueManager dialogueManager;

        void OnValidate()
        {
            boxCollider2D = GetComponent<BoxCollider2D>();
            boxCollider2D.isTrigger = true;
        }

        void Awake()
        {
            sceneLoader = GetComponent<SceneLoader>();
            // inputManager = InputManager.Instance;
            // dialogueManager = DialogueManager.Instance;
        }

        void Start()
        {
            // inputManager.OnInteractStarted.AddListener(Load);
        }

        void Load()
        {
            if (onRange)
            {
                Debug.Log($"Load Scene: {sceneLoader._serializableScene.SceneName}");
                sceneLoader.UnloadSceneAsync(gameObject.scene.name);
                sceneLoader.Load();
            }
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag(m_InteractWith))
            {
                Debug.Log("Player on TriggerEnter");
                onRange = true;

                if (onRange && m_AutoTrigger)
                    Load();
            }
        }

        void OnTriggerExit2D(Collider2D other)
        {
            if (other.CompareTag(m_InteractWith))
            {
                onRange = false;
                Debug.Log("Player on TriggerExit");
            }
        }
    }
}
