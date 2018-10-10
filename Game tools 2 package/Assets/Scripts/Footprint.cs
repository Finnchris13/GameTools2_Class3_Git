using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footprint : MonoBehaviour {

    [SerializeField] GameObject m_footprint;

    private Animator m_anim;
    private Transform m_rightFootTransform;
    private Transform m_leftFootTransform;

    private void Start()
    {
        m_anim = GetComponent<Animator>();

        m_rightFootTransform = m_anim.GetBoneTransform(HumanBodyBones.RightFoot);
            m_leftFootTransform = m_anim.GetBoneTransform(HumanBodyBones.LeftFoot);
    }

    public void MakeFootprint(int scale)
        {
        Debug.Log("Footprint");
        if (scale > 0)
        {
            Instantiate(m_footprint, m_leftFootTransform.position, m_leftFootTransform.rotation);
        }
        else
        {
            Instantiate(m_footprint, m_rightFootTransform.position, m_rightFootTransform.rotation);
        }
    }

}
