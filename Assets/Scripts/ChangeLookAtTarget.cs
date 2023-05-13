using UnityEngine;
using System.Collections;

public class ChangeLookAtTarget : MonoBehaviour {

	public GameObject target; // the target that the camera should look at
	public AudioSource musicaPlaneta;
	public AudioSource[] musicasPlanetas;

	void Start() {
		if (target == null) 
		{
			target = this.gameObject;
			Debug.Log ("ChangeLookAtTarget target not specified. Defaulting to parent GameObject");
		}
	}

	// Called when MouseDown on this gameObject
	void OnMouseDown() {
		// change the target of the LookAtTarget script to be this gameobject.
		LookAtTarget.target = target;
		Camera.main.fieldOfView = 60*target.transform.localScale.x;

		musicasPlanetas = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
		foreach(AudioSource musicas in musicasPlanetas)
		{
			musicas.Stop();
		}
		MusicaPlaneta();
	}

	public void MusicaPlaneta() {
		musicaPlaneta.Play();
	}
}
