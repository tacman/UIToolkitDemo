﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
public class UIController : MonoBehaviour
{
    private VisualElement root;
    private Slider rage;
    private Label label;
    private VisualElement playerStateImage;
    public AppController AppController;

    public void OnEnable() {
        
        
        // https://forum.unity.com/threads/how-can-we-attach-script-to-our-uxml-uss-at-runtime.872242/
        root = GetComponent<UIDocument>().rootVisualElement;
        Debug.Log(root.name);
        
        label = root.Q<Label>("game-label");
        label.text = Application.productName;

        // playerStateImage = root.Q<VisualElement>("PlayerStateImage");
        Debug.Log("Attaching Handlers.");
        Button startButton = root.Q<Button>("start-button");
        Debug.Log(startButton.ToString());

        startButton.clickable = new Clickable(() =>
        {
            Debug.Log("Start Button Clicked.");
            SceneManager.LoadScene("AppScene");
            // PlayerController.HandleSpellCast(Spell.DarkBomb, SpellType.Area);
        });

        Button quitButton = root.Q<Button>("quit-button");
        quitButton.clickable = new Clickable((evt) =>
        {
            Debug.Log(evt.ToString());
            Debug.Log("Quit Button Clicked.");
#if UNITY_EDITOR
            // Application.Quit() does not work in the editor so
            // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
            UnityEditor.EditorApplication.isPlaying = false;
#else
         Application.Quit();
#endif            
        });

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
