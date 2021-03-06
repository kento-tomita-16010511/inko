﻿using DG.Tweening;
using ExtensionMethods;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Scene
{
    /// <summary>
    /// シーンの基底クラス
    /// </summary>
    public class SceneBase : MonoBehaviour
    {
        [SerializeField] protected CanvasGroup _fadeCanvas;
        [SerializeField] protected Camera _fadeCamera;
        private readonly float _fadeoutTime = 0.5f;

        protected virtual void Awake() {
            // イベントにイベントハンドラーを追加
            UnityEngine.SceneManagement.SceneManager.sceneLoaded += SceneLoaded;
        }

        /// <summary>
        /// Sceneのロード 
        /// </summary>
        /// <param name="sceneName">SceneConst内のやつ使う</param>
        protected void SceneLoad(string sceneName)
        {
            // Fadeout 開始
            StartCoroutine(FadeOut(() =>
            {
                //シーンの読み込み
                UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
            }));
        }

        /// <summary>
        /// Sceneのフェードアウトが完了すると呼ばれる
        /// </summary>
        protected void SceneFadeinFinish()
        {

        }

        private IEnumerator FadeOut(Action callback)
        {
             _fadeCanvas.DOFade(1.0F, _fadeoutTime).SetEase(Ease.InQuad);
            yield return new WaitForSeconds(_fadeoutTime);
            callback.SafeCall();
        }

        private IEnumerator FadeIn(Action callback)
        {
            _fadeCanvas.DOFade(0.0F, _fadeoutTime).SetEase(Ease.InQuad);
            yield return new WaitForSeconds(_fadeoutTime);
            callback.SafeCall();
        }

        // イベントハンドラー（イベント発生時に動かしたい処理）
        void SceneLoaded(UnityEngine.SceneManagement.Scene nextScene, LoadSceneMode mode)
        {
            _fadeCanvas.alpha = 1f;
            // FadeIn 開始
            StartCoroutine(FadeIn(() => { SceneFadeinFinish(); }));
        }
    }
}