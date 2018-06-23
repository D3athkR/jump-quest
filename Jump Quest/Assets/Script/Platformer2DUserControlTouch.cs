using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnitySampleAssets._2D
{

    [RequireComponent(typeof (PlatformerCharacter2D))]
    public class Platformer2DUserControlTouch : MonoBehaviour
    {
        private PlatformerCharacter2D character;
        private bool jump;

        private void Awake()
        {
            character = GetComponent<PlatformerCharacter2D>();
        }

        private void Update()
        {
            if(!jump)
            // Read the jump input in Update so button presses aren't missed.
				jump = CrossPlatformInputManager.GetButton("Jump");
        }

        private void FixedUpdate()
        {
			bool crouch = CrossPlatformInputManager.GetButton("Crouch");
            float h1 = CrossPlatformInputManager.GetAxis("Horizontal");
            character.Move(h1, crouch, jump);
            jump = false;
        }
    }
}