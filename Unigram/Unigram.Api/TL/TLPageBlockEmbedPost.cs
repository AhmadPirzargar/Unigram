// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLPageBlockEmbedPost : TLPageBlockBase 
	{
		public String Url { get; set; }
		public Int64 WebPageId { get; set; }
		public Int64 AuthorPhotoId { get; set; }
		public String Author { get; set; }
		public Int32 Date { get; set; }
		public TLVector<TLPageBlockBase> Blocks { get; set; }
		public TLRichTextBase Caption { get; set; }

		public TLPageBlockEmbedPost() { }
		public TLPageBlockEmbedPost(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.PageBlockEmbedPost; } }

		public override void Read(TLBinaryReader from)
		{
			Url = from.ReadString();
			WebPageId = from.ReadInt64();
			AuthorPhotoId = from.ReadInt64();
			Author = from.ReadString();
			Date = from.ReadInt32();
			Blocks = TLFactory.Read<TLVector<TLPageBlockBase>>(from);
			Caption = TLFactory.Read<TLRichTextBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteString(Url ?? string.Empty);
			to.WriteInt64(WebPageId);
			to.WriteInt64(AuthorPhotoId);
			to.WriteString(Author ?? string.Empty);
			to.WriteInt32(Date);
			to.WriteObject(Blocks);
			to.WriteObject(Caption);
		}
	}
}