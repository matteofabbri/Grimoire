using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Default_Position_Organization_Assignments_DataType : INotifyPropertyChanged
	{
		private CompanyObjectType[] company_Assignments_ReferenceField;

		private Cost_CenterObjectType[] cost_Center_Assignments_ReferenceField;

		private RegionObjectType[] region_Assignments_ReferenceField;

		private Custom_OrganizationObjectType[] custom_Organization_Assignments_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Company_Assignments_Reference", Order = 0)]
		public CompanyObjectType[] Company_Assignments_Reference
		{
			get
			{
				return this.company_Assignments_ReferenceField;
			}
			set
			{
				this.company_Assignments_ReferenceField = value;
				this.RaisePropertyChanged("Company_Assignments_Reference");
			}
		}

		[XmlElement("Cost_Center_Assignments_Reference", Order = 1)]
		public Cost_CenterObjectType[] Cost_Center_Assignments_Reference
		{
			get
			{
				return this.cost_Center_Assignments_ReferenceField;
			}
			set
			{
				this.cost_Center_Assignments_ReferenceField = value;
				this.RaisePropertyChanged("Cost_Center_Assignments_Reference");
			}
		}

		[XmlElement("Region_Assignments_Reference", Order = 2)]
		public RegionObjectType[] Region_Assignments_Reference
		{
			get
			{
				return this.region_Assignments_ReferenceField;
			}
			set
			{
				this.region_Assignments_ReferenceField = value;
				this.RaisePropertyChanged("Region_Assignments_Reference");
			}
		}

		[XmlElement("Custom_Organization_Assignments_Reference", Order = 3)]
		public Custom_OrganizationObjectType[] Custom_Organization_Assignments_Reference
		{
			get
			{
				return this.custom_Organization_Assignments_ReferenceField;
			}
			set
			{
				this.custom_Organization_Assignments_ReferenceField = value;
				this.RaisePropertyChanged("Custom_Organization_Assignments_Reference");
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
