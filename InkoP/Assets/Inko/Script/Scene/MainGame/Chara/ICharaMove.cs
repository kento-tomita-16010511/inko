using UnityEngine;
using UnityEditor;
using System.Collections;

namespace Assets.Inko.Script.Scene.MainGame.Chara
{
	public interface ICharaMove
	{
        IEnumerator Move();
	}
}