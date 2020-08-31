using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Crouch : MonoBehaviour
{
    // public GameObject PlayerHeight;
    public KeyCode CrouchButton;
    private bool m_crouch = true;
    public CharacterController characterController;
    private float m_originalHeight;
    public DetectPlayerHeight High;
    private float movementSpeed;

    [SerializeField] private string horizontalInputName;
    [SerializeField] private string verticalInputName;
    [SerializeField] private float PlayerHeightSize;
    [SerializeField] private float NormalMovementSpeed;
    [SerializeField] private float SprintSpeed;
    [SerializeField] private float crouchSpeed;

    public static bool ControllerStatus;
    public bool couroutineOn;
    private float stepDelay = 0.5f;
    private bool iswalking = false;
    private bool isSprinting = false;
    public float stepDelayWalking = 0;
    public float stepDelayCouching = 0;
    public float stepDelaySprinting = 0;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        m_originalHeight = characterController.height;
        movementSpeed = NormalMovementSpeed;
        m_crouch = false;
        couroutineOn = true;
        
        StartCoroutine(Walking());
    }


    IEnumerator Walking()
    {

        while (couroutineOn == true)
        {

            if (iswalking == true && m_crouch == false && isSprinting == false)
            {

                //Son : marcher
                FindObjectOfType<AudioManager>().Play("Footstep");
                
                stepDelay = stepDelayWalking;
            }
            else
             if (m_crouch == true && iswalking == true && isSprinting == false)
            {
                FindObjectOfType<AudioManager>().Play("Footstep Crouch");
                stepDelay = stepDelayCouching;
            }
            else
             if(isSprinting == true && iswalking == true && m_crouch == false)
            {
                FindObjectOfType<AudioManager>().Play("Footstep Sprint");
                stepDelay = stepDelaySprinting;
            }
            else
            {
                FindObjectOfType<AudioManager>().Stop("Footstep");

            }

            yield return new WaitForSeconds(stepDelay);


        }

       
    }

    void Update()
    {
 
           if(ControllerStatus == true)
        {
            ControllerStatus = false;
            StartCoroutine(Walking());
        }

        PlayerMovement();
       /* if (Input.GetButton("Fire3") && m_crouch == false)
        {

            movementSpeed = SprintSpeed;
            isSprinting = true;
        }

        // Reduce speed to normal
        if (Input.GetButtonUp("Fire3"))
        {
            isSprinting = false;
            movementSpeed = NormalMovementSpeed;
            if (characterController.height == 0.5f)
            {
                movementSpeed = crouchSpeed;
            }
        }*/
        if (Input.GetKeyDown(CrouchButton))
        {

            CheckCrouch();
        }
    }



    private void PlayerMovement()
    {
        float horizInput = Input.GetAxis(horizontalInputName) * movementSpeed;
        float vertInput = Input.GetAxis(verticalInputName) * movementSpeed;

        Vector3 forwardMovement = transform.forward * vertInput;
        Vector3 rightMovement = transform.right * horizInput;

        characterController.SimpleMove(forwardMovement + rightMovement);
        if (characterController.velocity.sqrMagnitude > 0 && (horizInput != 0 || vertInput != 0))
        {
            iswalking = true;
        }
        else
            iswalking = false;
    }

    void CheckCrouch()
    {

        if (m_crouch == false || High.touch == 1)
        {
            characterController.height = 0.5f;
            movementSpeed = crouchSpeed;
            if (High.touch == 0)
            {
                m_crouch = !m_crouch;
            }
            High.touch = 0;
        }
        else
        {
            if (High.touch == 0)
            {
                characterController.height = PlayerHeightSize;
                movementSpeed = NormalMovementSpeed;
                m_crouch = !m_crouch;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

    }
}