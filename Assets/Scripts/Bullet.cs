using System;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Transform target;
    private float speed = 70f;
    private void Update()
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
        Destroy(target.gameObject);
        Destroy(gameObject);
    }
    public void Seek(Transform point)
    {
        target = point;
    }
}