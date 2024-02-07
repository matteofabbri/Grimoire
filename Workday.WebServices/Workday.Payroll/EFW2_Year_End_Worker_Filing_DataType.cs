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
	public class EFW2_Year_End_Worker_Filing_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType worker_ReferenceField;

		private string sSNField;

		private string employee_First_NameField;

		private string employee_Middle_InitialField;

		private string employee_Last_NameField;

		private string suffixField;

		private string address_Line_1Field;

		private string address_Line_2Field;

		private string cityField;

		private string stateField;

		private string postal_CodeField;

		private string country_NameField;

		private EFW2_Year_End_Worker_Box_DataType[] eFW2_Year_End_Worker_Box_DataField;

		private EFW2_Deferred_and_Other_Compensation_DataType[] eFW2_Deferred_and_Other_Compensation_DataField;

		private EFW2_Additional_DataType[] eFW2_Additional_DataField;

		private EFW2_Other_DataType[] eFW2_Other_DataField;

		private EFW2_Year_End_Worker_State_DataType[] eFW2_Year_End_Worker_State_DataField;

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

		[XmlElement(Order = 2)]
		public string Employee_First_Name
		{
			get
			{
				return this.employee_First_NameField;
			}
			set
			{
				this.employee_First_NameField = value;
				this.RaisePropertyChanged("Employee_First_Name");
			}
		}

		[XmlElement(Order = 3)]
		public string Employee_Middle_Initial
		{
			get
			{
				return this.employee_Middle_InitialField;
			}
			set
			{
				this.employee_Middle_InitialField = value;
				this.RaisePropertyChanged("Employee_Middle_Initial");
			}
		}

		[XmlElement(Order = 4)]
		public string Employee_Last_Name
		{
			get
			{
				return this.employee_Last_NameField;
			}
			set
			{
				this.employee_Last_NameField = value;
				this.RaisePropertyChanged("Employee_Last_Name");
			}
		}

		[XmlElement(Order = 5)]
		public string Suffix
		{
			get
			{
				return this.suffixField;
			}
			set
			{
				this.suffixField = value;
				this.RaisePropertyChanged("Suffix");
			}
		}

		[XmlElement(Order = 6)]
		public string Address_Line_1
		{
			get
			{
				return this.address_Line_1Field;
			}
			set
			{
				this.address_Line_1Field = value;
				this.RaisePropertyChanged("Address_Line_1");
			}
		}

		[XmlElement(Order = 7)]
		public string Address_Line_2
		{
			get
			{
				return this.address_Line_2Field;
			}
			set
			{
				this.address_Line_2Field = value;
				this.RaisePropertyChanged("Address_Line_2");
			}
		}

		[XmlElement(Order = 8)]
		public string City
		{
			get
			{
				return this.cityField;
			}
			set
			{
				this.cityField = value;
				this.RaisePropertyChanged("City");
			}
		}

		[XmlElement(Order = 9)]
		public string State
		{
			get
			{
				return this.stateField;
			}
			set
			{
				this.stateField = value;
				this.RaisePropertyChanged("State");
			}
		}

		[XmlElement(Order = 10)]
		public string Postal_Code
		{
			get
			{
				return this.postal_CodeField;
			}
			set
			{
				this.postal_CodeField = value;
				this.RaisePropertyChanged("Postal_Code");
			}
		}

		[XmlElement(Order = 11)]
		public string Country_Name
		{
			get
			{
				return this.country_NameField;
			}
			set
			{
				this.country_NameField = value;
				this.RaisePropertyChanged("Country_Name");
			}
		}

		[XmlElement("EFW2_Year_End_Worker_Box_Data", Order = 12)]
		public EFW2_Year_End_Worker_Box_DataType[] EFW2_Year_End_Worker_Box_Data
		{
			get
			{
				return this.eFW2_Year_End_Worker_Box_DataField;
			}
			set
			{
				this.eFW2_Year_End_Worker_Box_DataField = value;
				this.RaisePropertyChanged("EFW2_Year_End_Worker_Box_Data");
			}
		}

		[XmlElement("EFW2_Deferred_and_Other_Compensation_Data", Order = 13)]
		public EFW2_Deferred_and_Other_Compensation_DataType[] EFW2_Deferred_and_Other_Compensation_Data
		{
			get
			{
				return this.eFW2_Deferred_and_Other_Compensation_DataField;
			}
			set
			{
				this.eFW2_Deferred_and_Other_Compensation_DataField = value;
				this.RaisePropertyChanged("EFW2_Deferred_and_Other_Compensation_Data");
			}
		}

		[XmlElement("EFW2_Additional_Data", Order = 14)]
		public EFW2_Additional_DataType[] EFW2_Additional_Data
		{
			get
			{
				return this.eFW2_Additional_DataField;
			}
			set
			{
				this.eFW2_Additional_DataField = value;
				this.RaisePropertyChanged("EFW2_Additional_Data");
			}
		}

		[XmlElement("EFW2_Other_Data", Order = 15)]
		public EFW2_Other_DataType[] EFW2_Other_Data
		{
			get
			{
				return this.eFW2_Other_DataField;
			}
			set
			{
				this.eFW2_Other_DataField = value;
				this.RaisePropertyChanged("EFW2_Other_Data");
			}
		}

		[XmlElement("EFW2_Year_End_Worker_State_Data", Order = 16)]
		public EFW2_Year_End_Worker_State_DataType[] EFW2_Year_End_Worker_State_Data
		{
			get
			{
				return this.eFW2_Year_End_Worker_State_DataField;
			}
			set
			{
				this.eFW2_Year_End_Worker_State_DataField = value;
				this.RaisePropertyChanged("EFW2_Year_End_Worker_State_Data");
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
