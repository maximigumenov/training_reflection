using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using ToolsReflectionSpace;

public class Work : MonoBehaviour
{
    public ExampleCode example;
    private Type exampleType;
    // Start is called before the first frame update
    void Start()
    {
        GetData();
        GetProperties();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void GetData() {
        exampleType = typeof(ExampleCode);
    }

    private void GetProperties() {

        ToolsReflectionField toolsReflectionField = new ToolsReflectionField(example);

        PropertyInfo[] myPropertyInfo;
        FieldInfo[] myFieldInfo;
        MethodInfo[] myMethodInfo;
        myPropertyInfo = exampleType.GetProperties();
        myFieldInfo = exampleType.GetFields();
        myMethodInfo = exampleType.GetMethods();

        //Debug.LogError(myPropertyInfo.Length);
        //Debug.LogError(myFieldInfo.Length);
        //Debug.LogError(myMethodInfo.Length);

        toolsReflectionField.ShowInfo();

        
        
    }
}
