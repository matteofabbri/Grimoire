using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Organization_Hierarchy_DataType : INotifyPropertyChanged
	{
		private OrganizationObjectType topLevel_Organization_ReferenceField;

		private OrganizationObjectType superior_Organization_ReferenceField;

		private OrganizationObjectType[] subordinate_Organization_ReferenceField;

		private OrganizationObjectType[] included_Organization_ReferenceField;

		private OrganizationObjectType[] included_In_Organization_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Top-Level_Organization_Reference", Order = 0)]
		public OrganizationObjectType TopLevel_Organization_Reference
		{
			get
			{
				return this.topLevel_Organization_ReferenceField;
			}
			set
			{
				this.topLevel_Organization_ReferenceField = value;
				this.RaisePropertyChanged("TopLevel_Organization_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public OrganizationObjectType Superior_Organization_Reference
		{
			get
			{
				return this.superior_Organization_ReferenceField;
			}
			set
			{
				this.superior_Organization_ReferenceField = value;
				this.RaisePropertyChanged("Superior_Organization_Reference");
			}
		}

		[XmlElement("Subordinate_Organization_Reference", Order = 2)]
		public OrganizationObjectType[] Subordinate_Organization_Reference
		{
			get
			{
				return this.subordinate_Organization_ReferenceField;
			}
			set
			{
				this.subordinate_Organization_ReferenceField = value;
				this.RaisePropertyChanged("Subordinate_Organization_Reference");
			}
		}

		[XmlElement("Included_Organization_Reference", Order = 3)]
		public OrganizationObjectType[] Included_Organization_Reference
		{
			get
			{
				return this.included_Organization_ReferenceField;
			}
			set
			{
				this.included_Organization_ReferenceField = value;
				this.RaisePropertyChanged("Included_Organization_Reference");
			}
		}

		[XmlElement("Included_In_Organization_Reference", Order = 4)]
		public OrganizationObjectType[] Included_In_Organization_Reference
		{
			get
			{
				return this.included_In_Organization_ReferenceField;
			}
			set
			{
				this.included_In_Organization_ReferenceField = value;
				this.RaisePropertyChanged("Included_In_Organization_Reference");
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
