using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapScript : MonoBehaviour
{
    public Transform Player1;
    
  
    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newPosition = Player1.position;
        newPosition.y = transform.position.y;  
        transform.position = newPosition;
    }
}
