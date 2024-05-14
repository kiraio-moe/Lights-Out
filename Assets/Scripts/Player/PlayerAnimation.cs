using System;
using UnityEngine;

namespace Aili.LightsOut.Player
{
    [AddComponentMenu("Lights Out/Player/Player Animation")]
    internal class PlayerAnimation : MonoBehaviour
    {
        [Header("ANIMATOR PARAMETERS")]
        [SerializeField]
        string m_WalkAnimParam = "isWalking";

        [SerializeField]
        string m_FacingFrontParam = "isFacingFront";

        [Header("Sprite")]
        [SerializeField]
        bool m_IsFacingRight = true;

        public bool isFacingFront { get; private set; } = true;

        Animator animator;
        PlayerController playerController;

        void Awake()
        {
            animator = GetComponent<Animator>();
            playerController = PlayerController.Instance;
        }

        void Start()
        {
        }

        void Update()
        {
            // if (playerController.m_CanMove)
            // {
            //     animator.SetBool(m_WalkAnimParam, inputManager.move.x != 0 ? inputManager.isMove : false);
            // }
        }

        // void Walk()
        // {
        //     if (playerController.m_CanMove && inputManager.move.y != 0)
        //         SetPlayerFacing(inputManager.move.y >= 0 ? false : true);
        // }

        // public void SetPlayerFacing(bool isFront)
        // {
        //     isFacingFront = isFront;
        //     animator.SetBool(m_FacingFrontParam, isFacingFront);
        // }

        // bool Flip()
        // {
        //     m_IsFacingRight = !m_IsFacingRight;
        //     Vector2 newLocalScale = transform.localScale;
        //     newLocalScale.x *= -1f;
        //     transform.localScale = newLocalScale;
        //     return Convert.ToBoolean(Mathf.Abs(newLocalScale.x));
        // }
    }
}
