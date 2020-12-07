using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Sheetfielddef
    {
        public long SheetFieldDefNum { get; set; }
        public long SheetDefNum { get; set; }
        public int FieldType { get; set; }
        public string FieldName { get; set; }
        public string FieldValue { get; set; }
        public float FontSize { get; set; }
        public string FontName { get; set; }
        public sbyte FontIsBold { get; set; }
        public int Xpos { get; set; }
        public int Ypos { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int GrowthBehavior { get; set; }
        public string RadioButtonValue { get; set; }
        public string RadioButtonGroup { get; set; }
        public sbyte IsRequired { get; set; }
        public int TabOrder { get; set; }
        public string ReportableName { get; set; }
        public sbyte TextAlign { get; set; }
        public sbyte IsPaymentOption { get; set; }
        public int ItemColor { get; set; }
        public sbyte IsLocked { get; set; }
        public int TabOrderMobile { get; set; }
        public string UiLabelMobile { get; set; }
        public string UiLabelMobileRadioButton { get; set; }
        public sbyte LayoutMode { get; set; }
        public string Language { get; set; }
    }
}
