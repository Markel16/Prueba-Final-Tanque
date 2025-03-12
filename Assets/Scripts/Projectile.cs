using System.Collections;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(DestroyAfterTime());
    }

    IEnumerator DestroyAfterTime()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
}
