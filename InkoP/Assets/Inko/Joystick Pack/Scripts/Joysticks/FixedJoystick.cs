using Assets.Inko.Script.JoystickEvent;
using UniRx;

public class FixedJoystick : Joystick
{
	private void Awake()
	{
		Bind();
	}

	private void Bind()
	{
		//横軸代入
		this.ObserveEveryValueChanged(it => it.Horizontal)
			  .Subscribe(it => JoysitickManager.Instance.SetHorizontal(Horizontal))
				.AddTo(this);
		//縦軸代入
		this.ObserveEveryValueChanged(it => it.Vertical)
			  .Subscribe(it => JoysitickManager.Instance.SetVertical(Vertical))
				.AddTo(this);
	}
}