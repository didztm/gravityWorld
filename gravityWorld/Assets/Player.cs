using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    #region Public Members

    #endregion

    #region Public void

    #endregion

    #region System

    void Start ()
    {
        
    }

    void Update ()
    {
        	
    }

    #endregion

    #region Tools Debug and Utility
    private bool Isgrounded()
    {
        Vector3 vo = transform.position;
        Vector3 vd = new Vector3(0f, -0.1f, 0f);
        RaycastHit hit;
        if (debug) Debug.DrawRay(vo, vd, Color.red);
        if (Physics.Raycast(vo, vd, out hit, 0.6f))
        {
            if (hit.collider.CompareTag("Ground"))
            {
                return true;
            }
        }
        return false;
    }

    #endregion

    #region Private and Protected Members
    private bool debug;
    private Transform m_world;
    #endregion
}
