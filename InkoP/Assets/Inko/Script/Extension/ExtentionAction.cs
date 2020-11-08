using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 拡張メソッド　Action
/// </summary>
namespace ExtensionMethods
{
    public static class ExtentionAction
    {
        //Nullチェックしてよぶ
        public static void SafeCall(this Action action) {

            if (action == null) {
                return;
            }
            action.Invoke();
        }
    }
}