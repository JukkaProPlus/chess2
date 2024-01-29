using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class LanguageZHCNConfigCategory : ProtoObject, IMerge
    {
        public static LanguageZHCNConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, LanguageZHCNConfig> dict = new Dictionary<int, LanguageZHCNConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<LanguageZHCNConfig> list = new List<LanguageZHCNConfig>();
		
        public LanguageZHCNConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            LanguageZHCNConfigCategory s = o as LanguageZHCNConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (LanguageZHCNConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public LanguageZHCNConfig Get(int id)
        {
            this.dict.TryGetValue(id, out LanguageZHCNConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (LanguageZHCNConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, LanguageZHCNConfig> GetAll()
        {
            return this.dict;
        }

        public LanguageZHCNConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class LanguageZHCNConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>字符串</summary>
		[ProtoMember(2)]
		public string Str { get; set; }

	}
}
