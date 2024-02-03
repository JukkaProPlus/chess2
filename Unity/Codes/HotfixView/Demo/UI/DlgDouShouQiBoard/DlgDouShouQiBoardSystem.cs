using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    [FriendClass(typeof(DlgDouShouQiBoard))]
    [FriendClassAttribute(typeof(ET.ES_Piece))]
    [FriendClassAttribute(typeof(ET.DouShouQiBoardComponent))]
    public static class DlgDouShouQiBoardSystem
    {

        public static void RegisterUIEvent(this DlgDouShouQiBoard self)
        {
            self.View.EButton_CloseButton.AddListener(async () =>
            {
                int err = await DouShouQiHelper.ReqLeaveBoard(self.ZoneScene());
                if (err == ErrorCode.ERR_Success)
                {
                    self.ZoneScene().GetComponent<UIComponent>().CloseWindow(WindowID.WindowID_DouShouQiBoard);
                }
            });
            self.View.EButton_PrepareMeButton.AddListener(() =>
            {
                bool isPrepare = !self.ZoneScene().GetComponent<DouShouQiBoardComponent>().isMeReady();
                DouShouQiHelper.ReqPrepare(self.ZoneScene(), isPrepare).Coroutine();
            });
        }

        public static void ShowWindow(this DlgDouShouQiBoard self, Entity contextData = null)
        {
            self.ESPieces[0] = self.View.ES_Piece0;
            self.ESPieces[1] = self.View.ES_Piece1;
            self.ESPieces[2] = self.View.ES_Piece2;
            self.ESPieces[3] = self.View.ES_Piece3;
            self.ESPieces[4] = self.View.ES_Piece4;
            self.ESPieces[5] = self.View.ES_Piece5;
            self.ESPieces[6] = self.View.ES_Piece6;
            self.ESPieces[7] = self.View.ES_Piece7;
            self.ESPieces[8] = self.View.ES_Piece8;
            self.ESPieces[9] = self.View.ES_Piece9;
            self.ESPieces[10] = self.View.ES_Piece10;
            self.ESPieces[11] = self.View.ES_Piece11;
            self.ESPieces[12] = self.View.ES_Piece12;
            self.ESPieces[13] = self.View.ES_Piece13;
            self.ESPieces[14] = self.View.ES_Piece14;
            self.ESPieces[15] = self.View.ES_Piece15;

            self.positions[0] = self.View.EPos0Image.transform;
            self.positions[1] = self.View.EPos1Image.transform;
            self.positions[2] = self.View.EPos2Image.transform;
            self.positions[3] = self.View.EPos3Image.transform;
            self.positions[4] = self.View.EPos4Image.transform;
            self.positions[5] = self.View.EPos5Image.transform;
            self.positions[6] = self.View.EPos6Image.transform;
            self.positions[7] = self.View.EPos7Image.transform;
            self.positions[8] = self.View.EPos8Image.transform;
            self.positions[9] = self.View.EPos9Image.transform;
            self.positions[10] = self.View.EPos10Image.transform;
            self.positions[11] = self.View.EPos11Image.transform;
            self.positions[12] = self.View.EPos12Image.transform;
            self.positions[13] = self.View.EPos13Image.transform;
            self.positions[14] = self.View.EPos14Image.transform;
            self.positions[15] = self.View.EPos15Image.transform;

            self.Refresh();
        }
        public static void Refresh(this DlgDouShouQiBoard self)
        {
            Log.Info("Refresh DlgDouShouQiBoard A");
            DouShouQiBoardComponent board = self.ZoneScene().GetComponent<DouShouQiBoardComponent>();
            self.View.ELabel_PrepareText.text = board.isMeReady()
                    ? LanguageHelper.GetLanguageString(20) : LanguageHelper.GetLanguageString(19);      //"取消准备" : "准备";
            self.View.ELabel_PrepareOpponentText.text = board.isOpponentReady()
                    ? LanguageHelper.GetLanguageString(21) : LanguageHelper.GetLanguageString(22);
            long myId = self.DomainScene().GetComponent<PlayerComponent>().MyId;
            self.View.ELabel_MyNameText.text = myId == 0 ? "" : myId.ToString();
            long opponentId = board.GetOpponentPlayerID(myId);
            self.View.ELabel_OpponentNameText.text = opponentId == 0 ? "" : opponentId.ToString();

            for (int i = 0; i < 16; i++)
            {
                self.ESPieces[i].uiTransform.gameObject.SetActive(false);
            }

            for (int i = 0; i < board.Pieces.Count; i++)
            {
                DouShouQIPiece piece = board.Pieces[i]; 
                int x = piece.X;
                int y = piece.Y;
                int index = x + y * 4;
                self.ESPieces[index].uiTransform.gameObject.SetActive(true);
                self.ESPieces[index].E_LabelText.text = LanguageHelper.GetLanguageString(DouShouQiPieceConfigCategory.Instance.Get(piece.PieceId).Name);
                self.ESPieces[index].E_SpriteImage.color = piece.OwnerInstanceId == myId ? Color.blue : Color.red;
            }
            Log.Info("Refresh DlgDouShouQiBoard B");
        }
    }
}
