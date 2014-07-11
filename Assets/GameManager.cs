using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public GameObject enemyPrefab;
	public GUIText time;
	public GUIText score;

	//int myScore = 0;
	int pointObject = 10;
	int isupdate = 1;
	float remainingTime = 0f;

	// Use this for initialization
	void Start () {
		MakeEnemys();
	}
	
	// Update is called once per frame
	void Update () {
		float deltaTime = Time.deltaTime;
		if(isupdate == 1){
			remainingTime += deltaTime;
			time.text = ("" + remainingTime.ToString("f3"));
			//score.text = ("score:" + myScore);
		}
	}

	//enemy make
	void MakeEnemys(){
		for (int i = 0; i< 10; i++) {
			GameObject enemy = (GameObject)Instantiate(enemyPrefab);
			Vector3 p = enemy.transform.position;
			p.x = Random.Range(-4,4);
			p.y = Random.Range(-4,4);
			enemy.transform.position = p;
		}
	}

	public void AddScore(int add){
		if (remainingTime > 0) {
			//myScore += add;
			pointObject -= 1;
			}
		if(pointObject == 0){
			isupdate = 0;
		}
	}


}
