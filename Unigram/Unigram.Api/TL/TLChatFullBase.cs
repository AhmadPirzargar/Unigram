// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public abstract partial class TLChatFullBase : TLObject
	{
		public Int32 Id { get; set; }
		public TLPhotoBase ChatPhoto { get; set; }
		public TLPeerNotifySettingsBase NotifySettings { get; set; }
		public TLExportedChatInviteBase ExportedInvite { get; set; }
		public TLVector<TLBotInfo> BotInfo { get; set; }
	}
}