using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Selection : MonoBehaviour
{
    public float rayLength;
    public LayerMask layerMask;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, rayLength, layerMask))
            {
                GameObject go = hit.collider.gameObject;
                Button but = go.GetComponent<Button>();
                but.onClick.Invoke();
            }
        }
    }
}