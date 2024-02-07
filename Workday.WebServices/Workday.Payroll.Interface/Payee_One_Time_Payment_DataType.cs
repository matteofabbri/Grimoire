using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payee_One_Time_Payment_DataType : INotifyPropertyChanged
	{
		private Amount_DataType[] amountField;

		private DateTime dateField;

		private bool dateFieldSpecified;

		private Costing_Worktag_DataType[] costing_Worktag_DataField;

		private Unique_IdentifierObjectType one_Time_Payment_ReferenceField;

		private General_Event_SubcategoryObjectType reason_ReferenceField;

		private Payee_One_Time_Payment_Rescind_and_Correct_DataType one_Time_Payment_Rescind_and_Correct_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Amount", Order = 0)]
		public Amount_DataType[] Amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
				this.RaisePropertyChanged("Amount");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
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

		[XmlElement("Costing_Worktag_Data", Order = 2)]
		public Costing_Worktag_DataType[] Costing_Worktag_Data
		{
			get
			{
				return this.costing_Worktag_DataField;
			}
			set
			{
				this.costing_Worktag_DataField = value;
				this.RaisePropertyChanged("Costing_Worktag_Data");
			}
		}

		[XmlElement(Order = 3)]
		public Unique_IdentifierObjectType One_Time_Payment_Reference
		{
			get
			{
				return this.one_Time_Payment_ReferenceField;
			}
			set
			{
				this.one_Time_Payment_ReferenceField = value;
				this.RaisePropertyChanged("One_Time_Payment_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public General_Event_SubcategoryObjectType Reason_Reference
		{
			get
			{
				return this.reason_ReferenceField;
			}
			set
			{
				this.reason_ReferenceField = value;
				this.RaisePropertyChanged("Reason_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Payee_One_Time_Payment_Rescind_and_Correct_DataType One_Time_Payment_Rescind_and_Correct_Data
		{
			get
			{
				return this.one_Time_Payment_Rescind_and_Correct_DataField;
			}
			set
			{
				this.one_Time_Payment_Rescind_and_Correct_DataField = value;
				this.RaisePropertyChanged("One_Time_Payment_Rescind_and_Correct_Data");
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
