using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {


	void Start () {
		
	}
	

	void Update () {
	
	}

	void OnMouseDown(){
		//GameObject obj = GameObject.Find("enemyPrefab(Clone)");
		Destroy(this.gameObject);
		Debug.Log(this.gameObject);
	}

	void OnDestroy(){
		GameObject go = GameObject.Find("GameManager");
			if (go != null) {
				GameManager gm = go.GetComponent(typeof(GameManager)) as GameManager;
				gm.AddScore(100);
			}
	}
}
