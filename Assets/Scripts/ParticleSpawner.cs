using UnityEngine;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem;

public class ParticleSpawner : MonoBehaviour
{
    // TODO: YOUR CODE HERE!
    public Particle2D particle;
    private Vector2 mousePos;

    private void Start()
    {
        Time.timeScale = 0.5f;
    }
    private void Update()
    {

   
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.value);
        }
        if (Mouse.current.leftButton.wasReleasedThisFrame)
        {
            Particle2D newParticle = particle;
            Vector2 end = (Vector2)Camera.main.ScreenToWorldPoint(Mouse.current.position.value);
            newParticle.velocity = end - mousePos;
            Instantiate(newParticle.gameObject, new Vector3(mousePos.x, mousePos.y, 5), Quaternion.identity, this.gameObject.transform);
            Debug.Log(mousePos);
            Debug.Log(end);

        }
    }
}
