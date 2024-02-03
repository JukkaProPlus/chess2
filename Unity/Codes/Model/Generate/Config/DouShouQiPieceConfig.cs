using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class DouShouQiPieceConfigCategory : ProtoObject, IMerge
    {
        public static DouShouQiPieceConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, DouShouQiPieceConfig> dict = new Dictionary<int, DouShouQiPieceConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<DouShouQiPieceConfig> list = new List<DouShouQiPieceConfig>();
		
        public DouShouQiPieceConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            DouShouQiPieceConfigCategory s = o as DouShouQiPieceConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (DouShouQiPieceConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public DouShouQiPieceConfig Get(int id)
        {
            this.dict.TryGetValue(id, out DouShouQiPieceConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (DouShouQiPieceConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, DouShouQiPieceConfig> GetAll()
        {
            return this.dict;
        }

        public DouShouQiPieceConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class DouShouQiPieceConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>可吃掉的棋子Id</summary>
		[ProtoMember(2)]
		public int[] FoodIds { get; set; }
		/// <summary>名字</summary>
		[ProtoMember(3)]
		public int Name { get; set; }

	}
}
