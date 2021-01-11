using UnityEngine;
using UnityEditor;

namespace Assets.Inko.Script.Enum
{
    public class CharaEnum
    {

        /// <summary>
        ///Character状態
        /// </summary>
        public enum CharaState
        {
            None = 0,
            Idle = 1,
            Attack = 2,
            Jump = 3,
            Move = 4,
        };
    }
}