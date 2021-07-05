using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDetect : MonoBehaviour
{
    public GameObject m_canves;

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "PointTrigger"){
            m_canves.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.tag == "PointTrigger"){
            m_canves.SetActive(false);
        }
    }
}
