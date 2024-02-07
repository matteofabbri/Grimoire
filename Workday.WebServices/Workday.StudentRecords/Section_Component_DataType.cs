using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Section_Component_DataType : INotifyPropertyChanged
	{
		private Standard_Meeting_PatternObjectType meeting_Pattern_ReferenceField;

		private Custom_Meeting_Pattern_DataType custom_Meeting_Pattern_DataField;

		private LocationObjectType location_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Standard_Meeting_PatternObjectType Meeting_Pattern_Reference
		{
			get
			{
				return this.meeting_Pattern_ReferenceField;
			}
			set
			{
				this.meeting_Pattern_ReferenceField = value;
				this.RaisePropertyChanged("Meeting_Pattern_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Custom_Meeting_Pattern_DataType Custom_Meeting_Pattern_Data
		{
			get
			{
				return this.custom_Meeting_Pattern_DataField;
			}
			set
			{
				this.custom_Meeting_Pattern_DataField = value;
				this.RaisePropertyChanged("Custom_Meeting_Pattern_Data");
			}
		}

		[XmlElement(Order = 2)]
		public LocationObjectType Location_Reference
		{
			get
			{
				return this.location_ReferenceField;
			}
			set
			{
				this.location_ReferenceField = value;
				this.RaisePropertyChanged("Location_Reference");
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
