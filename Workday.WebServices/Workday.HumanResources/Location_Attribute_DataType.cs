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
	public class Location_Attribute_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string location_Attribute_NameField;

		private Location_UsageObjectType[] location_Usage_ReferenceField;

		private bool location_Attribute_InactiveField;

		private bool location_Attribute_InactiveFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Location_Attribute_Name
		{
			get
			{
				return this.location_Attribute_NameField;
			}
			set
			{
				this.location_Attribute_NameField = value;
				this.RaisePropertyChanged("Location_Attribute_Name");
			}
		}

		[XmlElement("Location_Usage_Reference", Order = 2)]
		public Location_UsageObjectType[] Location_Usage_Reference
		{
			get
			{
				return this.location_Usage_ReferenceField;
			}
			set
			{
				this.location_Usage_ReferenceField = value;
				this.RaisePropertyChanged("Location_Usage_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public bool Location_Attribute_Inactive
		{
			get
			{
				return this.location_Attribute_InactiveField;
			}
			set
			{
				this.location_Attribute_InactiveField = value;
				this.RaisePropertyChanged("Location_Attribute_Inactive");
			}
		}

		[XmlIgnore]
		public bool Location_Attribute_InactiveSpecified
		{
			get
			{
				return this.location_Attribute_InactiveFieldSpecified;
			}
			set
			{
				this.location_Attribute_InactiveFieldSpecified = value;
				this.RaisePropertyChanged("Location_Attribute_InactiveSpecified");
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
