using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MoveAllTransform
{
    [MenuItem("Utils/Move All Transforms")]
    public static void MoveAllTransforms()
    {
        foreach(Transform transform in Object.FindObjectsOfType<Transform>())
        {
            transform.position = Vector3.zero;
        }
    }
}
