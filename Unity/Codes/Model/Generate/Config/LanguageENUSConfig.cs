using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class LanguageENUSConfigCategory : ProtoObject, IMerge
    {
        public static LanguageENUSConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, LanguageENUSConfig> dict = new Dictionary<int, LanguageENUSConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<LanguageENUSConfig> list = new List<LanguageENUSConfig>();
		
        public LanguageENUSConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            LanguageENUSConfigCategory s = o as LanguageENUSConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (LanguageENUSConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public LanguageENUSConfig Get(int id)
        {
            this.dict.TryGetValue(id, out LanguageENUSConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (LanguageENUSConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, LanguageENUSConfig> GetAll()
        {
            return this.dict;
        }

        public LanguageENUSConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class LanguageENUSConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>字符串</summary>
		[ProtoMember(2)]
		public string Str { get; set; }

	}
}
