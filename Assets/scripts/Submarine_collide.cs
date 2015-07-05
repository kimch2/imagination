﻿using UnityEngine;
using System.Collections;

public class Submarine_collide : MonoBehaviour {


	void OnCollisionEnter(Collision collider)
	{
		if (collider.gameObject.tag == "SubmarineCollider") {

			Application.LoadLevel(Application.loadedLevel);


		}
		if (collider.gameObject.tag == "SubmarineFinish") {

			Toolbox.Instance.level_submarine_complete = true;
			Application.LoadLevel("main_room");

		}

	}
}
