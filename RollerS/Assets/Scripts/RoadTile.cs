using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadTile : MonoBehaviour
{
    public MeshRenderer mechRenderer;
    public Vector3 position;
    public bool isPainted;

    private void Awake() {
        position = transform.position;
        isPainted = false;
    }
}
