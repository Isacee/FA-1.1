using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private Transform barrel;
    [SerializeField] private float launchSpeed = 12.5f;

    private void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Fire();
        }
    }

    private void Fire()
    {
        GameObject projectile = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        projectile.transform.position = barrel.position + barrel.up * 0.95f;
        projectile.transform.localScale = Vector3.one * 0.32f;

        Rigidbody body = projectile.AddComponent<Rigidbody>();
        body.linearVelocity = barrel.up * launchSpeed;

        Destroy(projectile, 10f);
    }
}
