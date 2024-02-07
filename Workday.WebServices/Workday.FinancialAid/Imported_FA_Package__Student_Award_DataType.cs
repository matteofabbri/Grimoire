using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialAid
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Imported_FA_Package_-_Student_Award_DataType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Imported_FA_Package__Student_Award_DataType : INotifyPropertyChanged
	{
		private string idField;

		private decimal student_Award_Sequence_NumberField;

		private bool student_Award_Sequence_NumberFieldSpecified;

		private Student_Award_ItemObjectType student_Award_Item_ReferenceField;

		private Student_Award_StatusObjectType student_Award_Status_ReferenceField;

		private decimal award_AmountField;

		private bool award_AmountFieldSpecified;

		private decimal disbursed_AmountField;

		private bool disbursed_AmountFieldSpecified;

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
		public decimal Student_Award_Sequence_Number
		{
			get
			{
				return this.student_Award_Sequence_NumberField;
			}
			set
			{
				this.student_Award_Sequence_NumberField = value;
				this.RaisePropertyChanged("Student_Award_Sequence_Number");
			}
		}

		[XmlIgnore]
		public bool Student_Award_Sequence_NumberSpecified
		{
			get
			{
				return this.student_Award_Sequence_NumberFieldSpecified;
			}
			set
			{
				this.student_Award_Sequence_NumberFieldSpecified = value;
				this.RaisePropertyChanged("Student_Award_Sequence_NumberSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public Student_Award_ItemObjectType Student_Award_Item_Reference
		{
			get
			{
				return this.student_Award_Item_ReferenceField;
			}
			set
			{
				this.student_Award_Item_ReferenceField = value;
				this.RaisePropertyChanged("Student_Award_Item_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Student_Award_StatusObjectType Student_Award_Status_Reference
		{
			get
			{
				return this.student_Award_Status_ReferenceField;
			}
			set
			{
				this.student_Award_Status_ReferenceField = value;
				this.RaisePropertyChanged("Student_Award_Status_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Award_Amount
		{
			get
			{
				return this.award_AmountField;
			}
			set
			{
				this.award_AmountField = value;
				this.RaisePropertyChanged("Award_Amount");
			}
		}

		[XmlIgnore]
		public bool Award_AmountSpecified
		{
			get
			{
				return this.award_AmountFieldSpecified;
			}
			set
			{
				this.award_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Award_AmountSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Disbursed_Amount
		{
			get
			{
				return this.disbursed_AmountField;
			}
			set
			{
				this.disbursed_AmountField = value;
				this.RaisePropertyChanged("Disbursed_Amount");
			}
		}

		[XmlIgnore]
		public bool Disbursed_AmountSpecified
		{
			get
			{
				return this.disbursed_AmountFieldSpecified;
			}
			set
			{
				this.disbursed_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Disbursed_AmountSpecified");
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
