using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Document
    {
        public long DocNum { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public long DocCategory { get; set; }
        public long PatNum { get; set; }
        public string FileName { get; set; }
        public byte ImgType { get; set; }
        public byte IsFlipped { get; set; }
        public short DegreesRotated { get; set; }
        public string ToothNumbers { get; set; }
        public string Note { get; set; }
        public byte SigIsTopaz { get; set; }
        public string Signature { get; set; }
        public int CropX { get; set; }
        public int CropY { get; set; }
        public int CropW { get; set; }
        public int CropH { get; set; }
        public int WindowingMin { get; set; }
        public int WindowingMax { get; set; }
        public long MountItemNum { get; set; }
        public DateTime DateTstamp { get; set; }
        public string RawBase64 { get; set; }
        public string Thumbnail { get; set; }
        public string ExternalGuid { get; set; }
        public string ExternalSource { get; set; }
    }
}
