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
	public class Result_Worktag_Overrides_DataType : INotifyPropertyChanged
	{
		private CompanyObjectType company_ReferenceField;

		private RegionObjectType region_ReferenceField;

		private LocationObjectType location_ReferenceField;

		private Cost_CenterObjectType cost_Center_ReferenceField;

		private Job_ProfileObjectType job_Profile_ReferenceField;

		private Payroll_State_AuthorityObjectType state__Work__ReferenceField;

		private Payroll_State_AuthorityObjectType state__Resident__ReferenceField;

		private Payroll_Local_County_AuthorityObjectType county__Work__ReferenceField;

		private Payroll_Local_County_AuthorityObjectType county__Resident__ReferenceField;

		private Payroll_Local_City_AuthorityObjectType city__Work__ReferenceField;

		private Payroll_Local_City_AuthorityObjectType city__Resident__ReferenceField;

		private Payroll_Local_School_District_AuthorityObjectType school_District__Resident__ReferenceField;

		private Payroll_Reference_NumberObjectType payroll_Reference_Number_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public CompanyObjectType Company_Reference
		{
			get
			{
				return this.company_ReferenceField;
			}
			set
			{
				this.company_ReferenceField = value;
				this.RaisePropertyChanged("Company_Reference");
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

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
		public Payroll_State_AuthorityObjectType State__Work__Reference
		{
			get
			{
				return this.state__Work__ReferenceField;
			}
			set
			{
				this.state__Work__ReferenceField = value;
				this.RaisePropertyChanged("State__Work__Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Payroll_State_AuthorityObjectType State__Resident__Reference
		{
			get
			{
				return this.state__Resident__ReferenceField;
			}
			set
			{
				this.state__Resident__ReferenceField = value;
				this.RaisePropertyChanged("State__Resident__Reference");
			}
		}

		[XmlElement(Order = 7)]
		public Payroll_Local_County_AuthorityObjectType County__Work__Reference
		{
			get
			{
				return this.county__Work__ReferenceField;
			}
			set
			{
				this.county__Work__ReferenceField = value;
				this.RaisePropertyChanged("County__Work__Reference");
			}
		}

		[XmlElement(Order = 8)]
		public Payroll_Local_County_AuthorityObjectType County__Resident__Reference
		{
			get
			{
				return this.county__Resident__ReferenceField;
			}
			set
			{
				this.county__Resident__ReferenceField = value;
				this.RaisePropertyChanged("County__Resident__Reference");
			}
		}

		[XmlElement(Order = 9)]
		public Payroll_Local_City_AuthorityObjectType City__Work__Reference
		{
			get
			{
				return this.city__Work__ReferenceField;
			}
			set
			{
				this.city__Work__ReferenceField = value;
				this.RaisePropertyChanged("City__Work__Reference");
			}
		}

		[XmlElement(Order = 10)]
		public Payroll_Local_City_AuthorityObjectType City__Resident__Reference
		{
			get
			{
				return this.city__Resident__ReferenceField;
			}
			set
			{
				this.city__Resident__ReferenceField = value;
				this.RaisePropertyChanged("City__Resident__Reference");
			}
		}

		[XmlElement(Order = 11)]
		public Payroll_Local_School_District_AuthorityObjectType School_District__Resident__Reference
		{
			get
			{
				return this.school_District__Resident__ReferenceField;
			}
			set
			{
				this.school_District__Resident__ReferenceField = value;
				this.RaisePropertyChanged("School_District__Resident__Reference");
			}
		}

		[XmlElement(Order = 12)]
		public Payroll_Reference_NumberObjectType Payroll_Reference_Number_Reference
		{
			get
			{
				return this.payroll_Reference_Number_ReferenceField;
			}
			set
			{
				this.payroll_Reference_Number_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Reference_Number_Reference");
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
