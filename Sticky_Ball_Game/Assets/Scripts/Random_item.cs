using UnityEngine;
using System.Collections;

public class Random_item: MonoBehaviour
{


	//プレハブを変数に代入
	public GameObject cube;


	void Start()
	{
		InvokeRepeating("Generate", 1, 1);

	}

	void Generate()
    {
		//オブジェクトの座標
		float x = Random.Range(0.0f, 10.0f);
		float y = 1;
		float z = Random.Range(0.0f, 10.0f);

		//オブジェクトを生産
		Instantiate(cube, new Vector3(x, y, z), Quaternion.identity);
	}
}