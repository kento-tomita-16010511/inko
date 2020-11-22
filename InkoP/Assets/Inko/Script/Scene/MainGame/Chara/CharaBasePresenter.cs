/// <summary>
/// キャラクタ－のベース
/// </summary>
using Assets.Inko.Script.Base;
using Assets.Inko.Script.Scene.MainGame.Chara;
using UnityEngine;
using UnityEngine.UI;

public class CharaBasePresenter : BasePresenter<CharaBaseModel, CharaBaseView>
{
    [SerializeField] private Image _charaImage;

    protected override void Bind()
    {
    }

    protected override void InitializingAfterSubsc()
    {
    }

    protected override void InitializingBeforeSubsc()
    {
    }

    protected override void SetEvent()
    {
    }
}
