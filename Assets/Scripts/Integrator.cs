using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Integrator : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Particle2D.velocity

    }
    public static void integrate(Particle2D particle)
    {
        particle.transform.position += (Vector3)particle.velocity * Time.fixedDeltaTime;
    }
}
