using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.SettlementServices
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payroll_Remittance_Worker_DataType : INotifyPropertyChanged
	{
		private string employee_IDField;

		private string employee_NameField;

		private string preferred_NameField;

		private string legal_NameField;

		private string legal_First_NameField;

		private string legal_Last_NameField;

		private string legal_Middle_NameField;

		private DateTime date_of_BirthField;

		private bool date_of_BirthFieldSpecified;

		private string sSNField;

		private string companyField;

		private string occupationField;

		private string phoneField;

		private LocationObjectType location_ReferenceField;

		private Supervisory_OrganizationObjectType department_Name_ReferenceField;

		private string supervisory_Organization_IDField;

		private RegionObjectType[] region_ReferenceField;

		private string region_IDField;

		private Cost_CenterObjectType[] cost_Center_ReferenceField;

		private string cost_Center_IDField;

		private WorkerObjectType manager_ReferenceField;

		private Address_Information_DataType[] home_Address_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Employee_ID
		{
			get
			{
				return this.employee_IDField;
			}
			set
			{
				this.employee_IDField = value;
				this.RaisePropertyChanged("Employee_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Employee_Name
		{
			get
			{
				return this.employee_NameField;
			}
			set
			{
				this.employee_NameField = value;
				this.RaisePropertyChanged("Employee_Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Preferred_Name
		{
			get
			{
				return this.preferred_NameField;
			}
			set
			{
				this.preferred_NameField = value;
				this.RaisePropertyChanged("Preferred_Name");
			}
		}

		[XmlElement(Order = 3)]
		public string Legal_Name
		{
			get
			{
				return this.legal_NameField;
			}
			set
			{
				this.legal_NameField = value;
				this.RaisePropertyChanged("Legal_Name");
			}
		}

		[XmlElement(Order = 4)]
		public string Legal_First_Name
		{
			get
			{
				return this.legal_First_NameField;
			}
			set
			{
				this.legal_First_NameField = value;
				this.RaisePropertyChanged("Legal_First_Name");
			}
		}

		[XmlElement(Order = 5)]
		public string Legal_Last_Name
		{
			get
			{
				return this.legal_Last_NameField;
			}
			set
			{
				this.legal_Last_NameField = value;
				this.RaisePropertyChanged("Legal_Last_Name");
			}
		}

		[XmlElement(Order = 6)]
		public string Legal_Middle_Name
		{
			get
			{
				return this.legal_Middle_NameField;
			}
			set
			{
				this.legal_Middle_NameField = value;
				this.RaisePropertyChanged("Legal_Middle_Name");
			}
		}

		[XmlElement(DataType = "date", Order = 7)]
		public DateTime Date_of_Birth
		{
			get
			{
				return this.date_of_BirthField;
			}
			set
			{
				this.date_of_BirthField = value;
				this.RaisePropertyChanged("Date_of_Birth");
			}
		}

		[XmlIgnore]
		public bool Date_of_BirthSpecified
		{
			get
			{
				return this.date_of_BirthFieldSpecified;
			}
			set
			{
				this.date_of_BirthFieldSpecified = value;
				this.RaisePropertyChanged("Date_of_BirthSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public string SSN
		{
			get
			{
				return this.sSNField;
			}
			set
			{
				this.sSNField = value;
				this.RaisePropertyChanged("SSN");
			}
		}

		[XmlElement(Order = 9)]
		public string Company
		{
			get
			{
				return this.companyField;
			}
			set
			{
				this.companyField = value;
				this.RaisePropertyChanged("Company");
			}
		}

		[XmlElement(Order = 10)]
		public string Occupation
		{
			get
			{
				return this.occupationField;
			}
			set
			{
				this.occupationField = value;
				this.RaisePropertyChanged("Occupation");
			}
		}

		[XmlElement(Order = 11)]
		public string Phone
		{
			get
			{
				return this.phoneField;
			}
			set
			{
				this.phoneField = value;
				this.RaisePropertyChanged("Phone");
			}
		}

		[XmlElement(Order = 12)]
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

		[XmlElement(Order = 13)]
		public Supervisory_OrganizationObjectType Department_Name_Reference
		{
			get
			{
				return this.department_Name_ReferenceField;
			}
			set
			{
				this.department_Name_ReferenceField = value;
				this.RaisePropertyChanged("Department_Name_Reference");
			}
		}

		[XmlElement(Order = 14)]
		public string Supervisory_Organization_ID
		{
			get
			{
				return this.supervisory_Organization_IDField;
			}
			set
			{
				this.supervisory_Organization_IDField = value;
				this.RaisePropertyChanged("Supervisory_Organization_ID");
			}
		}

		[XmlElement("Region_Reference", Order = 15)]
		public RegionObjectType[] Region_Reference
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

		[XmlElement(Order = 16)]
		public string Region_ID
		{
			get
			{
				return this.region_IDField;
			}
			set
			{
				this.region_IDField = value;
				this.RaisePropertyChanged("Region_ID");
			}
		}

		[XmlElement("Cost_Center_Reference", Order = 17)]
		public Cost_CenterObjectType[] Cost_Center_Reference
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

		[XmlElement(Order = 18)]
		public string Cost_Center_ID
		{
			get
			{
				return this.cost_Center_IDField;
			}
			set
			{
				this.cost_Center_IDField = value;
				this.RaisePropertyChanged("Cost_Center_ID");
			}
		}

		[XmlElement(Order = 19)]
		public WorkerObjectType Manager_Reference
		{
			get
			{
				return this.manager_ReferenceField;
			}
			set
			{
				this.manager_ReferenceField = value;
				this.RaisePropertyChanged("Manager_Reference");
			}
		}

		[XmlElement("Home_Address_Data", Order = 20)]
		public Address_Information_DataType[] Home_Address_Data
		{
			get
			{
				return this.home_Address_DataField;
			}
			set
			{
				this.home_Address_DataField = value;
				this.RaisePropertyChanged("Home_Address_Data");
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
