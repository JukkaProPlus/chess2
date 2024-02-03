namespace ET
{
    public class DouShouQiComponentAwakeSystem:AwakeSystem<DouShouQiComponent>
    {
        public override void Awake(DouShouQiComponent self)
        {
            self.Boards.Clear();
            for (int i = 0; i < 100; i++)
            {
                self.CreateNewBoard();
            }
        }
    }
    [FriendClass(typeof(DouShouQiComponent))]
    [FriendClass(typeof(DouShouQiBoardComponent))]
    public static class DouShouQiComponentSystem
    {
        public static bool GetBoard(this DouShouQiComponent self, int roomID, out DouShouQiBoardComponent board)
        {
            for (int i = 0; i < self.Boards.Count; i++)
            {
                if (self.Boards[i].roomID == roomID)
                {
                    board = self.Boards[i];
                    return true;
                }
            }

            board = null;
            return false;
        }

        public static DouShouQiBoardComponent GetBoard(this DouShouQiComponent self, int roomID)
        {
            for (int i = 0; i < self.Boards.Count; i++)
            {
                if (self.Boards[i].roomID == roomID)
                {
                    return self.Boards[i];
                }
            }

            return null;
        }
        public static bool IsInDouShouQiBoard(this DouShouQiComponent self, long playerId)
        {
            for (int i = 0; i < self.Boards.Count; i++)
            {
                if (self.Boards[i].playerAID == playerId || self.Boards[i].playerBID == playerId)
                {
                    return true;
                }
            }

            return false;
        }
        public static bool IsInDouShouQiBoard(this DouShouQiComponent self, long playerId, out DouShouQiBoardComponent board)
        {
            for (int i = 0; i < self.Boards.Count; i++)
            {
                if (self.Boards[i].playerAID == playerId || self.Boards[i].playerBID == playerId)
                {
                    board = self.Boards[i];
                    return true;
                }
            }

            board = null;
            return false;
        }
        public static bool GetAnNotFullBoard(this DouShouQiComponent self, out DouShouQiBoardComponent board)
        {
            for (int i = 0; i < self.Boards.Count; i++)
            {
                if (self.Boards[i].playerAID == 0 || self.Boards[i].playerBID == 0)
                {
                    board = self.Boards[i];
                    return true;
                }
            }

            board = null;
            return false;
        }
        /// <summary>
        /// 进入一个棋盘，如果没有棋盘则创建一个
        /// todo: 这里应该有一个匹配算法，但是现在先不管
        /// todo: 可能有限制大厅里只能存在多少个棋盘,如果所有棋牌都是满的，则不能创建新棋牌，也不能进入，后面再考虑这个问题
        /// </summary>
        /// <param name="self"></param>
        /// <param name="playerId"></param>
        /// <param name="board"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        public static bool EnterABoard(this DouShouQiComponent self, long playerId, out DouShouQiBoardComponent board, out int error)
        {
            error = 0;
            for (int i = 0; i < self.Boards.Count; i++)
            {
                if (self.Boards[i].playerAID == 0)
                {
                    self.Boards[i].playerAID = playerId;
                    board = self.Boards[i];
                    return true;
                }
                else if (self.Boards[i].playerBID == 0)
                {
                    self.Boards[i].playerBID = playerId;
                    board = self.Boards[i];
                    return true;
                }
            }

            board = CreateNewBoard(self, playerId);
            return true;
        }

        /// <summary>
        /// 指定房间号进入一个棋盘，如果没有棋盘则无法进入
        /// todo: 这里应该有一个匹配算法，但是现在先不管
        /// todo: 可能有限制大厅里只能存在多少个棋盘,如果所有棋牌都是满的，则不能创建新棋牌，也不能进入，后面再考虑这个问题
        /// </summary>
        /// <param name="self"></param>
        /// <param name="playerId"></param>
        /// <param name="board"></param>
        /// <param name="error"></param>
        /// <param name="roomID"></param>
        /// <returns></returns>
        public static bool EnterABoard(this DouShouQiComponent self, long playerId, out DouShouQiBoardComponent board, out int error, int roomID = 0)
        {
            if (roomID == 0)
            {
                return EnterABoard(self, playerId, out board, out error);
            }
            if (GetBoard(self, roomID, out board))
            {
                if (board.isFull())
                {
                    error = ErrorCode.ERR_DouShouQiRoomIsFull;
                    board = null;
                    return false;
                }
                else
                {
                    if (board.playerAID == 0)
                    {
                        board.playerAID = playerId;
                        error = 0;
                        return true;
                    }
                    else if (board.playerBID == 0)
                    {
                        board.playerBID = playerId;
                        error = 0;
                        return true;
                    }
                    else
                    {
                        error = ErrorCode.ERR_DouShouQiRoomIsFull;
                        board = null;
                        return false;
                    }
                }
            }
            else
            {
                board = null;
                error = ErrorCode.ERR_DouShouQiRoomNotExist;
                return false;
            }
            
        }
        public static bool GetAnNotFullBoard(this DouShouQiComponent self, out DouShouQiBoardComponent board, out int index)
        {
            for (int i = 0; i < self.Boards.Count; i++)
            {
                if (self.Boards[i].playerAID == 0 || self.Boards[i].playerBID == 0)
                {
                    board = self.Boards[i];
                    index = i;
                    return true;
                }
            }

            board = null;
            index = -1;
            return false;
        }
        public static DouShouQiBoardComponent GetBoardByPlayerId(this DouShouQiComponent self, long playerId)
        {
            for (int i = 0; i < self.Boards.Count; i++)
            {
                if (self.Boards[i].playerAID == playerId || self.Boards[i].playerBID == playerId)
                {
                    return self.Boards[i];
                }
            }

            return null;
        }
        public static DouShouQiBoardComponent GetBoardByIndex(this DouShouQiComponent self, int index)
        {
            if (index < 0 || index >= self.Boards.Count)
            {
                return null;
            }

            return self.Boards[index];
        }
        public static DouShouQiBoardComponent CreateNewBoard(this DouShouQiComponent self, long playerAID = 0, long playerBID = 0)
        {
            DouShouQiBoardComponent board = self.AddChild<DouShouQiBoardComponent,int>(self.Boards.Count + 1);
            self.Boards.Add(board);
            board.playerAID = playerAID;
            board.playerBID = playerBID;
            return board;
        }
    }
}