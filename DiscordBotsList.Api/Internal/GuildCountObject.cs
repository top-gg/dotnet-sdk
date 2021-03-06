﻿using DiscordBotsList.Api.Objects;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace DiscordBotsList.Api.Internal
{
    internal class GuildCountObject
    {
        [JsonPropertyName("server_count")]
        internal int guildCount;

        public GuildCountObject(int count)
        {
            guildCount = count;
        }
    }

    internal class BotStatsObject : ShardedObject, IDblBotStats
    {
        public int GuildCount => guildCount;

        public IReadOnlyList<int> Shards => shards.ToList();

        public int ShardCount => shardCount;

        [JsonPropertyName("server_count")]
        internal int guildCount;
    }

    internal class ShardedObject
    {
        [JsonPropertyName("shards")]
        internal int[] shards;

        [JsonPropertyName("shard_count")]
        internal int shardCount;
    }

    internal class ShardedGuildCountObject
    {
        [JsonPropertyName("shards")]
        public int[] Shards;

        [JsonPropertyName("shard_id")]
        public int ShardId;

        [JsonPropertyName("shard_count")]
        public int ShardCount;

        [JsonPropertyName("server_count")]
        public int GuildCount;
    }
}