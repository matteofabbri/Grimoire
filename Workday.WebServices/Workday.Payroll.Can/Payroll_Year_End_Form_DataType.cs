using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Can
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payroll_Year_End_Form_DataType : INotifyPropertyChanged
	{
		private string employee_IDField;

		private Payroll_Year_End_Worker_Address_DataType[] worker_Address_DataField;

		private string employer_NameField;

		private Employer_Address_DataType[] employer_Address_DataField;

		private Payroll_Year_End_Form_Employer_Contact_InfoType[] employer_Contact_InfoField;

		private string company_Business_NumberField;

		private Payroll_Year_End_CRF_InfoType[] box_InfoField;

		private Payroll_Year_End_Detail_InfoType[] other_InformationField;

		private string rPP_or_DPSP_Registration_NumberField;

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

		[XmlElement("Worker_Address_Data", Order = 1)]
		public Payroll_Year_End_Worker_Address_DataType[] Worker_Address_Data
		{
			get
			{
				return this.worker_Address_DataField;
			}
			set
			{
				this.worker_Address_DataField = value;
				this.RaisePropertyChanged("Worker_Address_Data");
			}
		}

		[XmlElement(Order = 2)]
		public string Employer_Name
		{
			get
			{
				return this.employer_NameField;
			}
			set
			{
				this.employer_NameField = value;
				this.RaisePropertyChanged("Employer_Name");
			}
		}

		[XmlElement("Employer_Address_Data", Order = 3)]
		public Employer_Address_DataType[] Employer_Address_Data
		{
			get
			{
				return this.employer_Address_DataField;
			}
			set
			{
				this.employer_Address_DataField = value;
				this.RaisePropertyChanged("Employer_Address_Data");
			}
		}

		[XmlElement("Employer_Contact_Info", Order = 4)]
		public Payroll_Year_End_Form_Employer_Contact_InfoType[] Employer_Contact_Info
		{
			get
			{
				return this.employer_Contact_InfoField;
			}
			set
			{
				this.employer_Contact_InfoField = value;
				this.RaisePropertyChanged("Employer_Contact_Info");
			}
		}

		[XmlElement(Order = 5)]
		public string Company_Business_Number
		{
			get
			{
				return this.company_Business_NumberField;
			}
			set
			{
				this.company_Business_NumberField = value;
				this.RaisePropertyChanged("Company_Business_Number");
			}
		}

		[XmlElement("Box_Info", Order = 6)]
		public Payroll_Year_End_CRF_InfoType[] Box_Info
		{
			get
			{
				return this.box_InfoField;
			}
			set
			{
				this.box_InfoField = value;
				this.RaisePropertyChanged("Box_Info");
			}
		}

		[XmlArray(Order = 7), XmlArrayItem("Box_Info", typeof(Payroll_Year_End_Detail_InfoType), IsNullable = false)]
		public Payroll_Year_End_Detail_InfoType[] Other_Information
		{
			get
			{
				return this.other_InformationField;
			}
			set
			{
				this.other_InformationField = value;
				this.RaisePropertyChanged("Other_Information");
			}
		}

		[XmlElement(Order = 8)]
		public string RPP_or_DPSP_Registration_Number
		{
			get
			{
				return this.rPP_or_DPSP_Registration_NumberField;
			}
			set
			{
				this.rPP_or_DPSP_Registration_NumberField = value;
				this.RaisePropertyChanged("RPP_or_DPSP_Registration_Number");
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
