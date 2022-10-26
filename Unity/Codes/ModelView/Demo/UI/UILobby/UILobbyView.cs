﻿using System;
using UnityEngine;

namespace ET
{
    [UIComponent]
	public class UILobbyView : Entity,IAwake,IOnCreate,IOnEnable<Scene>
    {
        public static string PrefabPath => "UI/UILobby/Prefabs/UILobbyView.prefab";
        public Scene zoneScene;
        public UIButton EnterBtn;
    }
}