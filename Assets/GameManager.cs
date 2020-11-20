using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    private VisualElement root;
    private Slider rage;
    private Label label;
    private VisualElement playerStateImage;
    

    public void OnEnable() {
        
        
        // https://forum.unity.com/threads/how-can-we-attach-script-to-our-uxml-uss-at-runtime.872242/
        root = GetComponent<UIDocument>().rootVisualElement;
        Debug.Log(root.name);
        
        label = root.Q<Label>("game-label");
        label.text = Application.productName;

        // playerStateImage = root.Q<VisualElement>("PlayerStateImage");

    }

    
    private void Update() {
        // rage.value = PlayerController.Rage;
        //
        // if (rage.value == 1) {
        //     playerStateImage.RemoveFromClassList("normal_player_state");
        //     playerStateImage.AddToClassList("rage_player_state");
        // } else {
        //     playerStateImage.AddToClassList("normal_player_state");
        //     playerStateImage.RemoveFromClassList("rage_player_state");
        // }
    }
}
