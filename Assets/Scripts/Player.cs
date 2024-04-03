using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    bool isWalking;
    [SerializeField]
    GameInput gameInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 inputVector = gameInput.GetMovementVectorNormalized();

        if(Input.GetKey(KeyCode.W))
        {
            isWalking = true;
        }
        if (Input.GetAxis("Vertical") > 0)
        {
          
        }

    }

    public bool IsWalking()
    {
        return isWalking;
    }
}
