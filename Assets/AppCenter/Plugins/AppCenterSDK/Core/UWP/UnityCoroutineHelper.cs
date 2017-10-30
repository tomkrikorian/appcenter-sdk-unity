﻿// Copyright (c) Microsoft Corporation. All rights reserved.
//
// Licensed under the MIT license.

#if UNITY_WSA_10_0
using System;
using System.Collections;
using UnityEngine;

namespace Microsoft.AppCenter.Unity.Internal.Utils
{
    using WSAApplication = UnityEngine.WSA.Application;

    public class UnityCoroutineHelper : MonoBehaviour
    {
        private static UnityCoroutineHelper Instance
        {
            get
            {
                var instance = FindObjectOfType<UnityCoroutineHelper>();
                if (instance == null)
                {
                    var gameObject = new GameObject("App Center Helper")
                    {
                        hideFlags = HideFlags.HideAndDontSave
                    };
                    DontDestroyOnLoad(gameObject);
                    instance = gameObject.AddComponent<UnityCoroutineHelper>();
                }
                return instance;
            }
        }

        public static void StartCoroutine(Func<IEnumerator> coroutine)
        {
            if (WSAApplication.RunningOnAppThread())
            {
                Instance.StartCoroutine(coroutine());
            }
            else
            {
                WSAApplication.InvokeOnAppThread(() =>
                {
                    Instance.StartCoroutine(coroutine());
                }, false);
            }
        }
    }
}
#endif
