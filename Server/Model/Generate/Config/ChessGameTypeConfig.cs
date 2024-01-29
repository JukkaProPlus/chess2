using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class ChessGameTypeConfigCategory : ProtoObject, IMerge
    {
        public static ChessGameTypeConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, ChessGameTypeConfig> dict = new Dictionary<int, ChessGameTypeConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<ChessGameTypeConfig> list = new List<ChessGameTypeConfig>();
		
        public ChessGameTypeConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            ChessGameTypeConfigCategory s = o as ChessGameTypeConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (ChessGameTypeConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public ChessGameTypeConfig Get(int id)
        {
            this.dict.TryGetValue(id, out ChessGameTypeConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (ChessGameTypeConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, ChessGameTypeConfig> GetAll()
        {
            return this.dict;
        }

        public ChessGameTypeConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class ChessGameTypeConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>名字</summary>
		[ProtoMember(2)]
		public int Name { get; set; }
		/// <summary>排序</summary>
		[ProtoMember(3)]
		public int Order { get; set; }

	}
}
