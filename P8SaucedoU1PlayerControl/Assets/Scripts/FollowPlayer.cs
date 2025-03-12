using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);
    private Vector3 backwards = new Vector3(0, 4, 1);


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Offset the camera behind the player by adding to the player's posision
        transform.position = player.transform.position + offset;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.position = player.transform.position + backwards;
            transform.rotation = player.transform.rotation;
        }
    }
}
