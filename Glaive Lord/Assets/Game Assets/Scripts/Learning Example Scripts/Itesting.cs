using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itesting : MonoBehaviour
{

    private void Start()
    {
        MyClass myClass = new MyClass();

        TestInterface(myClass);

        MySecondClass mySecondClass = new MySecondClass();

        TestInterface(mySecondClass);
    }

    private void TestInterface(IMyInterface myInterface)
    {
        myInterface.TestFunction();
    }

}

public interface IMyInterface
{
    void TestFunction();
}

public class MyClass : IMyInterface
{
    public void TestFunction()
    {
        Debug.Log("MyClass.TestFunction()");
    }
}

public class MySecondClass : IMyInterface
{
    public void TestFunction()
    {
        Debug.Log("MySecondClass");
    }
}