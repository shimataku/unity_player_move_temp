using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void KeyFunction();

public class KeyPressedFunction
{
    public enum ePressedType
    {
        ePressedTypePressed,
        ePressedTypeDown,
        ePressedTypeUp,
    };

    private KeyFunction keyFunction;
    private ePressedType pressedType;

    public KeyPressedFunction(ePressedType type, KeyFunction keyFunction)
    {
        this.pressedType = type;
        this.keyFunction = keyFunction;
    }

    public void InputKey(KeyCode keyCode)
    {
        switch (pressedType)
        {
            case ePressedType.ePressedTypePressed:
                if(Input.GetKey(keyCode))
                {
                    run();
                }
                break;
            case ePressedType.ePressedTypeDown:
                if (Input.GetKeyDown(keyCode))
                {
                    run();
                }
                break;
            case ePressedType.ePressedTypeUp:
                if (Input.GetKeyUp(keyCode))
                {
                    run();
                }
                break;
        }
    }

    private void run()
    {
        this.keyFunction();
    }
}
