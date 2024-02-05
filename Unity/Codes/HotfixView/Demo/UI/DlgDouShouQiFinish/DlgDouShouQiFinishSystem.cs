using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    [FriendClass(typeof(DlgDouShouQiFinish))]
    [FriendClassAttribute(typeof(ET.DouShouQiBoardComponent))]
    public static class DlgDouShouQiFinishSystem
    {

        public static void RegisterUIEvent(this DlgDouShouQiFinish self)
        {
            self.View.E_AgainButton.AddListener(async () =>
            {
                if (self.ZoneScene().GetComponent<DouShouQiBoardComponent>().winnerID == 0) 
                {
                    //说明对手已经点击了再来一局,或者退出了棋局,棋局已经重置了
                    self.ZoneScene().GetComponent<UIComponent>().CloseWindow(WindowID.WindowID_DouShouQiFinish);
                    return;
                }
                int err = await DouShouQiHelper.ReqRestartDouShouQiBoard(self.ZoneScene());
                if (err == ErrorCode.ERR_Success)
                {
                    self.ZoneScene().GetComponent<UIComponent>().CloseWindow(WindowID.WindowID_DouShouQiFinish);
                }
            });
            self.View.E_LeaveButton.AddListenerAsync(async () =>
            {
                int err = await DouShouQiHelper.ReqLeaveBoard(self.ZoneScene());
                if (err == ErrorCode.ERR_Success)
                {
                    self.ZoneScene().GetComponent<UIComponent>().CloseWindow(WindowID.WindowID_DouShouQiBoard);
                    self.ZoneScene().GetComponent<UIComponent>().CloseWindow(WindowID.WindowID_DouShouQiFinish);
                }
            });
        }

        public static void ShowWindow(this DlgDouShouQiFinish self, Entity contextData = null)
        {
            long myId = self.DomainScene().GetComponent<PlayerComponent>().MyId;
            self.View.E_ResultText.text = self.ZoneScene().GetComponent<DouShouQiBoardComponent>().winnerID == myId
                    ? LanguageHelper.GetLanguageString(25) : LanguageHelper.GetLanguageString(26);
        }



    }
}
