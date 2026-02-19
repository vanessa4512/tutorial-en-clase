using System;
using Unity.Cinemachine;
using UnityEngine;

public class MapTransition : MonoBehaviour
{
    [SerializeField] PolygonCollider2D mapBoundry;
    private CinemachineConfiner2D confiner;

    private void Awake() {
        confiner = FindObjectOfType<CinemachineConfiner2D>();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player"))
        {
            confiner.BoundingShape2D = mapBoundry;
        }
    }
}
