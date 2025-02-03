using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    [SerializeField] private InteractableType interactableType;

    public InteractableType GetInteractableType { get { return interactableType; } }

}
