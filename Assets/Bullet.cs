using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage2 = 20;

    private Transform target;

    public float speed;
    public void Seek(Transform _Target)
    {
        target = _Target;
    }

    void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if (dir.magnitude <= distanceThisFrame)
        {
            HitTarget();
            return;
        }

        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
    }
    void HitTarget()
    {
        EnHealth hp2 = GetComponent<EnHealth>();
        if (hp2 != null)
        {
            hp2.TakeDamage2(damage2);
            Destroy(gameObject);
        }
        Destroy(gameObject);
         
    }
}