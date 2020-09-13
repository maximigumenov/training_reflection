using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using System.Reflection;

namespace ToolsReflectionSpace
{
    public class ToolsReflectionField
    {
        Type mainType;

        FieldInfo[] myFieldInfo;

        public ToolsReflectionField(object _object) {
            mainType = _object.GetType();
            myFieldInfo = mainType.GetFields();
        }

        public void ShowInfo() {
            Debug.LogError(WriteInfo("I see ", myFieldInfo.Length));
            for (int i = 0; i < myFieldInfo.Length; i++)
            {
                ShowInfoField(myFieldInfo[i]);
            }
        }

        public List<ReflectionFieldData> GetData() {
            List<ReflectionFieldData> result = new List<ReflectionFieldData>();
            for (int i = 0; i < myFieldInfo.Length; i++)
            {
                result.Add(new ReflectionFieldData(myFieldInfo[i]));
            }
            return result;
        }
        


        private void ShowInfoField(FieldInfo field) {
            string message = "";
            message += WriteInfo("Name", field.Name);
            if (field.FieldType.GenericTypeArguments.Length > 0)
            {
                message += WriteInfo("GenericType", field.FieldType.Name);
                message += WriteInfo("FieldType", field.FieldType.GenericTypeArguments[0].Name);
            }
            else
            {
                message += WriteInfo("FieldType", field.FieldType.FullName);
            }
            
            Debug.LogError(message);
        }





        private string WriteInfo(string _name) {
            return _name + "\n";
        }

        private string WriteInfo(string _name, object _object)
        {
            return _name + ": " + _object.ToString() + "\n";
        }
    }

    public class ReflectionFieldData{
        public string name;
        public string type;
        public string typeGeneric;
        public bool isGeneric = false;

        public ReflectionFieldData(FieldInfo field) {
            name = field.Name;
            if (field.FieldType.GenericTypeArguments.Length > 0)
            {
                type = field.FieldType.FullName;
                isGeneric = true;
                typeGeneric = field.FieldType.GenericTypeArguments[0].FullName;
            }
            else
            {
                type = field.FieldType.FullName;
            }
        }
    }


}
