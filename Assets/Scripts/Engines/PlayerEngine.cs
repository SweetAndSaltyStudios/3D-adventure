using UnityEngine;

public class PlayerEngine : MonoBehaviour
{
    #region VARIABLES

    private float speed = 10;
    private readonly float directionDampTime = 0.25f;

    private Animator animator;

    #endregion VARIABLES

    #region PROPERTIES

       private float horizontal = 0f;
    private float vertical = 0f;

    #endregion PROPERTIES

    #region UNITY_FUNCTIONS

    private void Awake()
    {
        animator = GetComponentInChildren<Animator>();

        if(animator.layerCount >= 2)
        {
            animator.SetLayerWeight(1, 1);
        }
    }

    private void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        speed = new Vector2(horizontal, vertical).sqrMagnitude;

        if (animator)
        {
            animator.SetFloat("Speed", speed);
            animator.SetFloat("Direction", horizontal, directionDampTime, Time.deltaTime);
        }
    }

    #endregion UNITY_FUNCTIONS

    #region CUSTOM_FUNCTIONS



    #endregion CUSTOM_FUNCTIONS
}
