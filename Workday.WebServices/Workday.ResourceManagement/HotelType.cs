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
	public class HotelType : INotifyPropertyChanged
	{
		private HotelObjectType hotel_ReferenceField;

		private Hotel_DataType[] hotel_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public HotelObjectType Hotel_Reference
		{
			get
			{
				return this.hotel_ReferenceField;
			}
			set
			{
				this.hotel_ReferenceField = value;
				this.RaisePropertyChanged("Hotel_Reference");
			}
		}

		[XmlElement("Hotel_Data", Order = 1)]
		public Hotel_DataType[] Hotel_Data
		{
			get
			{
				return this.hotel_DataField;
			}
			set
			{
				this.hotel_DataField = value;
				this.RaisePropertyChanged("Hotel_Data");
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
