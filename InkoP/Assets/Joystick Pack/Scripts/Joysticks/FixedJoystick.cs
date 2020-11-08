using Assets.Inko.Script.JoystickEvent;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

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
			  .Subscribe(it => JoysitickManager.Instance.Horizontal = Horizontal)
				.AddTo(this);
		//縦軸代入
		this.ObserveEveryValueChanged(it => it.Vertical)
			  .Subscribe(it => JoysitickManager.Instance.Vertical = Vertical)
				.AddTo(this);
	}
}