using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetNameController : MonoBehaviour
{
    public static SetNameController nameController;
    public string user_name;
    public TMP_InputField user_inputField;

    private void Awake() {
        if(nameController == null){
            nameController = this;
            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }
    }
    public void setName(){
        user_name = user_inputField.text;
    }
}
