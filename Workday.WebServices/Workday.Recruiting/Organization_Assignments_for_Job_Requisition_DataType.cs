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
	public class Organization_Assignments_for_Job_Requisition_DataType : INotifyPropertyChanged
	{
		private CompanyObjectType company_Assignment_ReferenceField;

		private Cost_CenterObjectType cost_Center_Assignment_ReferenceField;

		private RegionObjectType region_Assignment_ReferenceField;

		private Business_UnitObjectType business_Unit_Assignment_ReferenceField;

		private GrantObjectType grant_Assignment_ReferenceField;

		private ProgramObjectType program_Assignment_ReferenceField;

		private FundObjectType fund_Assignment_ReferenceField;

		private GiftObjectType gift_Assignment_ReferenceField;

		private Custom_OrganizationObjectType[] custom_Organization_Assignment_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public CompanyObjectType Company_Assignment_Reference
		{
			get
			{
				return this.company_Assignment_ReferenceField;
			}
			set
			{
				this.company_Assignment_ReferenceField = value;
				this.RaisePropertyChanged("Company_Assignment_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Cost_CenterObjectType Cost_Center_Assignment_Reference
		{
			get
			{
				return this.cost_Center_Assignment_ReferenceField;
			}
			set
			{
				this.cost_Center_Assignment_ReferenceField = value;
				this.RaisePropertyChanged("Cost_Center_Assignment_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public RegionObjectType Region_Assignment_Reference
		{
			get
			{
				return this.region_Assignment_ReferenceField;
			}
			set
			{
				this.region_Assignment_ReferenceField = value;
				this.RaisePropertyChanged("Region_Assignment_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Business_UnitObjectType Business_Unit_Assignment_Reference
		{
			get
			{
				return this.business_Unit_Assignment_ReferenceField;
			}
			set
			{
				this.business_Unit_Assignment_ReferenceField = value;
				this.RaisePropertyChanged("Business_Unit_Assignment_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public GrantObjectType Grant_Assignment_Reference
		{
			get
			{
				return this.grant_Assignment_ReferenceField;
			}
			set
			{
				this.grant_Assignment_ReferenceField = value;
				this.RaisePropertyChanged("Grant_Assignment_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public ProgramObjectType Program_Assignment_Reference
		{
			get
			{
				return this.program_Assignment_ReferenceField;
			}
			set
			{
				this.program_Assignment_ReferenceField = value;
				this.RaisePropertyChanged("Program_Assignment_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public FundObjectType Fund_Assignment_Reference
		{
			get
			{
				return this.fund_Assignment_ReferenceField;
			}
			set
			{
				this.fund_Assignment_ReferenceField = value;
				this.RaisePropertyChanged("Fund_Assignment_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public GiftObjectType Gift_Assignment_Reference
		{
			get
			{
				return this.gift_Assignment_ReferenceField;
			}
			set
			{
				this.gift_Assignment_ReferenceField = value;
				this.RaisePropertyChanged("Gift_Assignment_Reference");
			}
		}

		[XmlElement("Custom_Organization_Assignment_Reference", Order = 8)]
		public Custom_OrganizationObjectType[] Custom_Organization_Assignment_Reference
		{
			get
			{
				return this.custom_Organization_Assignment_ReferenceField;
			}
			set
			{
				this.custom_Organization_Assignment_ReferenceField = value;
				this.RaisePropertyChanged("Custom_Organization_Assignment_Reference");
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
