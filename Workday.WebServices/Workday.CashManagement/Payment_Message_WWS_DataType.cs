using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.CashManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payment_Message_WWS_DataType : INotifyPropertyChanged
	{
		private string payment_Message_IDField;

		private DateTime create_DateField;

		private bool create_DateFieldSpecified;

		private decimal create_Date_SequenceField;

		private bool create_Date_SequenceFieldSpecified;

		private Integration_System__Audited_ObjectType integration_System_ReferenceField;

		private decimal payment_CountField;

		private bool payment_CountFieldSpecified;

		private decimal payments_SumField;

		private bool payments_SumFieldSpecified;

		private Payment_Message_Group_WWS_DataType[] payment_Message_Group_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Payment_Message_ID
		{
			get
			{
				return this.payment_Message_IDField;
			}
			set
			{
				this.payment_Message_IDField = value;
				this.RaisePropertyChanged("Payment_Message_ID");
			}
		}

		[XmlElement(Order = 1)]
		public DateTime Create_Date
		{
			get
			{
				return this.create_DateField;
			}
			set
			{
				this.create_DateField = value;
				this.RaisePropertyChanged("Create_Date");
			}
		}

		[XmlIgnore]
		public bool Create_DateSpecified
		{
			get
			{
				return this.create_DateFieldSpecified;
			}
			set
			{
				this.create_DateFieldSpecified = value;
				this.RaisePropertyChanged("Create_DateSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Create_Date_Sequence
		{
			get
			{
				return this.create_Date_SequenceField;
			}
			set
			{
				this.create_Date_SequenceField = value;
				this.RaisePropertyChanged("Create_Date_Sequence");
			}
		}

		[XmlIgnore]
		public bool Create_Date_SequenceSpecified
		{
			get
			{
				return this.create_Date_SequenceFieldSpecified;
			}
			set
			{
				this.create_Date_SequenceFieldSpecified = value;
				this.RaisePropertyChanged("Create_Date_SequenceSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public Integration_System__Audited_ObjectType Integration_System_Reference
		{
			get
			{
				return this.integration_System_ReferenceField;
			}
			set
			{
				this.integration_System_ReferenceField = value;
				this.RaisePropertyChanged("Integration_System_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Payment_Count
		{
			get
			{
				return this.payment_CountField;
			}
			set
			{
				this.payment_CountField = value;
				this.RaisePropertyChanged("Payment_Count");
			}
		}

		[XmlIgnore]
		public bool Payment_CountSpecified
		{
			get
			{
				return this.payment_CountFieldSpecified;
			}
			set
			{
				this.payment_CountFieldSpecified = value;
				this.RaisePropertyChanged("Payment_CountSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Payments_Sum
		{
			get
			{
				return this.payments_SumField;
			}
			set
			{
				this.payments_SumField = value;
				this.RaisePropertyChanged("Payments_Sum");
			}
		}

		[XmlIgnore]
		public bool Payments_SumSpecified
		{
			get
			{
				return this.payments_SumFieldSpecified;
			}
			set
			{
				this.payments_SumFieldSpecified = value;
				this.RaisePropertyChanged("Payments_SumSpecified");
			}
		}

		[XmlElement("Payment_Message_Group_Data", Order = 6)]
		public Payment_Message_Group_WWS_DataType[] Payment_Message_Group_Data
		{
			get
			{
				return this.payment_Message_Group_DataField;
			}
			set
			{
				this.payment_Message_Group_DataField = value;
				this.RaisePropertyChanged("Payment_Message_Group_Data");
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
