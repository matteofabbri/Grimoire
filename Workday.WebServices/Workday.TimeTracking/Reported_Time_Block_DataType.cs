using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.TimeTrackingService
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Reported_Time_Block_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType worker_ReferenceField;

		private Time_Entry_CodeObjectType time_Entry_Code_ReferenceField;

		private ProjectObjectType project_ReferenceField;

		private Project_Plan_TaskObjectType project_Task_ReferenceField;

		private DateTime dateField;

		private bool dateFieldSpecified;

		private decimal quantityField;

		private bool quantityFieldSpecified;

		private DateTime in_Date_TimeField;

		private bool in_Date_TimeFieldSpecified;

		private DateTime out_Date_TimeField;

		private bool out_Date_TimeFieldSpecified;

		private Time_Punch_TypeObjectType out_Reason_ReferenceField;

		private Position_ElementObjectType[] position_ReferenceField;

		private decimal override_RateField;

		private bool override_RateFieldSpecified;

		private Business_UnitObjectType business_Unit_ReferenceField;

		private Cost_CenterObjectType cost_Center_ReferenceField;

		private Custom_OrganizationObjectType custom_Organization_01_ReferenceField;

		private Custom_OrganizationObjectType custom_Organization_02_ReferenceField;

		private Custom_OrganizationObjectType custom_Organization_03_ReferenceField;

		private Custom_OrganizationObjectType custom_Organization_04_ReferenceField;

		private Custom_OrganizationObjectType custom_Organization_05_ReferenceField;

		private Custom_OrganizationObjectType custom_Organization_06_ReferenceField;

		private Custom_OrganizationObjectType custom_Organization_07_ReferenceField;

		private Custom_OrganizationObjectType custom_Organization_08_ReferenceField;

		private Custom_OrganizationObjectType custom_Organization_09_ReferenceField;

		private Custom_OrganizationObjectType custom_Organization_10_ReferenceField;

		private Custom_Worktag_01ObjectType custom_Worktag_01_ReferenceField;

		private Custom_Worktag_02ObjectType custom_Worktag_02_ReferenceField;

		private Custom_Worktag_03ObjectType custom_Worktag_03_ReferenceField;

		private Custom_Worktag_04ObjectType custom_Worktag_04_ReferenceField;

		private Custom_Worktag_05ObjectType custom_Worktag_05_ReferenceField;

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

		private FundObjectType fund_ReferenceField;

		private GiftObjectType gift_ReferenceField;

		private GrantObjectType grant_ReferenceField;

		private Job_ProfileObjectType job_Profile_ReferenceField;

		private LocationObjectType location_ReferenceField;

		private ProgramObjectType program_ReferenceField;

		private RegionObjectType region_ReferenceField;

		private string commentField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public WorkerObjectType Worker_Reference
		{
			get
			{
				return this.worker_ReferenceField;
			}
			set
			{
				this.worker_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Time_Entry_CodeObjectType Time_Entry_Code_Reference
		{
			get
			{
				return this.time_Entry_Code_ReferenceField;
			}
			set
			{
				this.time_Entry_Code_ReferenceField = value;
				this.RaisePropertyChanged("Time_Entry_Code_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public ProjectObjectType Project_Reference
		{
			get
			{
				return this.project_ReferenceField;
			}
			set
			{
				this.project_ReferenceField = value;
				this.RaisePropertyChanged("Project_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Project_Plan_TaskObjectType Project_Task_Reference
		{
			get
			{
				return this.project_Task_ReferenceField;
			}
			set
			{
				this.project_Task_ReferenceField = value;
				this.RaisePropertyChanged("Project_Task_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Date
		{
			get
			{
				return this.dateField;
			}
			set
			{
				this.dateField = value;
				this.RaisePropertyChanged("Date");
			}
		}

		[XmlIgnore]
		public bool DateSpecified
		{
			get
			{
				return this.dateFieldSpecified;
			}
			set
			{
				this.dateFieldSpecified = value;
				this.RaisePropertyChanged("DateSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Quantity
		{
			get
			{
				return this.quantityField;
			}
			set
			{
				this.quantityField = value;
				this.RaisePropertyChanged("Quantity");
			}
		}

		[XmlIgnore]
		public bool QuantitySpecified
		{
			get
			{
				return this.quantityFieldSpecified;
			}
			set
			{
				this.quantityFieldSpecified = value;
				this.RaisePropertyChanged("QuantitySpecified");
			}
		}

		[XmlElement(Order = 6)]
		public DateTime In_Date_Time
		{
			get
			{
				return this.in_Date_TimeField;
			}
			set
			{
				this.in_Date_TimeField = value;
				this.RaisePropertyChanged("In_Date_Time");
			}
		}

		[XmlIgnore]
		public bool In_Date_TimeSpecified
		{
			get
			{
				return this.in_Date_TimeFieldSpecified;
			}
			set
			{
				this.in_Date_TimeFieldSpecified = value;
				this.RaisePropertyChanged("In_Date_TimeSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public DateTime Out_Date_Time
		{
			get
			{
				return this.out_Date_TimeField;
			}
			set
			{
				this.out_Date_TimeField = value;
				this.RaisePropertyChanged("Out_Date_Time");
			}
		}

		[XmlIgnore]
		public bool Out_Date_TimeSpecified
		{
			get
			{
				return this.out_Date_TimeFieldSpecified;
			}
			set
			{
				this.out_Date_TimeFieldSpecified = value;
				this.RaisePropertyChanged("Out_Date_TimeSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public Time_Punch_TypeObjectType Out_Reason_Reference
		{
			get
			{
				return this.out_Reason_ReferenceField;
			}
			set
			{
				this.out_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Out_Reason_Reference");
			}
		}

		[XmlElement("Position_Reference", Order = 9)]
		public Position_ElementObjectType[] Position_Reference
		{
			get
			{
				return this.position_ReferenceField;
			}
			set
			{
				this.position_ReferenceField = value;
				this.RaisePropertyChanged("Position_Reference");
			}
		}

		[XmlElement(Order = 10)]
		public decimal Override_Rate
		{
			get
			{
				return this.override_RateField;
			}
			set
			{
				this.override_RateField = value;
				this.RaisePropertyChanged("Override_Rate");
			}
		}

		[XmlIgnore]
		public bool Override_RateSpecified
		{
			get
			{
				return this.override_RateFieldSpecified;
			}
			set
			{
				this.override_RateFieldSpecified = value;
				this.RaisePropertyChanged("Override_RateSpecified");
			}
		}

		[XmlElement(Order = 11)]
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

		[XmlElement(Order = 12)]
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

		[XmlElement(Order = 13)]
		public Custom_OrganizationObjectType Custom_Organization_01_Reference
		{
			get
			{
				return this.custom_Organization_01_ReferenceField;
			}
			set
			{
				this.custom_Organization_01_ReferenceField = value;
				this.RaisePropertyChanged("Custom_Organization_01_Reference");
			}
		}

		[XmlElement(Order = 14)]
		public Custom_OrganizationObjectType Custom_Organization_02_Reference
		{
			get
			{
				return this.custom_Organization_02_ReferenceField;
			}
			set
			{
				this.custom_Organization_02_ReferenceField = value;
				this.RaisePropertyChanged("Custom_Organization_02_Reference");
			}
		}

		[XmlElement(Order = 15)]
		public Custom_OrganizationObjectType Custom_Organization_03_Reference
		{
			get
			{
				return this.custom_Organization_03_ReferenceField;
			}
			set
			{
				this.custom_Organization_03_ReferenceField = value;
				this.RaisePropertyChanged("Custom_Organization_03_Reference");
			}
		}

		[XmlElement(Order = 16)]
		public Custom_OrganizationObjectType Custom_Organization_04_Reference
		{
			get
			{
				return this.custom_Organization_04_ReferenceField;
			}
			set
			{
				this.custom_Organization_04_ReferenceField = value;
				this.RaisePropertyChanged("Custom_Organization_04_Reference");
			}
		}

		[XmlElement(Order = 17)]
		public Custom_OrganizationObjectType Custom_Organization_05_Reference
		{
			get
			{
				return this.custom_Organization_05_ReferenceField;
			}
			set
			{
				this.custom_Organization_05_ReferenceField = value;
				this.RaisePropertyChanged("Custom_Organization_05_Reference");
			}
		}

		[XmlElement(Order = 18)]
		public Custom_OrganizationObjectType Custom_Organization_06_Reference
		{
			get
			{
				return this.custom_Organization_06_ReferenceField;
			}
			set
			{
				this.custom_Organization_06_ReferenceField = value;
				this.RaisePropertyChanged("Custom_Organization_06_Reference");
			}
		}

		[XmlElement(Order = 19)]
		public Custom_OrganizationObjectType Custom_Organization_07_Reference
		{
			get
			{
				return this.custom_Organization_07_ReferenceField;
			}
			set
			{
				this.custom_Organization_07_ReferenceField = value;
				this.RaisePropertyChanged("Custom_Organization_07_Reference");
			}
		}

		[XmlElement(Order = 20)]
		public Custom_OrganizationObjectType Custom_Organization_08_Reference
		{
			get
			{
				return this.custom_Organization_08_ReferenceField;
			}
			set
			{
				this.custom_Organization_08_ReferenceField = value;
				this.RaisePropertyChanged("Custom_Organization_08_Reference");
			}
		}

		[XmlElement(Order = 21)]
		public Custom_OrganizationObjectType Custom_Organization_09_Reference
		{
			get
			{
				return this.custom_Organization_09_ReferenceField;
			}
			set
			{
				this.custom_Organization_09_ReferenceField = value;
				this.RaisePropertyChanged("Custom_Organization_09_Reference");
			}
		}

		[XmlElement(Order = 22)]
		public Custom_OrganizationObjectType Custom_Organization_10_Reference
		{
			get
			{
				return this.custom_Organization_10_ReferenceField;
			}
			set
			{
				this.custom_Organization_10_ReferenceField = value;
				this.RaisePropertyChanged("Custom_Organization_10_Reference");
			}
		}

		[XmlElement(Order = 23)]
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

		[XmlElement(Order = 24)]
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

		[XmlElement(Order = 25)]
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

		[XmlElement(Order = 26)]
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

		[XmlElement(Order = 27)]
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

		[XmlElement(Order = 28)]
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

		[XmlElement(Order = 29)]
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

		[XmlElement(Order = 30)]
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

		[XmlElement(Order = 31)]
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

		[XmlElement(Order = 32)]
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

		[XmlElement(Order = 33)]
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

		[XmlElement(Order = 34)]
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

		[XmlElement(Order = 35)]
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

		[XmlElement(Order = 36)]
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

		[XmlElement(Order = 37)]
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

		[XmlElement(Order = 38)]
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

		[XmlElement(Order = 39)]
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

		[XmlElement(Order = 40)]
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

		[XmlElement(Order = 41)]
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

		[XmlElement(Order = 42)]
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

		[XmlElement(Order = 43)]
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

		[XmlElement(Order = 44)]
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

		[XmlElement(Order = 45)]
		public string Comment
		{
			get
			{
				return this.commentField;
			}
			set
			{
				this.commentField = value;
				this.RaisePropertyChanged("Comment");
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
