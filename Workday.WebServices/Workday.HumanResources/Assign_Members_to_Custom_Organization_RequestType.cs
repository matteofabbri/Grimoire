using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Assign_Members_to_Custom_Organization_RequestType : INotifyPropertyChanged
	{
		private OrganizationObjectType assign_Members_to_Custom_Organization_ReferenceField;

		private Assign_Members_to_Custom_Organization_DataType assign_Members_to_Custom_Organization_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public OrganizationObjectType Assign_Members_to_Custom_Organization_Reference
		{
			get
			{
				return this.assign_Members_to_Custom_Organization_ReferenceField;
			}
			set
			{
				this.assign_Members_to_Custom_Organization_ReferenceField = value;
				this.RaisePropertyChanged("Assign_Members_to_Custom_Organization_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Assign_Members_to_Custom_Organization_DataType Assign_Members_to_Custom_Organization_Data
		{
			get
			{
				return this.assign_Members_to_Custom_Organization_DataField;
			}
			set
			{
				this.assign_Members_to_Custom_Organization_DataField = value;
				this.RaisePropertyChanged("Assign_Members_to_Custom_Organization_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
