using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankU.PlayerInput
{
    [CreateAssetMenu]
    public class InputScriptable : ScriptableObject
    {
        [SerializeField] private InputKey _inputKeys;

        public InputKey InputKeys => _inputKeys;
    }
}
