using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonMain : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// 最常見，缺點是在多執行緒中會有問題，確認不會在多執行緒中使用的話，用這個就好
		Debug.LogFormat("Settings volume is {0}", Settings.getInstance().volume);
		// 在多執行緒中不會有問題，但沒有延遲實例化的好處了，不過Singleton物件一般來說也都很早就實例化，沒啥差
		Debug.LogFormat("EagerlySettings volume is {0}", EagerlySettings.getInstance().volume);
		// 在多執行緒中不會有問題，但效能較差，每次試圖同時呼叫getInstance()都會造成等待
		Debug.LogFormat("SynchronizedSettings volume is {0}", SynchronizedSettings.getInstance().volume);
		// 在多執行緒中不會有問題，且只有第一次呼叫getInstance()時可能會造成等待，之後就沒有效能問題
		Debug.LogFormat("LockSettings volume is {0}", LockSettings.getInstance().volume);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
