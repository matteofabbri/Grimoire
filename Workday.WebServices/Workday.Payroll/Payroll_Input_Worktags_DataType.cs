using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payroll_Input_Worktags_DataType : INotifyPropertyChanged
	{
		private LocationObjectType location_ReferenceField;

		private RegionObjectType region_ReferenceField;

		private Job_ProfileObjectType job_Profile_ReferenceField;

		private Cost_CenterObjectType cost_Center_ReferenceField;

		private object itemField;

		private Withholding_Order_CaseObjectType withholding_Order_Case_ReferenceField;

		private Payroll_State_AuthorityObjectType state_Authority_ReferenceField;

		private Payroll_Local_County_AuthorityObjectType county_Authority_ReferenceField;

		private Payroll_Local_City_AuthorityObjectType city_Authority_ReferenceField;

		private Payroll_Local_School_District_AuthorityObjectType school_District_Authority_ReferenceField;

		private Custom_Worktag_01ObjectType custom_Worktag_01_ReferenceField;

		private Custom_Worktag_02ObjectType custom_Worktag_02_ReferenceField;

		private Custom_Worktag_03ObjectType custom_Worktag_03_ReferenceField;

		private Custom_Worktag_04ObjectType custom_Worktag_04_ReferenceField;

		private Custom_Worktag_05ObjectType custom_Worktag_05_ReferenceField;

		private FundObjectType fund_ReferenceField;

		private GrantObjectType grant_ReferenceField;

		private GiftObjectType gift_ReferenceField;

		private ProgramObjectType program_ReferenceField;

		private Business_UnitObjectType business_Unit_ReferenceField;

		private Object_ClassObjectType object_Class_ReferenceField;

		private Custom_OrganizationObjectType[] custom_Organization_ReferenceField;

		private Custom_Worktag_06ObjectType custom_Worktag_06_ReferenceField;

		private Custom_Worktag_07ObjectType custom_Worktag_07_ReferenceField;

		private Custom_Worktag_08ObjectType custom_Worktag_08_ReferenceField;

		private Custom_Worktag_09ObjectType custom_Worktag_09_ReferenceField;

		private Custom_Worktag_10ObjectType custom_Worktag_10_ReferenceField;

		private Custom_Worktag_11ObjectType custom_Worktag_11_ReferenceField;

		private Custom_Worktag_12ObjectType custom_Worktag_12_ReferenceField;

		private Custom_Worktag_13ObjectType custom_Worktag_13_ReferenceField;

		private Custom_Worktag_14ObjectType custom_Worktag_14_ReferenceField;

		private Custom_Worktag_15ObjectType custom_Worktag_15_ReferenceField;

		private Payroll_Other_AuthorityObjectType local_Other_Tax_Authority_ReferenceField;

		private NI_CategoryObjectType nI_Category_ReferenceField;

		private ARRCOAGIRC_Rubric_ValueObjectType aRRCOAGIRC_Category_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public LocationObjectType Location_Reference
		{
			get
			{
				return this.location_ReferenceField;
			}
			set
			{
				this.location_ReferenceField = value;
				this.RaisePropertyChanged("Location_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public RegionObjectType Region_Reference
		{
			get
			{
				return this.region_ReferenceField;
			}
			set
			{
				this.region_ReferenceField = value;
				this.RaisePropertyChanged("Region_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Job_ProfileObjectType Job_Profile_Reference
		{
			get
			{
				return this.job_Profile_ReferenceField;
			}
			set
			{
				this.job_Profile_ReferenceField = value;
				this.RaisePropertyChanged("Job_Profile_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Cost_CenterObjectType Cost_Center_Reference
		{
			get
			{
				return this.cost_Center_ReferenceField;
			}
			set
			{
				this.cost_Center_ReferenceField = value;
				this.RaisePropertyChanged("Cost_Center_Reference");
			}
		}

		[XmlElement("Project_Phase_Reference", typeof(Project_Plan_PhaseObjectType), Order = 4), XmlElement("Project_Reference", typeof(ProjectObjectType), Order = 4), XmlElement("Project_Task_Reference", typeof(Project_Plan_TaskObjectType), Order = 4)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement(Order = 5)]
		public Withholding_Order_CaseObjectType Withholding_Order_Case_Reference
		{
			get
			{
				return this.withholding_Order_Case_ReferenceField;
			}
			set
			{
				this.withholding_Order_Case_ReferenceField = value;
				this.RaisePropertyChanged("Withholding_Order_Case_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Payroll_State_AuthorityObjectType State_Authority_Reference
		{
			get
			{
				return this.state_Authority_ReferenceField;
			}
			set
			{
				this.state_Authority_ReferenceField = value;
				this.RaisePropertyChanged("State_Authority_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public Payroll_Local_County_AuthorityObjectType County_Authority_Reference
		{
			get
			{
				return this.county_Authority_ReferenceField;
			}
			set
			{
				this.county_Authority_ReferenceField = value;
				this.RaisePropertyChanged("County_Authority_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public Payroll_Local_City_AuthorityObjectType City_Authority_Reference
		{
			get
			{
				return this.city_Authority_ReferenceField;
			}
			set
			{
				this.city_Authority_ReferenceField = value;
				this.RaisePropertyChanged("City_Authority_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public Payroll_Local_School_District_AuthorityObjectType School_District_Authority_Reference
		{
			get
			{
				return this.school_District_Authority_ReferenceField;
			}
			set
			{
				this.school_District_Authority_ReferenceField = value;
				this.RaisePropertyChanged("School_District_Authority_Reference");
			}
		}

		[XmlElement(Order = 10)]
		public Custom_Worktag_01ObjectType Custom_Worktag_01_Reference
		{
			get
			{
				return this.custom_Worktag_01_ReferenceField;
			}
			set
			{
				this.custom_Worktag_01_ReferenceField = value;
				this.RaisePropertyChanged("Custom_Worktag_01_Reference");
			}
		}

		[XmlElement(Order = 11)]
		public Custom_Worktag_02ObjectType Custom_Worktag_02_Reference
		{
			get
			{
				return this.custom_Worktag_02_ReferenceField;
			}
			set
			{
				this.custom_Worktag_02_ReferenceField = value;
				this.RaisePropertyChanged("Custom_Worktag_02_Reference");
			}
		}

		[XmlElement(Order = 12)]
		public Custom_Worktag_03ObjectType Custom_Worktag_03_Reference
		{
			get
			{
				return this.custom_Worktag_03_ReferenceField;
			}
			set
			{
				this.custom_Worktag_03_ReferenceField = value;
				this.RaisePropertyChanged("Custom_Worktag_03_Reference");
			}
		}

		[XmlElement(Order = 13)]
		public Custom_Worktag_04ObjectType Custom_Worktag_04_Reference
		{
			get
			{
				return this.custom_Worktag_04_ReferenceField;
			}
			set
			{
				this.custom_Worktag_04_ReferenceField = value;
				this.RaisePropertyChanged("Custom_Worktag_04_Reference");
			}
		}

		[XmlElement(Order = 14)]
		public Custom_Worktag_05ObjectType Custom_Worktag_05_Reference
		{
			get
			{
				return this.custom_Worktag_05_ReferenceField;
			}
			set
			{
				this.custom_Worktag_05_ReferenceField = value;
				this.RaisePropertyChanged("Custom_Worktag_05_Reference");
			}
		}

		[XmlElement(Order = 15)]
		public FundObjectType Fund_Reference
		{
			get
			{
				return this.fund_ReferenceField;
			}
			set
			{
				this.fund_ReferenceField = value;
				this.RaisePropertyChanged("Fund_Reference");
			}
		}

		[XmlElement(Order = 16)]
		public GrantObjectType Grant_Reference
		{
			get
			{
				return this.grant_ReferenceField;
			}
			set
			{
				this.grant_ReferenceField = value;
				this.RaisePropertyChanged("Grant_Reference");
			}
		}

		[XmlElement(Order = 17)]
		public GiftObjectType Gift_Reference
		{
			get
			{
				return this.gift_ReferenceField;
			}
			set
			{
				this.gift_ReferenceField = value;
				this.RaisePropertyChanged("Gift_Reference");
			}
		}

		[XmlElement(Order = 18)]
		public ProgramObjectType Program_Reference
		{
			get
			{
				return this.program_ReferenceField;
			}
			set
			{
				this.program_ReferenceField = value;
				this.RaisePropertyChanged("Program_Reference");
			}
		}

		[XmlElement(Order = 19)]
		public Business_UnitObjectType Business_Unit_Reference
		{
			get
			{
				return this.business_Unit_ReferenceField;
			}
			set
			{
				this.business_Unit_ReferenceField = value;
				this.RaisePropertyChanged("Business_Unit_Reference");
			}
		}

		[XmlElement(Order = 20)]
		public Object_ClassObjectType Object_Class_Reference
		{
			get
			{
				return this.object_Class_ReferenceField;
			}
			set
			{
				this.object_Class_ReferenceField = value;
				this.RaisePropertyChanged("Object_Class_Reference");
			}
		}

		[XmlElement("Custom_Organization_Reference", Order = 21)]
		public Custom_OrganizationObjectType[] Custom_Organization_Reference
		{
			get
			{
				return this.custom_Organization_ReferenceField;
			}
			set
			{
				this.custom_Organization_ReferenceField = value;
				this.RaisePropertyChanged("Custom_Organization_Reference");
			}
		}

		[XmlElement(Order = 22)]
		public Custom_Worktag_06ObjectType Custom_Worktag_06_Reference
		{
			get
			{
				return this.custom_Worktag_06_ReferenceField;
			}
			set
			{
				this.custom_Worktag_06_ReferenceField = value;
				this.RaisePropertyChanged("Custom_Worktag_06_Reference");
			}
		}

		[XmlElement(Order = 23)]
		public Custom_Worktag_07ObjectType Custom_Worktag_07_Reference
		{
			get
			{
				return this.custom_Worktag_07_ReferenceField;
			}
			set
			{
				this.custom_Worktag_07_ReferenceField = value;
				this.RaisePropertyChanged("Custom_Worktag_07_Reference");
			}
		}

		[XmlElement(Order = 24)]
		public Custom_Worktag_08ObjectType Custom_Worktag_08_Reference
		{
			get
			{
				return this.custom_Worktag_08_ReferenceField;
			}
			set
			{
				this.custom_Worktag_08_ReferenceField = value;
				this.RaisePropertyChanged("Custom_Worktag_08_Reference");
			}
		}

		[XmlElement(Order = 25)]
		public Custom_Worktag_09ObjectType Custom_Worktag_09_Reference
		{
			get
			{
				return this.custom_Worktag_09_ReferenceField;
			}
			set
			{
				this.custom_Worktag_09_ReferenceField = value;
				this.RaisePropertyChanged("Custom_Worktag_09_Reference");
			}
		}

		[XmlElement(Order = 26)]
		public Custom_Worktag_10ObjectType Custom_Worktag_10_Reference
		{
			get
			{
				return this.custom_Worktag_10_ReferenceField;
			}
			set
			{
				this.custom_Worktag_10_ReferenceField = value;
				this.RaisePropertyChanged("Custom_Worktag_10_Reference");
			}
		}

		[XmlElement(Order = 27)]
		public Custom_Worktag_11ObjectType Custom_Worktag_11_Reference
		{
			get
			{
				return this.custom_Worktag_11_ReferenceField;
			}
			set
			{
				this.custom_Worktag_11_ReferenceField = value;
				this.RaisePropertyChanged("Custom_Worktag_11_Reference");
			}
		}

		[XmlElement(Order = 28)]
		public Custom_Worktag_12ObjectType Custom_Worktag_12_Reference
		{
			get
			{
				return this.custom_Worktag_12_ReferenceField;
			}
			set
			{
				this.custom_Worktag_12_ReferenceField = value;
				this.RaisePropertyChanged("Custom_Worktag_12_Reference");
			}
		}

		[XmlElement(Order = 29)]
		public Custom_Worktag_13ObjectType Custom_Worktag_13_Reference
		{
			get
			{
				return this.custom_Worktag_13_ReferenceField;
			}
			set
			{
				this.custom_Worktag_13_ReferenceField = value;
				this.RaisePropertyChanged("Custom_Worktag_13_Reference");
			}
		}

		[XmlElement(Order = 30)]
		public Custom_Worktag_14ObjectType Custom_Worktag_14_Reference
		{
			get
			{
				return this.custom_Worktag_14_ReferenceField;
			}
			set
			{
				this.custom_Worktag_14_ReferenceField = value;
				this.RaisePropertyChanged("Custom_Worktag_14_Reference");
			}
		}

		[XmlElement(Order = 31)]
		public Custom_Worktag_15ObjectType Custom_Worktag_15_Reference
		{
			get
			{
				return this.custom_Worktag_15_ReferenceField;
			}
			set
			{
				this.custom_Worktag_15_ReferenceField = value;
				this.RaisePropertyChanged("Custom_Worktag_15_Reference");
			}
		}

		[XmlElement(Order = 32)]
		public Payroll_Other_AuthorityObjectType Local_Other_Tax_Authority_Reference
		{
			get
			{
				return this.local_Other_Tax_Authority_ReferenceField;
			}
			set
			{
				this.local_Other_Tax_Authority_ReferenceField = value;
				this.RaisePropertyChanged("Local_Other_Tax_Authority_Reference");
			}
		}

		[XmlElement(Order = 33)]
		public NI_CategoryObjectType NI_Category_Reference
		{
			get
			{
				return this.nI_Category_ReferenceField;
			}
			set
			{
				this.nI_Category_ReferenceField = value;
				this.RaisePropertyChanged("NI_Category_Reference");
			}
		}

		[XmlElement("ARRCO-AGIRC_Category_Reference", Order = 34)]
		public ARRCOAGIRC_Rubric_ValueObjectType ARRCOAGIRC_Category_Reference
		{
			get
			{
				return this.aRRCOAGIRC_Category_ReferenceField;
			}
			set
			{
				this.aRRCOAGIRC_Category_ReferenceField = value;
				this.RaisePropertyChanged("ARRCOAGIRC_Category_Reference");
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
