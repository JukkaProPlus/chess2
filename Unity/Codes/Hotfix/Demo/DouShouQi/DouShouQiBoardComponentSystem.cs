using System;
using ET;

namespace ET
{
    public class DouShouQiBoardComponentAwakeSystem:AwakeSystem<DouShouQiBoardComponent, int>
    {
        public override void Awake(DouShouQiBoardComponent self, int a)
        {
            self.Pieces.Clear();
            self.roomID = a;
        }
    }
    public class DouShouQiBoardComponentDestroySystem:DestroySystem<DouShouQiBoardComponent>
    {
        public override void Destroy(DouShouQiBoardComponent self)
        {
            for (int i = 0; i < self.Pieces.Count; i++)
            {
                self.Pieces[i].Dispose();
            }
            self.Pieces.Clear();
            self.roomID = 0;
        }
    }

    [FriendClass(typeof(DouShouQiBoardComponent))]
    public static class DouShouQiBoardComponentSystem
    {
        public static bool addPiece(this DouShouQiBoardComponent self, long OwnerInstanceId, int PieceId, int X, int Y)
        {
            if (self.Pieces.Count >= 32)
            {
#if NOT_UNITY
                Log.Error($"棋盘上棋子已满");
#else
                TipHelper.ShowTip(self.ZoneScene(), "棋盘上棋子已满");
#endif
                return false;
            }
            DouShouQIPiece piece = self.AddChild<DouShouQIPiece,long ,int,int,int>(OwnerInstanceId, PieceId, X, Y);
            self.Pieces.Add(piece);
            return true;
        }
        public static bool canMoveTo(this DouShouQiBoardComponent self, int sourceX, int sourceY, int destX, int destY)
        {
            if (self.Pieces.Count == 0)
            {
#if NOT_UNITY
                Log.Error($"棋盘上没有棋子,{sourceX},{sourceY}");
#else
                TipHelper.ShowTip(self.ZoneScene(), $"棋盘上没有棋子,{sourceX},{sourceY}");
#endif
                return false;
            }
            DouShouQIPiece sourcePiece = null;
            for(int i = 0; i < self.Pieces.Count; i++)
            {
                if (self.Pieces[i].X == sourceX && self.Pieces[i].Y == sourceY)
                {
                    sourcePiece = self.Pieces[i];
                    break;
                }
            }
            if (sourcePiece == null)
            {
#if NOT_UNITY
                Log.Error($"棋盘上没有棋子,{sourceX},{sourceY}");
#else
                TipHelper.ShowTip(self.ZoneScene(), $"棋盘上没有棋子,{sourceX},{sourceY}");
#endif
                return false;
            }

            DouShouQIPiece destPiece = null;
            for (int i = 0; i < self.Pieces.Count; i++)
            {
                if (self.Pieces[i].X == destX && self.Pieces[i].Y == destY)
                {
                    destPiece = self.Pieces[i];
                    break;
                }
            }
            if (destPiece == null)
            {
                return true;
            }
            
            return DouShouQiPieceConfigCategory.Instance.CanEat(sourcePiece, destPiece);
        }
        public static bool isAllPlayerReady(this DouShouQiBoardComponent self)
        {
            return self.playerAReady && self.playerBReady;
        }
        public static bool isPlayerReady(this DouShouQiBoardComponent self, long playerInstanceId)
        {
            if (self.playerAID == playerInstanceId)
            {
                return self.playerAReady;
            }
            else if (self.playerBID == playerInstanceId)
            {
                return self.playerBReady;
            }
            return false;
        }
#if !SERVER
        public static bool isMeReady(this DouShouQiBoardComponent self)
        {
            Log.Info($"self.playerAID = {self.playerAID}");
            Log.Info($"self.playerBID = {self.playerBID}");
            Log.Info($"playerAReady = {self.playerAReady}");
            Log.Info($"playerBReady = {self.playerBReady}");
            Log.Info($"MyId = {self.DomainScene().GetComponent<PlayerComponent>().MyId}");
            return isPlayerReady(self, self.DomainScene().GetComponent<PlayerComponent>().MyId);
        }
        public static bool isOpponentReady(this DouShouQiBoardComponent self)
        {
            return isPlayerReady(self, self.GetOpponentPlayerID(self.DomainScene().GetComponent<PlayerComponent>().MyId));
        }
        public static void setMeReadyState(this DouShouQiBoardComponent self, bool isReady = true)
        {
            setPlayerReadyState(self, self.DomainScene().GetComponent<PlayerComponent>().MyId, isReady);
            Game.EventSystem.Publish(new EventType.DouShouQiPlayerReadyState(){PlayerInstanceId = self.ZoneScene().GetComponent<PlayerComponent>().MyId, ZoneScene = self.ZoneScene(), IsReady = isReady});
        }
#endif
        
        
        public static bool setPlayerReadyState(this DouShouQiBoardComponent self, long playerInstanceId, bool isReady = true)
        {
            if (self.playerAID == playerInstanceId)
            {
                self.playerAReady = isReady;
                return true;
            }
            if (self.playerBID == playerInstanceId)
            {
                self.playerBReady = isReady;
                return true;
            }
            return false;
        }
        
        

        public static void resetAllPlayerReady(this DouShouQiBoardComponent self)
        {
            self.playerAReady = false;
            self.playerBReady = false;
        }

        public static bool isFull(this DouShouQiBoardComponent self)
        {
            return self.playerAID == 0 || self.playerBID == 0;
        }

        public static void FromMessage(this DouShouQiBoardComponent self, DouShouQiBoardProto proto)
        {
            self.playerBReady = proto.playerBReady;
            self.playerAID = proto.playerAID;
            self.playerBID = proto.playerBID;
            self.playerAReady = proto.playerAReady;
            self.roomID = proto.roomID;
            self.curTurnPlayerID = proto.curTurnPlayerID;
            for (int i = 0; i < self.Pieces.Count; i++)
            {
                self.Pieces[i].Dispose();
            }
            self.Pieces.Clear();
            for (int i = 0; i < proto.Pieces.Count; i++)
            {
                DouShouQIPiece piece = self.AddChild<DouShouQIPiece, long, int, int, int>(proto.Pieces[i].OwnerInstanceId, proto.Pieces[i].PieceId, proto.Pieces[i].x, proto.Pieces[i].y);
                self.Pieces.Add(piece);
            }
        }

        public static DouShouQiBoardProto ToMessage(this DouShouQiBoardComponent self)
        {
            DouShouQiBoardProto proto = new DouShouQiBoardProto();
            proto.playerBReady = self.playerBReady;
            proto.playerAID = self.playerAID;
            proto.playerBID = self.playerBID;
            proto.playerAReady = self.playerAReady;
            proto.roomID = self.roomID;
            proto.curTurnPlayerID = self.curTurnPlayerID;
            for (int i = 0; i < self.Pieces.Count; i++)
            {
                proto.Pieces.Add(self.Pieces[i].ToMessage());
            }

            return proto;
        }
        public static long GetOpponentPlayerID(this DouShouQiBoardComponent self, long playerID)
        {
            if (self.playerAID == playerID)
            {
                return self.playerBID;
            }
            else if (self.playerBID == playerID)
            {
                return self.playerAID;
            }
            return 0;
        }

        public static bool LeaveBoard(this DouShouQiBoardComponent self, long playerID)
        {
            if (self.playerAID == playerID)
            {
                self.playerAID = 0;
                self.playerAReady = false;
                // #if SERVER
                //     // long opponentPlayerID = GetOpponentPlayerID(self, playerID);
                //     // self.DomainScene().GetComponent<PlayerComponent>()
                //     // self.domainScene.GetComponent<DouShouQiPlayerComponent>().SendLeaveBoard(opponentPlayerID);
                // #endif
                return true;
            }
            else if (self.playerBID == playerID)
            {
                self.playerBID = 0;
                self.playerBReady = false;
                return true;
            }

            return false;
        }
    }
}