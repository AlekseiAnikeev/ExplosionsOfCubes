using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Explosion : MonoBehaviour
{
    [SerializeField] private float _explosionForce;

    private float _explosionRadius = 0f;

    public void Explode()
    {
        foreach (Rigidbody explodableObject in GetExplodableObgect())
            explodableObject.AddExplosionForce(_explosionForce, transform.position, _explosionRadius);
    }

    private List<Rigidbody> GetExplodableObgect()
    {
        Collider[] hits = Physics.OverlapSphere(transform.position, _explosionRadius);

        List<Rigidbody> units = new();

        units.AddRange(hits.Where(hit => hit.attachedRigidbody != null).Select(hit => hit.attachedRigidbody));

        return units;
    }
}