﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.Networking;

namespace UnitySampleAssets._2D
{

    [RequireComponent(typeof (PlatformerCharacter2D))]
    public class Platformer2DUserControl : NetworkBehaviour
    {
        private PlatformerCharacter2D character;
        private bool jump;
		

       
        private void Awake()
        {
            character = GetComponent<PlatformerCharacter2D>();


        }

        private void Update()
        {
        	//Player controls their own player and not other's as well (Turn on during multiplayer)
        	//if (!isLocalPlayer){
        	//	return;
        	//}

            if(!jump)
            // Read the jump input in Update so button presses aren't missed.
            jump = Input.GetButtonDown("Jump");
        }


        private void FixedUpdate()
        {
            // Read the inputs.
            //bool crouch = Input.GetKey(KeyCode.DownArrow);
			bool crouch = Input.GetKey(KeyCode.DownArrow);
            float h = Input.GetAxis("Horizontal");
            // Pass all parameters to the character control script.
            character.Move(h, crouch, jump);
            jump = false;
        }





}
}

