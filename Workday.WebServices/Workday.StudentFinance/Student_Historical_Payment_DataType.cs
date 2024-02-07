using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentFinance
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_Historical_Payment_DataType : INotifyPropertyChanged
	{
		private string idField;

		private Student_Financial_AccountObjectType student_Financial_Account_ReferenceField;

		private Student_Payment_ItemObjectType student_Payment_Item_ReferenceField;

		private Academic_PeriodObjectType academic_Period_ReferenceField;

		private DateTime transaction_DateField;

		private decimal total_Payment_AmountField;

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
		public Student_Financial_AccountObjectType Student_Financial_Account_Reference
		{
			get
			{
				return this.student_Financial_Account_ReferenceField;
			}
			set
			{
				this.student_Financial_Account_ReferenceField = value;
				this.RaisePropertyChanged("Student_Financial_Account_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Student_Payment_ItemObjectType Student_Payment_Item_Reference
		{
			get
			{
				return this.student_Payment_Item_ReferenceField;
			}
			set
			{
				this.student_Payment_Item_ReferenceField = value;
				this.RaisePropertyChanged("Student_Payment_Item_Reference");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Transaction_Date
		{
			get
			{
				return this.transaction_DateField;
			}
			set
			{
				this.transaction_DateField = value;
				this.RaisePropertyChanged("Transaction_Date");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Total_Payment_Amount
		{
			get
			{
				return this.total_Payment_AmountField;
			}
			set
			{
				this.total_Payment_AmountField = value;
				this.RaisePropertyChanged("Total_Payment_Amount");
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
