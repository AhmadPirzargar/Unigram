// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Channels.Methods
{
	/// <summary>
	/// RCP method channels.editTitle.
	/// Returns <see cref="Telegram.Api.TL.TLUpdatesBase"/>
	/// </summary>
	public partial class TLChannelsEditTitle : TLObject
	{
		public TLInputChannelBase Channel { get; set; }
		public String Title { get; set; }

		public TLChannelsEditTitle() { }
		public TLChannelsEditTitle(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ChannelsEditTitle; } }

		public override void Read(TLBinaryReader from)
		{
			Channel = TLFactory.Read<TLInputChannelBase>(from);
			Title = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteObject(Channel);
			to.WriteString(Title ?? string.Empty);
		}
	}
}