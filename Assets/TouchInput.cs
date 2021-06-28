using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchInput : MonoBehaviour
{
    public delegate void TapAction(Touch t);
    public static event TapAction onTap;
    public Vector2 movement;
    public float tapMaxMovement = 50f;
   public bool tapGesture = false;

    // Update is called once per frame
   private void Update()
    {
        if(Input.touchCount>0)
        {
            Touch touch = Input.touches[0];
            if(touch.phase==TouchPhase.Began)
            {
                movement = Vector2.zero;
            }
            else if(touch.phase==TouchPhase.Moved|| touch.phase==TouchPhase.Stationary)
            {
                movement = movement + touch.deltaPosition;
                if(movement.magnitude>tapMaxMovement)
                {
                    tapGesture = true;
                }
            }
            else
            {
                if(!tapGesture)
                {
                    if(onTap!=null)
                    {
                        onTap(touch);
                    }
                }
                tapGesture = false;
            }
        }
    }
}
