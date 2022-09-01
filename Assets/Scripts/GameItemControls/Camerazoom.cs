using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Camerazoom : MonoBehaviour
{
	Camera mainCamera;

	float touchesPrevPosDifference, touchesCurPosDifference, zoomModifier;

	Vector2 firstTouchPrevPos, secondTouchPrevPos;

	[SerializeField]
	float zoomModifierSpeed = 0.1f;

	

	// Use this for initialization
	void Start()
	{
		mainCamera = GetComponent<Camera>();
	}

	// Update is called once per frame
	void Update()
	{

		if (Input.touchCount == 2)
		{
			Touch firstTouch = Input.GetTouch(0);
			Touch secondTouch = Input.GetTouch(1);

			firstTouchPrevPos = firstTouch.position - firstTouch.deltaPosition;
			secondTouchPrevPos = secondTouch.position - secondTouch.deltaPosition;

			touchesPrevPosDifference = (firstTouchPrevPos - secondTouchPrevPos).magnitude;
			touchesCurPosDifference = (firstTouch.position - secondTouch.position).magnitude;

			zoomModifier = (firstTouch.deltaPosition - secondTouch.deltaPosition).magnitude * zoomModifierSpeed;

			if (touchesPrevPosDifference > touchesCurPosDifference)
				mainCamera.fieldOfView += zoomModifier;
			if (touchesPrevPosDifference < touchesCurPosDifference)
				mainCamera.fieldOfView -= zoomModifier;

		}

		mainCamera.fieldOfView = Mathf.Clamp(mainCamera.fieldOfView, 24f, 90f);
		

	}


}
