using log4net.Util;
using UnityEngine;

public class Particle2D : MonoBehaviour
{
    public int mass;
    public Vector2 velocity;
    public Vector2 acceleration;
    public Vector2 accumulatedForce;
    public int dampingConstant;

    private void FixedUpdate()
    {
        Integrator.integrate(this);
    }

    // TODO: YOUR CODE HERE!
}
