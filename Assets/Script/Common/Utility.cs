using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utility 
{
    public static T GetNearestInteractable<T>(Vector3 origin, List<T> collection)
        where T: Interactable
    {
        T nearest = null;
        float minDistance = float.MaxValue;
        float distance = 0.0f;

        // For each object we are touching
        foreach (T entity in collection)
        {
            if (!entity)
                continue;

            /*
            if (!entity.GetAvailability())
                continue;
            */

            distance = (entity.gameObject.transform.position - origin).sqrMagnitude;

            if (distance < minDistance)
            {
                minDistance = distance;
                nearest = entity;
            }
        }

        return nearest;
    }
}
