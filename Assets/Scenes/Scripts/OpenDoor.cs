using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    Animator animator;
    int openedHash;
    // To measure distance
    public Transform PlayerCamera;
    public float MaxDistance = 5;



    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        openedHash = Animator.StringToHash("Opened");
    }

    // Update is called once per frame
    void Update()
    {
        // Check PLayer Input
        //bool opened = animator.GetBool("Opened");
        bool opened = animator.GetBool(openedHash);
        bool openDoor = Input.GetKeyDown("f");
        bool closeDoor = Input.GetKeyUp("f");

        float distance = Vector3.Distance(PlayerCamera.transform.position, this.transform.position);

        // Raycast
        //RaycastHit doorhit;

        // Closed > Opened > Closed Transition
        // Check Distance

        //if (Physics.Raycast(PlayerCamera.transform.position, PlayerCamera.transform.forward, out doorhit, MaxDistance))
        //{

        // if raycast hits, then it checks if it hit an object with the tag Door.
        //if (doorhit.transform.tag == "Door")
        //{

        if(distance < MaxDistance)
        {
            // Player is pressing "F" 
            if (openDoor)
            {
                animator.SetBool(openedHash, true);
            }
            // Player is not pressing "F"
            if (closeDoor && opened)
            {
                animator.SetBool(openedHash, false);
            }
        }

        
            //}
       // }
    }



            /*// Walk > Run Transition
            // Player is walking and running (pressing Left Shift)
            if (!isrunning && (forwardPressed && runPressed))
            {
                // Start Running
                animator.SetBool(isRunningHash, true);
            }
            // Player stops running or walking
            if (isrunning && (!forwardPressed || !runPressed))
            {
                // Stop Running
                animator.SetBool(isRunningHash, false);
            }

            // Idle > Turn Transition
            // Player is pressing "d"
            if (!isTurning && turnPressed)
            {
                animator.SetBool(isTurningHash, true);
            }
            // Player is not pressing "d"
            if (isTurning && !turnPressed)
            {
                animator.SetBool(isTurningHash, false);
            }

        }
            */
        }
