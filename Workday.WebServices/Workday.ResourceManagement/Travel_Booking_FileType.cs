using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Travel_Booking_FileType : INotifyPropertyChanged
	{
		private Travel_Booking_FileObjectType travel_Booking_File_ReferenceField;

		private Travel_Booking_File_DataType[] travel_Booking_File_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Travel_Booking_FileObjectType Travel_Booking_File_Reference
		{
			get
			{
				return this.travel_Booking_File_ReferenceField;
			}
			set
			{
				this.travel_Booking_File_ReferenceField = value;
				this.RaisePropertyChanged("Travel_Booking_File_Reference");
			}
		}

		[XmlElement("Travel_Booking_File_Data", Order = 1)]
		public Travel_Booking_File_DataType[] Travel_Booking_File_Data
		{
			get
			{
				return this.travel_Booking_File_DataField;
			}
			set
			{
				this.travel_Booking_File_DataField = value;
				this.RaisePropertyChanged("Travel_Booking_File_Data");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
