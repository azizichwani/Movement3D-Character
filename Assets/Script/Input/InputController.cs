using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TankU.PlayerInput{
    public class InputController : MonoBehaviour
    {
        
        [SerializeField] private InputScriptable inputScriptable;

        public Vector3 MoveInput()
        {
            if(Input.GetKey(inputScriptable.InputKeys.LeftKey)) return Vector3.left;
            if(Input.GetKey(inputScriptable.InputKeys.RightKey)) return Vector3.right;
            if(Input.GetKey(inputScriptable.InputKeys.UpKey)) return Vector3.forward;
            if(Input.GetKey(inputScriptable.InputKeys.DownKey)) return Vector3.back;
            return Vector3.zero;
        }

        public Vector3 RotateInput()
        {
            if(Input.GetKey(inputScriptable.InputKeys.RotateLeft)) return new Vector3(0,-1,0);
            if(Input.GetKey(inputScriptable.InputKeys.RotateRight)) return new Vector3(0,1,0);
            return Vector3.zero;
        }
    }
}
