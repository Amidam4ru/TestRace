using System;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Checkpoint : MonoBehaviour
{
    public event Action<Checkpoint> PlayerChecked;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.TryGetComponent(out Player player))
        {
            PlayerChecked?.Invoke(this);
        }
    }
}
