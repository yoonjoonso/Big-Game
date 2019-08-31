using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("destroyed object");
        HeadMovement hm = collision.gameObject.GetComponent<HeadMovement>();
        if (hm != null)
        {
            Destroy(hm.transform.parent);
        }    
    }
}
