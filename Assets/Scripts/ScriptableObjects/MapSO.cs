using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "MapSO", menuName = "ScriptableObjects/MapSO")]
public class MapSO : ScriptableObject {

    public Transform prefab;

    [Header("Scale")]
    public float scaleX;
    public float scaleY;
    public float scaleZ;

    [Header("Position")]
    public float positionX;
    public float positionY;
    public float positionZ;
}