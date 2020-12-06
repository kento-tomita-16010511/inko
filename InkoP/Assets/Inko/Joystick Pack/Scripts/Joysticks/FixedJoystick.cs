using Assets.Inko.Script.JoystickEvent;
using UniRx;

public class FixedJoystick : Joystick
{
    public void Update()
	{
		JoysitickManager.Instance.SetHorizontal(Horizontal);
		JoysitickManager.Instance.SetVertical(Vertical);
	}
}