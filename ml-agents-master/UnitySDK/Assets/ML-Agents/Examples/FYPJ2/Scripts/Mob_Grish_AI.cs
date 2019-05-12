using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob_Grish_AI : MonoBehaviour {

    public GameObject m_GrishGO;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        m_GrishGO.transform.Translate(1,0,0);
	}
}
