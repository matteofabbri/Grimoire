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
	public class Assign_Position_Organization_Event_DataType : INotifyPropertyChanged
	{
		private CompanyObjectType[] company_Assignments_ReferenceField;

		private Cost_CenterObjectType[] cost_Center_Assignments_ReferenceField;

		private RegionObjectType[] region_Assignments_ReferenceField;

		private Custom_Organization_Assignment_DataType[] custom_Organization_Assignment_DataField;

		private FundObjectType[] fund_Assignments_ReferenceField;

		private GrantObjectType[] grant_Assignments_ReferenceField;

		private ProgramObjectType[] program_Assignments_ReferenceField;

		private Business_UnitObjectType[] business_Unit_Assignments_ReferenceField;

		private GiftObjectType[] gift_Assignments_ReferenceField;

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

		[XmlElement("Custom_Organization_Assignment_Data", Order = 3)]
		public Custom_Organization_Assignment_DataType[] Custom_Organization_Assignment_Data
		{
			get
			{
				return this.custom_Organization_Assignment_DataField;
			}
			set
			{
				this.custom_Organization_Assignment_DataField = value;
				this.RaisePropertyChanged("Custom_Organization_Assignment_Data");
			}
		}

		[XmlElement("Fund_Assignments_Reference", Order = 4)]
		public FundObjectType[] Fund_Assignments_Reference
		{
			get
			{
				return this.fund_Assignments_ReferenceField;
			}
			set
			{
				this.fund_Assignments_ReferenceField = value;
				this.RaisePropertyChanged("Fund_Assignments_Reference");
			}
		}

		[XmlElement("Grant_Assignments_Reference", Order = 5)]
		public GrantObjectType[] Grant_Assignments_Reference
		{
			get
			{
				return this.grant_Assignments_ReferenceField;
			}
			set
			{
				this.grant_Assignments_ReferenceField = value;
				this.RaisePropertyChanged("Grant_Assignments_Reference");
			}
		}

		[XmlElement("Program_Assignments_Reference", Order = 6)]
		public ProgramObjectType[] Program_Assignments_Reference
		{
			get
			{
				return this.program_Assignments_ReferenceField;
			}
			set
			{
				this.program_Assignments_ReferenceField = value;
				this.RaisePropertyChanged("Program_Assignments_Reference");
			}
		}

		[XmlElement("Business_Unit_Assignments_Reference", Order = 7)]
		public Business_UnitObjectType[] Business_Unit_Assignments_Reference
		{
			get
			{
				return this.business_Unit_Assignments_ReferenceField;
			}
			set
			{
				this.business_Unit_Assignments_ReferenceField = value;
				this.RaisePropertyChanged("Business_Unit_Assignments_Reference");
			}
		}

		[XmlElement("Gift_Assignments_Reference", Order = 8)]
		public GiftObjectType[] Gift_Assignments_Reference
		{
			get
			{
				return this.gift_Assignments_ReferenceField;
			}
			set
			{
				this.gift_Assignments_ReferenceField = value;
				this.RaisePropertyChanged("Gift_Assignments_Reference");
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
