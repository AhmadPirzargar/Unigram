// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLChatParticipantsForbidden : TLChatParticipantsBase 
	{
		[Flags]
		public enum Flag : Int32
		{
			SelfParticipant = (1 << 0),
		}

		public bool HasSelfParticipant { get { return Flags.HasFlag(Flag.SelfParticipant); } set { Flags = value ? (Flags | Flag.SelfParticipant) : (Flags & ~Flag.SelfParticipant); } }

		public Flag Flags { get; set; }
		public TLChatParticipantBase SelfParticipant { get; set; }

		public TLChatParticipantsForbidden() { }
		public TLChatParticipantsForbidden(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ChatParticipantsForbidden; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			ChatId = from.ReadInt32();
			if (HasSelfParticipant) SelfParticipant = TLFactory.Read<TLChatParticipantBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			UpdateFlags();

			to.WriteInt32((Int32)Flags);
			to.WriteInt32(ChatId);
			if (HasSelfParticipant) to.WriteObject(SelfParticipant);
		}

		private void UpdateFlags()
		{
			HasSelfParticipant = SelfParticipant != null;
		}
	}
}