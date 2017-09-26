using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// 課題：配列を宣言して出力しましょう
		int[] array = {1, 2, 3, 4, 5};
		for (int i = 0; i < array.Length; i++) {
			Debug.Log (array [i]);
		}
		for (int i = array.Length - 1; i >= 0; i--) {
			Debug.Log (array [i]);
		}

		// 発展課題：Bossクラスに、変数mpとMagic関数を作成してStart関数から呼び出しましょう
		Boss lastboss = new Boss();
		lastboss.Attack ();
		lastboss.Defence (3);
		for (int i = 0; i < 11; i++) {
			lastboss.Magic ();
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

public class Boss {
	private int hp = 100;
	private int power = 25;
	private int mp = 53;
	private const int mpConsumption = 5;

	public void Magic() {
		if (mp >= mpConsumption) {
			mp -= mpConsumption;
			Debug.Log ("魔法攻撃: 残りMP（" + mp + "）");
		} else {
			Debug.Log ("MPが足りません");
		}
	}

	public void Attack() {
		Debug.Log (this.power + "のダメージを与えた");
	}

	public void Defence(int damage) {
		Debug.Log (damage + "のダメージを受けた");
		this.hp -= damage;
	}
}