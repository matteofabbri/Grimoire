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
	public class Organization_InactivateType : INotifyPropertyChanged
	{
		private bool validate_OnlyField;

		private bool validate_OnlyFieldSpecified;

		private Organization_ReferenceType organization_Reference_DataField;

		private Organization_Inactivate_DataType organization_Inactivate_DataField;

		private bool keep_in_HierarchyField;

		private bool keep_in_HierarchyFieldSpecified;

		private OrganizationObjectType organization_for_Subordinates_ReferenceField;

		private OrganizationObjectType organization_for_Included_Organizations_ReferenceField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Validate_Only
		{
			get
			{
				return this.validate_OnlyField;
			}
			set
			{
				this.validate_OnlyField = value;
				this.RaisePropertyChanged("Validate_Only");
			}
		}

		[XmlIgnore]
		public bool Validate_OnlySpecified
		{
			get
			{
				return this.validate_OnlyFieldSpecified;
			}
			set
			{
				this.validate_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Validate_OnlySpecified");
			}
		}

		[XmlElement(Order = 1)]
		public Organization_ReferenceType Organization_Reference_Data
		{
			get
			{
				return this.organization_Reference_DataField;
			}
			set
			{
				this.organization_Reference_DataField = value;
				this.RaisePropertyChanged("Organization_Reference_Data");
			}
		}

		[XmlElement(Order = 2)]
		public Organization_Inactivate_DataType Organization_Inactivate_Data
		{
			get
			{
				return this.organization_Inactivate_DataField;
			}
			set
			{
				this.organization_Inactivate_DataField = value;
				this.RaisePropertyChanged("Organization_Inactivate_Data");
			}
		}

		[XmlElement(Order = 3)]
		public bool Keep_in_Hierarchy
		{
			get
			{
				return this.keep_in_HierarchyField;
			}
			set
			{
				this.keep_in_HierarchyField = value;
				this.RaisePropertyChanged("Keep_in_Hierarchy");
			}
		}

		[XmlIgnore]
		public bool Keep_in_HierarchySpecified
		{
			get
			{
				return this.keep_in_HierarchyFieldSpecified;
			}
			set
			{
				this.keep_in_HierarchyFieldSpecified = value;
				this.RaisePropertyChanged("Keep_in_HierarchySpecified");
			}
		}

		[XmlElement(Order = 4)]
		public OrganizationObjectType Organization_for_Subordinates_Reference
		{
			get
			{
				return this.organization_for_Subordinates_ReferenceField;
			}
			set
			{
				this.organization_for_Subordinates_ReferenceField = value;
				this.RaisePropertyChanged("Organization_for_Subordinates_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public OrganizationObjectType Organization_for_Included_Organizations_Reference
		{
			get
			{
				return this.organization_for_Included_Organizations_ReferenceField;
			}
			set
			{
				this.organization_for_Included_Organizations_ReferenceField = value;
				this.RaisePropertyChanged("Organization_for_Included_Organizations_Reference");
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
