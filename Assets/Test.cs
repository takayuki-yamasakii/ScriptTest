using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//　要素数５の配列を初期化する
		int[] points = new int[5];

		//　配列の各要素に値を代入する
		points[0] = 13;
		points[1] = 15;
		points[2] = 17;
		points[3] = 19;
		points[4] = 21;

		//　配列の要素を順に表示する
		for (int i = 0; i < 5; i++)
		{
			Debug.Log(points[i]);
		}
		for (int i = 4; i >= 0; i--)
		{
			Debug.Log(points[i]);
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
