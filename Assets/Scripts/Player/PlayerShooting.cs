using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    
    void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.L))
            Instantiate(bulletPrefab, new Vector3(-7.3f, transform.position.y, 0), Quaternion.identity);
    }
}