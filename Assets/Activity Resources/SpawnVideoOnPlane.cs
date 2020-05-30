using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

[RequireComponent(typeof(ARRaycastManager))]
public class SpawnVideoOnPlane : MonoBehaviour
{
    private ARRaycastManager raycastManager;
    private GameObject videoObject;

    [SerializeField]
    private GameObject placeablePrefab;

    static List<ARRaycastHit> s_Hits = new List<ARRaycastHit>();

    private void Awake()
    {
        raycastManager = GetComponent<ARRaycastManager>();
    }

    bool TryGetTouchPosition(out Vector2 touchPosition)
    {
        if(Input.touchCount > 0)
        {
            touchPosition = Input.GetTouch(0).position;
            return true;
        }

        touchPosition = default;
        return false;
    }

    private void Update()
    {
        if(!TryGetTouchPosition(out Vector2 touchPosition))
        {
            return;
        }

        if(raycastManager.Raycast(touchPosition, s_Hits, TrackableType.PlaneWithinPolygon))
        {
            var hitPos = s_Hits[0].pose;
            if(videoObject == null)
            {
                videoObject = Instantiate(placeablePrefab, hitPos.position, hitPos.rotation);
            }
            else
            {
                Destroy(videoObject);
            }
        }
    }

}
