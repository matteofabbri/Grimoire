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
	public class Travel_ProfileType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType travel_Profile_ReferenceField;

		private Travel_Profile_DataType travel_Profile_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Travel_Profile_Reference
		{
			get
			{
				return this.travel_Profile_ReferenceField;
			}
			set
			{
				this.travel_Profile_ReferenceField = value;
				this.RaisePropertyChanged("Travel_Profile_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Travel_Profile_DataType Travel_Profile_Data
		{
			get
			{
				return this.travel_Profile_DataField;
			}
			set
			{
				this.travel_Profile_DataField = value;
				this.RaisePropertyChanged("Travel_Profile_Data");
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
