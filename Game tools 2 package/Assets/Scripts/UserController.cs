using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserController : MonoBehaviour {

    private float m_turn;
    private float m_forward;

    private Character m_character;


	// Use this for initialization
	private void Start () {
        m_character = GetComponent<Character>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        m_turn = Input.GetAxis("Horizontal");
        m_forward = Input.GetAxis("Vertical");
        m_character.Move(m_turn, m_forward);
    }
}
