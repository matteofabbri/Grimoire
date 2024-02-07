using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Location_Content_DataType : INotifyPropertyChanged
	{
		private IDType[] integration_ID_DataField;

		private string location_NameField;

		private Location_Type_Reference_DataType[] location_Type_ReferenceField;

		private Time_Profile_Reference_DataType[] time_Profile_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlArray(Order = 0), XmlArrayItem("ID", IsNullable = false)]
		public IDType[] Integration_ID_Data
		{
			get
			{
				return this.integration_ID_DataField;
			}
			set
			{
				this.integration_ID_DataField = value;
				this.RaisePropertyChanged("Integration_ID_Data");
			}
		}

		[XmlElement(Order = 1)]
		public string Location_Name
		{
			get
			{
				return this.location_NameField;
			}
			set
			{
				this.location_NameField = value;
				this.RaisePropertyChanged("Location_Name");
			}
		}

		[XmlElement("Location_Type_Reference", Order = 2)]
		public Location_Type_Reference_DataType[] Location_Type_Reference
		{
			get
			{
				return this.location_Type_ReferenceField;
			}
			set
			{
				this.location_Type_ReferenceField = value;
				this.RaisePropertyChanged("Location_Type_Reference");
			}
		}

		[XmlElement("Time_Profile_Reference", Order = 3)]
		public Time_Profile_Reference_DataType[] Time_Profile_Reference
		{
			get
			{
				return this.time_Profile_ReferenceField;
			}
			set
			{
				this.time_Profile_ReferenceField = value;
				this.RaisePropertyChanged("Time_Profile_Reference");
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
