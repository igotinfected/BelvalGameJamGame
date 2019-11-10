     using System.Collections;
     using UnityEngine;

     public class RotateModifierScript : MonoBehaviour {

         private float _sensitivity;
         private Vector3 _mouseReference;
         private Vector3 _mouseOffset;
         private Vector3 _rotation;
         private bool _isRotating;

        
	    public float rotateSpeed = 300f;

         void Start () {
             _sensitivity = 0.4f;
             _rotation = Vector3.zero;
         }

         void Update () {
             if (_isRotating) {
                 // offset
                 _mouseOffset = (Input.mousePosition - _mouseReference);

                 // apply rotation
                 _rotation.z = -(_mouseOffset.x) * _sensitivity;

                 // rotate
                 transform.Rotate (_rotation);

                 // store mouse
                 _mouseReference = Input.mousePosition;
             }
         }

         /// <summary>
         /// OnMouseDown is called when the user has pressed the mouse button while
         /// over the GUIElement or Collider.
         /// </summary>
         void OnMouseOver () {
             
             if (Input.GetKey (KeyCode.Z)) {
                var dir=Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
                var angle= Mathf.Atan2(dir.y, dir.x)* Mathf.Rad2Deg;
                transform.rotation=Quaternion.AngleAxis(angle, Vector3.forward);
                 /*Debug.Log ("bruh");
                 // rotating flag
                 _isRotating = true;

                 // store mouse
                 _mouseReference = Input.mousePosition; */
             
             }
         }
        private void OnMouseDown() {
            // rotating flag
            // _isRotating = false;
        }
         

     }