using UniRx;
using Assets.Inko.Script.Extension;
using UnityEngine;
/// <summary>
/// ジョイスティックの管理マネージャー
/// </summary>
namespace Assets.Inko.Script.JoystickEvent
{
    public class JoysitickManager : SingletonMonoBehaviour<JoysitickManager>
    {
        public  float Horizontal { get; private set; }
        public float Vertical { get; private set; }

        public Vector2ReactiveProperty Forward = new Vector2ReactiveProperty();


        public void SetHorizontal(float val)
        {
            Horizontal = val;
            Forward.SetValueAndForceNotify( new Vector2(Horizontal, Vertical));
        }

        public void SetVertical(float val)
        {
            Vertical = val;
            Forward.SetValueAndForceNotify( new Vector2(Horizontal,Vertical));
        }
    }
}