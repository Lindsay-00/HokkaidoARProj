using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ReceiveName : MonoBehaviour
{
    public TextMeshProUGUI display_player_name;

    private void Awake() {
        display_player_name.text = "Hi " + SetNameController.nameController.user_name + ", I'm Snowmiku.";
    }
}
