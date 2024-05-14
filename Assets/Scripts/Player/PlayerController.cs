using Aili.LightsOut.Utility;
using UnityEngine;

namespace Aili.LightsOut.Player
{
    [AddComponentMenu("Lights Out/Player/Player Controller")]
    internal class PlayerController : Singleton<PlayerController>
    {
        [Header("Physics")]
        [SerializeField]
        public bool m_CanMove = true;

        [SerializeField]
        float m_WalkSpeed = 20f;

        // InputManager inputManager;
        Rigidbody2D rb2D;

        void Awake()
        {
            // inputManager = InputManager.Instance;
            rb2D = GetComponent<Rigidbody2D>();
        }

        void FixedUpdate()
        {
            // Move the player
            // if (m_CanMove)
            // {
            //     rb2D.velocity =
            //         new Vector2(inputManager.move.x * m_WalkSpeed, rb2D.velocity.y)
            //         * Time.smoothDeltaTime;
            // }
            // else
            //     rb2D.velocity = Vector2.zero;
        }
    }
}
