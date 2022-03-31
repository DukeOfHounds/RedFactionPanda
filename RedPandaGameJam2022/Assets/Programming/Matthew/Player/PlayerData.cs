using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Player/Generic")]
public class PlayerData : ScriptableObject
{
    private void Awake()
    {
        busyHands = false;

    }

    [Header("Controller Variables")]
    [Range(0, 10)]
    [SerializeField] public float moveSpeed;
    [Range(0, 5)]
    [SerializeField] public float inertiaVar;
    [Range(0, 100)]
    [SerializeField] public float mouseSensitivityX;
    [Range(0, 100)]
    [SerializeField] public float mouseSensitivityY;
    [Range(0, 100)]
    [SerializeField] public float neckClamp;
    [SerializeField] public LayerMask groundMask;//

    [Header("Headbob Stuff")]
    [Range(0.00001f, 0.001f)] [SerializeField] public float amplitude = 0.0003f;
    [Range(0, 30)] [SerializeField] public float frequency = 10.0f;

    [Header("Gameplay Related")]
    [SerializeField] public Vector3 currentMovement;
    [SerializeField] public float interactDistance;
    [SerializeField] public bool canInteract;
    [SerializeField] public bool busyHands;
    [Range(0, 10)]
    [SerializeField] public float carryDistance;
    [Range(0, 10)]
    [SerializeField] public float smooth;
}
