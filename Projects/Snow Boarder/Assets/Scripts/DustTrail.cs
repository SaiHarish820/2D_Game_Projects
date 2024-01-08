using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] ParticleSystem dustParticle;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Platform")
        {
            dustParticle.Play();
        }
    }



    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Platform") dustParticle.Stop();
    }


}
