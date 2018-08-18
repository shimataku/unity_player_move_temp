using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    IDictionary<KeyCode, KeyPressedFunction> keyFuncMap;

    // Use this for initialization
    void Start () {
        keyFuncMap = new Dictionary<KeyCode, KeyPressedFunction>();

        keyFuncMap.Add(KeyCode.W, new KeyPressedFunction(KeyPressedFunction.ePressedType.ePressedTypePressed, pressedKeyW));
        keyFuncMap.Add(KeyCode.A, new KeyPressedFunction(KeyPressedFunction.ePressedType.ePressedTypePressed, pressedKeyA));
        keyFuncMap.Add(KeyCode.S, new KeyPressedFunction(KeyPressedFunction.ePressedType.ePressedTypePressed, pressedKeyS));
        keyFuncMap.Add(KeyCode.D, new KeyPressedFunction(KeyPressedFunction.ePressedType.ePressedTypePressed, pressedKeyD));
        keyFuncMap.Add(KeyCode.Space, new KeyPressedFunction(KeyPressedFunction.ePressedType.ePressedTypeDown, pressedKeySpace));
    }

    public delegate void keyFunction();

    void pressedKeyW()
    {
        Debug.Log("keyW");
    }

    void pressedKeyA()
    {
        Debug.Log("keyA");
    }

    void pressedKeyS()
    {
        Debug.Log("keyS");
    }

    void pressedKeyD()
    {
        Debug.Log("keyD");
    }

    void pressedKeySpace()
    {
        Debug.Log("keySpace");
    }
	
	// Update is called once per frame
	void Update () {

        KeyCode[] useKeyArray = { KeyCode.W, KeyCode.A, KeyCode.S, KeyCode.D, KeyCode.Space };

        foreach(KeyCode keyCode in useKeyArray)
        {
            if (keyFuncMap.ContainsKey(keyCode))
            {
                keyFuncMap[keyCode].InputKey(keyCode);
            }
        }

	}
}
