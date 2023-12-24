using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    
    [SerializeField] GameObject ObjectToFollow;


    void Update()
    {
        transform.position = ObjectToFollow.transform.position + new Vector3(0,0,-10);
        
    }


}
