using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine;
using System.Collections;

public class VirtualJoystick : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{

private Image bglmg;
private Image joystickImg;

public Vector3 InputDirection {set;get; }



			private void Start()
{
bglmg= GetComponent<Image>();
joystickImg=transform.GetChild(0).GetComponent<Image>();


}
			public virtual void OnDrag(PointerEventData ped)


{
	Vector2 pos = Vector2.zero;
	if(RectTransformUtility.ScreenPointToLocalPointInRectangle(bglmg.rectTransform
																,ped.position
																,ped.pressEventCamera
																,out pos))




	
{
		pos.x = (pos.x / bglmg.rectTransform.sizeDelta.x);
		pos.y = (pos.y / bglmg.rectTransform.sizeDelta.y);

		float x = (bglmg.rectTransform.pivot.x == 1) ? pos.x * 2+1 : pos.x * 2-1;
		float y = (bglmg.rectTransform.pivot.y == 1) ? pos.y * 2+1: pos.y * 2-1;

		InputDirection = new Vector3( x, 0 , y);
			InputDirection = (InputDirection.magnitude > 1.0f)?InputDirection.normalized:InputDirection;

		joystickImg.rectTransform.anchoredPosition=
				new Vector3(InputDirection.x * (bglmg.rectTransform.sizeDelta.x/3)
							, InputDirection.z *(bglmg.rectTransform.sizeDelta.y/3));

			Debug.Log(InputDirection);
}
}

				public virtual void OnPointerDown(PointerEventData ped)


{
		OnDrag(ped);

}
	





	public virtual void OnPointerUp(PointerEventData ped)
{

		InputDirection = Vector3.zero;
	joystickImg.rectTransform.anchoredPosition = Vector3.zero;
	}


	public float Horizontal ()
	{
		if(InputDirection.x != 0)
			return InputDirection.x;
	else
		return Input.GetAxis("Horizontal");

	}

	public float Vertical ()
	{
		if(InputDirection.x != 0)
			return InputDirection.z;
	else
			return Input.GetAxis("Vertical");


	}
}

