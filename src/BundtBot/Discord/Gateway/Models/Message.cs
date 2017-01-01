﻿using System;
using BundtBot.Discord.Models;
using Newtonsoft.Json;

namespace BundtBot.Discord.Gateway.Models
{
    public class Message
	{
		internal DiscordClient client;

		[JsonProperty("id")]
		public ulong ID;
		
		[JsonProperty("channel_id")]
		public ulong ChannelId;

	    public Channel Channel => client.Channels[ChannelId];

		/// <summary>
		/// The author of this message (the author of a message is not guaranteed to be a user*).
		/// </summary>
		[JsonProperty("author")]
		public User Author;
		
		[JsonProperty("content")]
		public string Content;
		
		[JsonProperty("timestamp")]
		public DateTime Timestamp;
		
		[JsonProperty("edited_timestamp")]
		public DateTime? EditedTimestamp;
		
		[JsonProperty("tts")]
		public bool IsTextToSpeech;
		
		[JsonProperty("mention_everyone")]
		public bool MentionsEveryone;
		
		[JsonProperty("mentions")]
		public User[] MentionedUsers;
		
		[JsonProperty("mention_roles")]
		public ulong[] MentionedRoles;
		
		[JsonProperty("attachments")]
		public Attachment[] AttachedFiles;
		
		[JsonProperty("embeds")]
		public Embed[] EmbeddedContent;
		
		[JsonProperty("reactions")]
		public Reaction[] Reactions;

		/// <summary>
		/// Used for validating a message was sent.
		/// </summary>
		[JsonProperty("nonce")]
		public ulong? Nonce;
		
		[JsonProperty("pinned")]
		public bool IsPinned;

		/// <summary>
		/// If the message is generated by a webhook, this is the webhook's id.
		/// </summary>
		[JsonProperty("webhook_id")]
		public string WebhookId;
	}
}
