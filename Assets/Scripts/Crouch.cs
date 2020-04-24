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




    void Start()
    {
        characterController = GetComponent<CharacterController>();
        m_originalHeight = characterController.height;
        movementSpeed = NormalMovementSpeed;
        m_crouch = false;

    }

    void Update()
    {
        Debug.Log(High.touch);
        PlayerMovement();
        if (Input.GetButton("Fire3") && m_crouch == false)
        {
            
            movementSpeed = SprintSpeed;
            
        }

        // Reduce speed to normal
        if (Input.GetButtonUp("Fire3"))
        {
            movementSpeed = NormalMovementSpeed;
            if(characterController.height == 0.5f)
            {
                movementSpeed = crouchSpeed;
            }
        }
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
            if(High.touch == 0)
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