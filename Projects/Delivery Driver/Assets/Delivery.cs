using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;

    [SerializeField] Color32 hasPackageColor = new Color32(1,1,1,1);
    [SerializeField] Color32 noPackageColor = new Color32(1,1,1,1);

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    [SerializeField] float DestroyDelay = 0.5f;
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Hit");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Package" && !hasPackage){
            Debug.Log("Package Picked");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject , DestroyDelay);
        }

        if(other.tag == "Customer" && hasPackage){
            Debug.Log("Pakage Deliverd");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
            
        }
    }
}
