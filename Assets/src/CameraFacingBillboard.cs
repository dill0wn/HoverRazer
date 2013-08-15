using UnityEngine;
using System.Collections;
 
public class CameraFacingBillboard : MonoBehaviour
{
    public static Camera m_Camera = null;
	
	void Awake()
	{
		if(m_Camera == null)
			m_Camera = Camera.main;
	}
 
    void Update()
    {
        transform.LookAt(transform.position + m_Camera.transform.rotation * Vector3.back,
            m_Camera.transform.rotation * Vector3.up);
		transform.Rotate(Vector3.up, 180f);
		 //Debug.Log("IMA TRANFROMING" + transform.rotation);
    }
}