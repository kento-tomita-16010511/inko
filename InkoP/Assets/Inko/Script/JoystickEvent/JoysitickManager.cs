/// <summary>
/// ジョイスティックの管理マネージャー
/// </summary>

namespace Assets.Inko.Script.JoystickEvent
{
    public class JoysitickManager : SingletonMonoBehaviour<JoysitickManager>
    {
        public float Horizontal { get; private set; }
        public float Vertical { get; private set; }


        public void SetHorizontal(float val)
        {
            Horizontal = val;
        }

        public void SetVertical(float val)
        {
            Vertical = val;
        }
    }
}