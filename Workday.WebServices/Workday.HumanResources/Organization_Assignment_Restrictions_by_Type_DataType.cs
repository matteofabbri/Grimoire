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
	public class Organization_Assignment_Restrictions_by_Type_DataType : INotifyPropertyChanged
	{
		private Organization_TypeObjectType organization_Type_ReferenceField;

		private Staff_Allowed_DataType[] allowed_Organization_DataField;

		private Staff_Default_DataType[] default_Organization_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Organization_TypeObjectType Organization_Type_Reference
		{
			get
			{
				return this.organization_Type_ReferenceField;
			}
			set
			{
				this.organization_Type_ReferenceField = value;
				this.RaisePropertyChanged("Organization_Type_Reference");
			}
		}

		[XmlElement("Allowed_Organization_Data", Order = 1)]
		public Staff_Allowed_DataType[] Allowed_Organization_Data
		{
			get
			{
				return this.allowed_Organization_DataField;
			}
			set
			{
				this.allowed_Organization_DataField = value;
				this.RaisePropertyChanged("Allowed_Organization_Data");
			}
		}

		[XmlElement("Default_Organization_Data", Order = 2)]
		public Staff_Default_DataType[] Default_Organization_Data
		{
			get
			{
				return this.default_Organization_DataField;
			}
			set
			{
				this.default_Organization_DataField = value;
				this.RaisePropertyChanged("Default_Organization_Data");
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
