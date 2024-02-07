using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialAid
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Financial_Aid_Package_DataType : INotifyPropertyChanged
	{
		private string idField;

		private DateTime financial_Aid_Package_DateField;

		private StudentObjectType student_ReferenceField;

		private Academic_YearObjectType academic_Year_ReferenceField;

		private Financial_Aid_Award_YearObjectType financial_Aid_Award_Year_ReferenceField;

		private Academic_PeriodObjectType academic_Period_ReferenceField;

		private Package_Result_StatusObjectType package_Result_Status_ReferenceField;

		private Imported_FA_Package__Student_Award_DataType[] student_Award_DataField;

		private Imported_FA_Package__Student_Waiver_DataType[] student_Waiver_DataField;

		private Imported_FA_Package__Student_Sponsor_Contract_DataType[] student_Sponsor_Contract_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 1)]
		public DateTime Financial_Aid_Package_Date
		{
			get
			{
				return this.financial_Aid_Package_DateField;
			}
			set
			{
				this.financial_Aid_Package_DateField = value;
				this.RaisePropertyChanged("Financial_Aid_Package_Date");
			}
		}

		[XmlElement(Order = 2)]
		public StudentObjectType Student_Reference
		{
			get
			{
				return this.student_ReferenceField;
			}
			set
			{
				this.student_ReferenceField = value;
				this.RaisePropertyChanged("Student_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Academic_YearObjectType Academic_Year_Reference
		{
			get
			{
				return this.academic_Year_ReferenceField;
			}
			set
			{
				this.academic_Year_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Year_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Financial_Aid_Award_YearObjectType Financial_Aid_Award_Year_Reference
		{
			get
			{
				return this.financial_Aid_Award_Year_ReferenceField;
			}
			set
			{
				this.financial_Aid_Award_Year_ReferenceField = value;
				this.RaisePropertyChanged("Financial_Aid_Award_Year_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Academic_PeriodObjectType Academic_Period_Reference
		{
			get
			{
				return this.academic_Period_ReferenceField;
			}
			set
			{
				this.academic_Period_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Period_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Package_Result_StatusObjectType Package_Result_Status_Reference
		{
			get
			{
				return this.package_Result_Status_ReferenceField;
			}
			set
			{
				this.package_Result_Status_ReferenceField = value;
				this.RaisePropertyChanged("Package_Result_Status_Reference");
			}
		}

		[XmlElement("Student_Award_Data", Order = 7)]
		public Imported_FA_Package__Student_Award_DataType[] Student_Award_Data
		{
			get
			{
				return this.student_Award_DataField;
			}
			set
			{
				this.student_Award_DataField = value;
				this.RaisePropertyChanged("Student_Award_Data");
			}
		}

		[XmlElement("Student_Waiver_Data", Order = 8)]
		public Imported_FA_Package__Student_Waiver_DataType[] Student_Waiver_Data
		{
			get
			{
				return this.student_Waiver_DataField;
			}
			set
			{
				this.student_Waiver_DataField = value;
				this.RaisePropertyChanged("Student_Waiver_Data");
			}
		}

		[XmlElement("Student_Sponsor_Contract_Data", Order = 9)]
		public Imported_FA_Package__Student_Sponsor_Contract_DataType[] Student_Sponsor_Contract_Data
		{
			get
			{
				return this.student_Sponsor_Contract_DataField;
			}
			set
			{
				this.student_Sponsor_Contract_DataField = value;
				this.RaisePropertyChanged("Student_Sponsor_Contract_Data");
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
