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
	public class Payroll_Worktag_DataType : INotifyPropertyChanged
	{
		private CompanyObjectType[] company_Worktag_ReferenceField;

		private LocationObjectType[] location_Worktag_ReferenceField;

		private RegionObjectType[] region_Worktag_ReferenceField;

		private Job_ProfileObjectType[] job_Profile_Worktag_ReferenceField;

		private Cost_CenterObjectType[] cost_Center_Worktag_ReferenceField;

		private ProjectObjectType[] project_Worktag_ReferenceField;

		private Withholding_Order_CaseObjectType[] withholding_Order_Worktag_ReferenceField;

		private Payroll_State_AuthorityObjectType[] payroll_State_Authority_Worktag_ReferenceField;

		private Payroll_Local_County_AuthorityObjectType[] payroll_Local_County_Authority_Worktag_ReferenceField;

		private Payroll_Local_City_AuthorityObjectType[] payroll_Local_City_Authority_Worktag_ReferenceField;

		private Payroll_Local_School_District_AuthorityObjectType[] payroll_Local_School_District_Worktag_ReferenceField;

		private Payroll_Other_AuthorityObjectType[] payroll_Local_Other_Worktag_ReferenceField;

		private Custom_Worktag_01ObjectType[] custom_Worktag_1_ReferenceField;

		private Custom_Worktag_02ObjectType[] custom_Worktag_2_ReferenceField;

		private Custom_Worktag_03ObjectType[] custom_Worktag_3_ReferenceField;

		private Custom_Worktag_04ObjectType[] custom_Worktag_4_ReferenceField;

		private Custom_Worktag_05ObjectType[] custom_Worktag_5_ReferenceField;

		private FundObjectType fund_Worktag_ReferenceField;

		private GrantObjectType grant_Worktag_ReferenceField;

		private GiftObjectType gift_Worktag_ReferenceField;

		private ProgramObjectType program_Worktag_ReferenceField;

		private Business_UnitObjectType business_Unit_Worktag_ReferenceField;

		private Object_ClassObjectType object_Class_Worktag_ReferenceField;

		private Project_Plan_PhaseObjectType project_Phase_Worktag_ReferenceField;

		private Project_Plan_TaskObjectType project_Task_Worktag_ReferenceField;

		private Custom_Organization_Worktag_DataType[] custom_Organization_Worktag_DataField;

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

		private NI_CategoryObjectType nI_Category_ReferenceField;

		private ARRCOAGIRC_Rubric_ValueObjectType aRRCOAGIRC_Category_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Company_Worktag_Reference", Order = 0)]
		public CompanyObjectType[] Company_Worktag_Reference
		{
			get
			{
				return this.company_Worktag_ReferenceField;
			}
			set
			{
				this.company_Worktag_ReferenceField = value;
				this.RaisePropertyChanged("Company_Worktag_Reference");
			}
		}

		[XmlElement("Location_Worktag_Reference", Order = 1)]
		public LocationObjectType[] Location_Worktag_Reference
		{
			get
			{
				return this.location_Worktag_ReferenceField;
			}
			set
			{
				this.location_Worktag_ReferenceField = value;
				this.RaisePropertyChanged("Location_Worktag_Reference");
			}
		}

		[XmlElement("Region_Worktag_Reference", Order = 2)]
		public RegionObjectType[] Region_Worktag_Reference
		{
			get
			{
				return this.region_Worktag_ReferenceField;
			}
			set
			{
				this.region_Worktag_ReferenceField = value;
				this.RaisePropertyChanged("Region_Worktag_Reference");
			}
		}

		[XmlElement("Job_Profile_Worktag_Reference", Order = 3)]
		public Job_ProfileObjectType[] Job_Profile_Worktag_Reference
		{
			get
			{
				return this.job_Profile_Worktag_ReferenceField;
			}
			set
			{
				this.job_Profile_Worktag_ReferenceField = value;
				this.RaisePropertyChanged("Job_Profile_Worktag_Reference");
			}
		}

		[XmlElement("Cost_Center_Worktag_Reference", Order = 4)]
		public Cost_CenterObjectType[] Cost_Center_Worktag_Reference
		{
			get
			{
				return this.cost_Center_Worktag_ReferenceField;
			}
			set
			{
				this.cost_Center_Worktag_ReferenceField = value;
				this.RaisePropertyChanged("Cost_Center_Worktag_Reference");
			}
		}

		[XmlElement("Project_Worktag_Reference", Order = 5)]
		public ProjectObjectType[] Project_Worktag_Reference
		{
			get
			{
				return this.project_Worktag_ReferenceField;
			}
			set
			{
				this.project_Worktag_ReferenceField = value;
				this.RaisePropertyChanged("Project_Worktag_Reference");
			}
		}

		[XmlElement("Withholding_Order_Worktag_Reference", Order = 6)]
		public Withholding_Order_CaseObjectType[] Withholding_Order_Worktag_Reference
		{
			get
			{
				return this.withholding_Order_Worktag_ReferenceField;
			}
			set
			{
				this.withholding_Order_Worktag_ReferenceField = value;
				this.RaisePropertyChanged("Withholding_Order_Worktag_Reference");
			}
		}

		[XmlElement("Payroll_State_Authority_Worktag_Reference", Order = 7)]
		public Payroll_State_AuthorityObjectType[] Payroll_State_Authority_Worktag_Reference
		{
			get
			{
				return this.payroll_State_Authority_Worktag_ReferenceField;
			}
			set
			{
				this.payroll_State_Authority_Worktag_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_State_Authority_Worktag_Reference");
			}
		}

		[XmlElement("Payroll_Local_County_Authority_Worktag_Reference", Order = 8)]
		public Payroll_Local_County_AuthorityObjectType[] Payroll_Local_County_Authority_Worktag_Reference
		{
			get
			{
				return this.payroll_Local_County_Authority_Worktag_ReferenceField;
			}
			set
			{
				this.payroll_Local_County_Authority_Worktag_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Local_County_Authority_Worktag_Reference");
			}
		}

		[XmlElement("Payroll_Local_City_Authority_Worktag_Reference", Order = 9)]
		public Payroll_Local_City_AuthorityObjectType[] Payroll_Local_City_Authority_Worktag_Reference
		{
			get
			{
				return this.payroll_Local_City_Authority_Worktag_ReferenceField;
			}
			set
			{
				this.payroll_Local_City_Authority_Worktag_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Local_City_Authority_Worktag_Reference");
			}
		}

		[XmlElement("Payroll_Local_School_District_Worktag_Reference", Order = 10)]
		public Payroll_Local_School_District_AuthorityObjectType[] Payroll_Local_School_District_Worktag_Reference
		{
			get
			{
				return this.payroll_Local_School_District_Worktag_ReferenceField;
			}
			set
			{
				this.payroll_Local_School_District_Worktag_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Local_School_District_Worktag_Reference");
			}
		}

		[XmlElement("Payroll_Local_Other_Worktag_Reference", Order = 11)]
		public Payroll_Other_AuthorityObjectType[] Payroll_Local_Other_Worktag_Reference
		{
			get
			{
				return this.payroll_Local_Other_Worktag_ReferenceField;
			}
			set
			{
				this.payroll_Local_Other_Worktag_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Local_Other_Worktag_Reference");
			}
		}

		[XmlElement("Custom_Worktag_1_Reference", Order = 12)]
		public Custom_Worktag_01ObjectType[] Custom_Worktag_1_Reference
		{
			get
			{
				return this.custom_Worktag_1_ReferenceField;
			}
			set
			{
				this.custom_Worktag_1_ReferenceField = value;
				this.RaisePropertyChanged("Custom_Worktag_1_Reference");
			}
		}

		[XmlElement("Custom_Worktag_2_Reference", Order = 13)]
		public Custom_Worktag_02ObjectType[] Custom_Worktag_2_Reference
		{
			get
			{
				return this.custom_Worktag_2_ReferenceField;
			}
			set
			{
				this.custom_Worktag_2_ReferenceField = value;
				this.RaisePropertyChanged("Custom_Worktag_2_Reference");
			}
		}

		[XmlElement("Custom_Worktag_3_Reference", Order = 14)]
		public Custom_Worktag_03ObjectType[] Custom_Worktag_3_Reference
		{
			get
			{
				return this.custom_Worktag_3_ReferenceField;
			}
			set
			{
				this.custom_Worktag_3_ReferenceField = value;
				this.RaisePropertyChanged("Custom_Worktag_3_Reference");
			}
		}

		[XmlElement("Custom_Worktag_4_Reference", Order = 15)]
		public Custom_Worktag_04ObjectType[] Custom_Worktag_4_Reference
		{
			get
			{
				return this.custom_Worktag_4_ReferenceField;
			}
			set
			{
				this.custom_Worktag_4_ReferenceField = value;
				this.RaisePropertyChanged("Custom_Worktag_4_Reference");
			}
		}

		[XmlElement("Custom_Worktag_5_Reference", Order = 16)]
		public Custom_Worktag_05ObjectType[] Custom_Worktag_5_Reference
		{
			get
			{
				return this.custom_Worktag_5_ReferenceField;
			}
			set
			{
				this.custom_Worktag_5_ReferenceField = value;
				this.RaisePropertyChanged("Custom_Worktag_5_Reference");
			}
		}

		[XmlElement(Order = 17)]
		public FundObjectType Fund_Worktag_Reference
		{
			get
			{
				return this.fund_Worktag_ReferenceField;
			}
			set
			{
				this.fund_Worktag_ReferenceField = value;
				this.RaisePropertyChanged("Fund_Worktag_Reference");
			}
		}

		[XmlElement(Order = 18)]
		public GrantObjectType Grant_Worktag_Reference
		{
			get
			{
				return this.grant_Worktag_ReferenceField;
			}
			set
			{
				this.grant_Worktag_ReferenceField = value;
				this.RaisePropertyChanged("Grant_Worktag_Reference");
			}
		}

		[XmlElement(Order = 19)]
		public GiftObjectType Gift_Worktag_Reference
		{
			get
			{
				return this.gift_Worktag_ReferenceField;
			}
			set
			{
				this.gift_Worktag_ReferenceField = value;
				this.RaisePropertyChanged("Gift_Worktag_Reference");
			}
		}

		[XmlElement(Order = 20)]
		public ProgramObjectType Program_Worktag_Reference
		{
			get
			{
				return this.program_Worktag_ReferenceField;
			}
			set
			{
				this.program_Worktag_ReferenceField = value;
				this.RaisePropertyChanged("Program_Worktag_Reference");
			}
		}

		[XmlElement(Order = 21)]
		public Business_UnitObjectType Business_Unit_Worktag_Reference
		{
			get
			{
				return this.business_Unit_Worktag_ReferenceField;
			}
			set
			{
				this.business_Unit_Worktag_ReferenceField = value;
				this.RaisePropertyChanged("Business_Unit_Worktag_Reference");
			}
		}

		[XmlElement(Order = 22)]
		public Object_ClassObjectType Object_Class_Worktag_Reference
		{
			get
			{
				return this.object_Class_Worktag_ReferenceField;
			}
			set
			{
				this.object_Class_Worktag_ReferenceField = value;
				this.RaisePropertyChanged("Object_Class_Worktag_Reference");
			}
		}

		[XmlElement(Order = 23)]
		public Project_Plan_PhaseObjectType Project_Phase_Worktag_Reference
		{
			get
			{
				return this.project_Phase_Worktag_ReferenceField;
			}
			set
			{
				this.project_Phase_Worktag_ReferenceField = value;
				this.RaisePropertyChanged("Project_Phase_Worktag_Reference");
			}
		}

		[XmlElement(Order = 24)]
		public Project_Plan_TaskObjectType Project_Task_Worktag_Reference
		{
			get
			{
				return this.project_Task_Worktag_ReferenceField;
			}
			set
			{
				this.project_Task_Worktag_ReferenceField = value;
				this.RaisePropertyChanged("Project_Task_Worktag_Reference");
			}
		}

		[XmlElement("Custom_Organization_Worktag_Data", Order = 25)]
		public Custom_Organization_Worktag_DataType[] Custom_Organization_Worktag_Data
		{
			get
			{
				return this.custom_Organization_Worktag_DataField;
			}
			set
			{
				this.custom_Organization_Worktag_DataField = value;
				this.RaisePropertyChanged("Custom_Organization_Worktag_Data");
			}
		}

		[XmlElement(Order = 26)]
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

		[XmlElement(Order = 27)]
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

		[XmlElement(Order = 28)]
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

		[XmlElement(Order = 29)]
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

		[XmlElement(Order = 30)]
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

		[XmlElement(Order = 31)]
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

		[XmlElement(Order = 32)]
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

		[XmlElement(Order = 33)]
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

		[XmlElement(Order = 34)]
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

		[XmlElement(Order = 35)]
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

		[XmlElement(Order = 36)]
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

		[XmlElement("ARRCO-AGIRC_Category_Reference", Order = 37)]
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
