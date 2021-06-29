using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Pointer : MonoBehaviour
{
    public float m_DefaultLength = 5.0f;
    public GameObject m_Dot;
    public InputModule m_InputModule;
    // public RaycastHit hitedRay;             // the ray which will check for collision object
    // private Transform hitedObject;
    private LineRenderer m_LineRenderer = null;
    // private Vector3 EndPosition;
    
    private void Awake()    
    {
        m_LineRenderer = GetComponent<LineRenderer>();
        
        // set position of pointer to center of controller
        // gameObject.transform.position = gameObject.transform.parent.position;
    }

    private void Update()
    {
        UpdateLine();
    }

    private void UpdateLine()
    {
        //use default value from our input module or distance
        PointerEventData data = m_InputModule.GetData(); 
        float TargetLength = data.pointerCurrentRaycast.distance == 0 ? m_DefaultLength : data.pointerCurrentRaycast.distance;

        //Raycast
        // hitedRay = CreateRaycast(TargetLength);
        RaycastHit hit = CreateRaycast(TargetLength);

        //Default
        Vector3 EndPosition = transform.position + (transform.forward * TargetLength);

        //Update when hitting something (Check for collider)
        // if (hitedRay.collider != null)
        if (hit.collider != null)
        {
            // EndPosition = hitedRay.point;
            EndPosition = hit.point;
        }

        //Set position of the Dot
        m_Dot.transform.position = EndPosition;

        //Set position of LineRenderer
        m_LineRenderer.SetPosition(0, transform.position);
        m_LineRenderer.SetPosition(1, EndPosition);
    }

    private RaycastHit CreateRaycast(float length)
    {


        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);
        Physics.Raycast(ray, out hit, m_DefaultLength);

        return hit;

        // Ray ray = new Ray(transform.position,transform.forward);

        // if(Physics.Raycast(ray, out hitedRay, m_DefaultLength))
        // {
        //     hitedObject = hitedRay.transform;
        // }
        // else
        // {
        //     hitedObject =  null;
        // }

        // return hitedRay;
    }

    
    // public Transform GetHitedObject()
    // {
    //     return hitedObject;
    // }
    
    // public Vector3 GetEndPosition()
    // {
    //     return EndPosition;
    // }
}
