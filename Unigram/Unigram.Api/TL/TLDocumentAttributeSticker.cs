// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLDocumentAttributeSticker : TLDocumentAttributeBase 
	{
		[Flags]
		public enum Flag : Int32
		{
			Mask = (1 << 1),
			MaskCoords = (1 << 0),
		}

		public bool IsMask { get { return Flags.HasFlag(Flag.Mask); } set { Flags = value ? (Flags | Flag.Mask) : (Flags & ~Flag.Mask); } }
		public bool HasMaskCoords { get { return Flags.HasFlag(Flag.MaskCoords); } set { Flags = value ? (Flags | Flag.MaskCoords) : (Flags & ~Flag.MaskCoords); } }

		public Flag Flags { get; set; }
		public String Alt { get; set; }
		public TLInputStickerSetBase StickerSet { get; set; }
		public TLMaskCoords MaskCoords { get; set; }

		public TLDocumentAttributeSticker() { }
		public TLDocumentAttributeSticker(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.DocumentAttributeSticker; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			Alt = from.ReadString();
			StickerSet = TLFactory.Read<TLInputStickerSetBase>(from);
			if (HasMaskCoords) MaskCoords = TLFactory.Read<TLMaskCoords>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			UpdateFlags();

			to.WriteInt32((Int32)Flags);
			to.WriteString(Alt ?? string.Empty);
			to.WriteObject(StickerSet);
			if (HasMaskCoords) to.WriteObject(MaskCoords);
		}

		private void UpdateFlags()
		{
			HasMaskCoords = MaskCoords != null;
		}
	}
}