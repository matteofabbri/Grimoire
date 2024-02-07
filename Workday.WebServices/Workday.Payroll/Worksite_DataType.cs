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
	public class Worksite_DataType : INotifyPropertyChanged
	{
		private LocationObjectType worksite_ReferenceField;

		private string trade_NameField;

		private string worksite_Street_AddressField;

		private string worksite_CityField;

		private string worksite_StateField;

		private string worksite_Zip_CodeField;

		private string worksite_Expanded_Zip_CodeField;

		private string worksite_Identification_CodeField;

		private string worksite_DescriptionField;

		private decimal employees_Active_Month_1_Day_12Field;

		private bool employees_Active_Month_1_Day_12FieldSpecified;

		private decimal employees_Active_Month_2_Day_12Field;

		private bool employees_Active_Month_2_Day_12FieldSpecified;

		private decimal employees_Active_Month_3_Day_12Field;

		private bool employees_Active_Month_3_Day_12FieldSpecified;

		private decimal wagesField;

		private bool wagesFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public LocationObjectType Worksite_Reference
		{
			get
			{
				return this.worksite_ReferenceField;
			}
			set
			{
				this.worksite_ReferenceField = value;
				this.RaisePropertyChanged("Worksite_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Trade_Name
		{
			get
			{
				return this.trade_NameField;
			}
			set
			{
				this.trade_NameField = value;
				this.RaisePropertyChanged("Trade_Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Worksite_Street_Address
		{
			get
			{
				return this.worksite_Street_AddressField;
			}
			set
			{
				this.worksite_Street_AddressField = value;
				this.RaisePropertyChanged("Worksite_Street_Address");
			}
		}

		[XmlElement(Order = 3)]
		public string Worksite_City
		{
			get
			{
				return this.worksite_CityField;
			}
			set
			{
				this.worksite_CityField = value;
				this.RaisePropertyChanged("Worksite_City");
			}
		}

		[XmlElement(Order = 4)]
		public string Worksite_State
		{
			get
			{
				return this.worksite_StateField;
			}
			set
			{
				this.worksite_StateField = value;
				this.RaisePropertyChanged("Worksite_State");
			}
		}

		[XmlElement(Order = 5)]
		public string Worksite_Zip_Code
		{
			get
			{
				return this.worksite_Zip_CodeField;
			}
			set
			{
				this.worksite_Zip_CodeField = value;
				this.RaisePropertyChanged("Worksite_Zip_Code");
			}
		}

		[XmlElement(Order = 6)]
		public string Worksite_Expanded_Zip_Code
		{
			get
			{
				return this.worksite_Expanded_Zip_CodeField;
			}
			set
			{
				this.worksite_Expanded_Zip_CodeField = value;
				this.RaisePropertyChanged("Worksite_Expanded_Zip_Code");
			}
		}

		[XmlElement(Order = 7)]
		public string Worksite_Identification_Code
		{
			get
			{
				return this.worksite_Identification_CodeField;
			}
			set
			{
				this.worksite_Identification_CodeField = value;
				this.RaisePropertyChanged("Worksite_Identification_Code");
			}
		}

		[XmlElement(Order = 8)]
		public string Worksite_Description
		{
			get
			{
				return this.worksite_DescriptionField;
			}
			set
			{
				this.worksite_DescriptionField = value;
				this.RaisePropertyChanged("Worksite_Description");
			}
		}

		[XmlElement(Order = 9)]
		public decimal Employees_Active_Month_1_Day_12
		{
			get
			{
				return this.employees_Active_Month_1_Day_12Field;
			}
			set
			{
				this.employees_Active_Month_1_Day_12Field = value;
				this.RaisePropertyChanged("Employees_Active_Month_1_Day_12");
			}
		}

		[XmlIgnore]
		public bool Employees_Active_Month_1_Day_12Specified
		{
			get
			{
				return this.employees_Active_Month_1_Day_12FieldSpecified;
			}
			set
			{
				this.employees_Active_Month_1_Day_12FieldSpecified = value;
				this.RaisePropertyChanged("Employees_Active_Month_1_Day_12Specified");
			}
		}

		[XmlElement(Order = 10)]
		public decimal Employees_Active_Month_2_Day_12
		{
			get
			{
				return this.employees_Active_Month_2_Day_12Field;
			}
			set
			{
				this.employees_Active_Month_2_Day_12Field = value;
				this.RaisePropertyChanged("Employees_Active_Month_2_Day_12");
			}
		}

		[XmlIgnore]
		public bool Employees_Active_Month_2_Day_12Specified
		{
			get
			{
				return this.employees_Active_Month_2_Day_12FieldSpecified;
			}
			set
			{
				this.employees_Active_Month_2_Day_12FieldSpecified = value;
				this.RaisePropertyChanged("Employees_Active_Month_2_Day_12Specified");
			}
		}

		[XmlElement(Order = 11)]
		public decimal Employees_Active_Month_3_Day_12
		{
			get
			{
				return this.employees_Active_Month_3_Day_12Field;
			}
			set
			{
				this.employees_Active_Month_3_Day_12Field = value;
				this.RaisePropertyChanged("Employees_Active_Month_3_Day_12");
			}
		}

		[XmlIgnore]
		public bool Employees_Active_Month_3_Day_12Specified
		{
			get
			{
				return this.employees_Active_Month_3_Day_12FieldSpecified;
			}
			set
			{
				this.employees_Active_Month_3_Day_12FieldSpecified = value;
				this.RaisePropertyChanged("Employees_Active_Month_3_Day_12Specified");
			}
		}

		[XmlElement(Order = 12)]
		public decimal Wages
		{
			get
			{
				return this.wagesField;
			}
			set
			{
				this.wagesField = value;
				this.RaisePropertyChanged("Wages");
			}
		}

		[XmlIgnore]
		public bool WagesSpecified
		{
			get
			{
				return this.wagesFieldSpecified;
			}
			set
			{
				this.wagesFieldSpecified = value;
				this.RaisePropertyChanged("WagesSpecified");
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
