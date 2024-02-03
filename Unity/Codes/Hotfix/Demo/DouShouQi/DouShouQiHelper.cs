using System;

namespace ET
{
    public static class DouShouQiHelper
    {
        public static async ETTask<int> ReqEnterBoard(Scene zoneScene, int boardId)
        {
            M2C_EnterDouShouQiRoom m2CEnterBoard = null;
            try
            {
                m2CEnterBoard = (M2C_EnterDouShouQiRoom)await zoneScene.GetComponent<SessionComponent>().Session.Call(new C2M_EnterDouShouQiRoom() { RoomId = 0 });
            }
            catch (System.Exception e)
            {
                Log.Error(e.ToString());
                return ErrorCode.ERR_NetWorkError;
            }

            if (m2CEnterBoard.Error != ErrorCode.ERR_Success)
            {
                Log.Error(m2CEnterBoard.Error.ToString());
                return m2CEnterBoard.Error;
            }
            zoneScene.AddComponent<DouShouQiPlayerComponent>();
            DouShouQiBoardComponent board = zoneScene.AddComponent<DouShouQiBoardComponent, int>(0);
            board.FromMessage(m2CEnterBoard.Board);
            zoneScene.GetComponent<DouShouQiPlayerComponent>().SetBoard(board);
            return ErrorCode.ERR_Success;
        }

        public static async ETTask<int> ReqLeaveBoard(Scene zoneScene)
        {
            M2C_LeaveDouShouQiRoom m2CLeaveBoard = null;
            try
            {
                m2CLeaveBoard = (M2C_LeaveDouShouQiRoom)await zoneScene.GetComponent<SessionComponent>().Session.Call(new C2M_LeaveDouShouQiRoom());
            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
                return ErrorCode.ERR_NetWorkError;
            }
            if (m2CLeaveBoard.Error != ErrorCode.ERR_Success)
            {
                Log.Error(m2CLeaveBoard.Error.ToString());
                return m2CLeaveBoard.Error;
            }
            zoneScene.RemoveComponent<DouShouQiBoardComponent>();
            zoneScene.RemoveComponent<DouShouQiPlayerComponent>();

            return ErrorCode.ERR_Success;
        }

        public static async ETTask<int> ReqPrepare(Scene zoneScene, bool isPrepare)
        {
            M2C_Prepare m2CPrepare = null;
            try
            {
                m2CPrepare = (M2C_Prepare) await zoneScene.GetComponent<SessionComponent>().Session.Call(new C2M_Prepare(){IsPrepare = isPrepare});
            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
                return ErrorCode.ERR_NetWorkError;
            }
            if (m2CPrepare.Error != ErrorCode.ERR_Success)
            {
                Log.Error(m2CPrepare.Error.ToString());
                return m2CPrepare.Error;
            }

            zoneScene.GetComponent<DouShouQiBoardComponent>().setMeReadyState(isPrepare);
            return ErrorCode.ERR_Success;
        }
    }
}