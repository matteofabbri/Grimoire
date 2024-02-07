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
	public class Travel_Booking_File_Request_ReferencesType : INotifyPropertyChanged
	{
		private Travel_Booking_FileObjectType[] travel_Booking_File_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Travel_Booking_File_Reference", Order = 0)]
		public Travel_Booking_FileObjectType[] Travel_Booking_File_Reference
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
