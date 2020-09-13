using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ExampleCode : ExampleCodeBase
{
    //exampleType.GetFields();
    public string TestVar;
    public DateTime TestVar2;

    //exampleType.GetProperties();
    public string Prope1
    {
        get { return "hello"; }
    }

    //public string Prope2 { get; set; }
    public string Prope3 { set { TestVar = value; } }

    public int Test1() {
        return 0;
    }

    
}

public class ExampleCodeBase : MonoBehaviour
{
    public string TestVar3;



}
