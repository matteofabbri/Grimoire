using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Simple_Cost_Center_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string organization_NameField;

		private Organization_SubtypeObjectType organization_Subtype_ReferenceField;

		private Custom_OrganizationObjectType[] organization_Container_ReferenceField;

		private OrganizationObjectType[] restricted_To_Company_or_Company_Hierarchy_ReferenceField;

		private DateTime processing_Effective_DateField;

		private bool processing_Effective_DateFieldSpecified;

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
		public string Organization_Name
		{
			get
			{
				return this.organization_NameField;
			}
			set
			{
				this.organization_NameField = value;
				this.RaisePropertyChanged("Organization_Name");
			}
		}

		[XmlElement(Order = 2)]
		public Organization_SubtypeObjectType Organization_Subtype_Reference
		{
			get
			{
				return this.organization_Subtype_ReferenceField;
			}
			set
			{
				this.organization_Subtype_ReferenceField = value;
				this.RaisePropertyChanged("Organization_Subtype_Reference");
			}
		}

		[XmlElement("Organization_Container_Reference", Order = 3)]
		public Custom_OrganizationObjectType[] Organization_Container_Reference
		{
			get
			{
				return this.organization_Container_ReferenceField;
			}
			set
			{
				this.organization_Container_ReferenceField = value;
				this.RaisePropertyChanged("Organization_Container_Reference");
			}
		}

		[XmlElement("Restricted_To_Company_or_Company_Hierarchy_Reference", Order = 4)]
		public OrganizationObjectType[] Restricted_To_Company_or_Company_Hierarchy_Reference
		{
			get
			{
				return this.restricted_To_Company_or_Company_Hierarchy_ReferenceField;
			}
			set
			{
				this.restricted_To_Company_or_Company_Hierarchy_ReferenceField = value;
				this.RaisePropertyChanged("Restricted_To_Company_or_Company_Hierarchy_Reference");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified, DataType = "date")]
		public DateTime Processing_Effective_Date
		{
			get
			{
				return this.processing_Effective_DateField;
			}
			set
			{
				this.processing_Effective_DateField = value;
				this.RaisePropertyChanged("Processing_Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Processing_Effective_DateSpecified
		{
			get
			{
				return this.processing_Effective_DateFieldSpecified;
			}
			set
			{
				this.processing_Effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Processing_Effective_DateSpecified");
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
