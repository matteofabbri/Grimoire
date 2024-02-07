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
	public class Transaction_Log_Rescind_And_Correct_Event_DataType : INotifyPropertyChanged
	{
		private Transaction_LogObjectType transaction_Log_ReferenceField;

		private string transaction_Log_DescriptionField;

		private bool is_CorrectionField;

		private bool is_CorrectionFieldSpecified;

		private bool is_RescindField;

		private bool is_RescindFieldSpecified;

		private DateTime prior_Effective_MomentField;

		private bool prior_Effective_MomentFieldSpecified;

		private DateTime transaction_Entry_MomentField;

		private bool transaction_Entry_MomentFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Transaction_LogObjectType Transaction_Log_Reference
		{
			get
			{
				return this.transaction_Log_ReferenceField;
			}
			set
			{
				this.transaction_Log_ReferenceField = value;
				this.RaisePropertyChanged("Transaction_Log_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Transaction_Log_Description
		{
			get
			{
				return this.transaction_Log_DescriptionField;
			}
			set
			{
				this.transaction_Log_DescriptionField = value;
				this.RaisePropertyChanged("Transaction_Log_Description");
			}
		}

		[XmlElement(Order = 2)]
		public bool Is_Correction
		{
			get
			{
				return this.is_CorrectionField;
			}
			set
			{
				this.is_CorrectionField = value;
				this.RaisePropertyChanged("Is_Correction");
			}
		}

		[XmlIgnore]
		public bool Is_CorrectionSpecified
		{
			get
			{
				return this.is_CorrectionFieldSpecified;
			}
			set
			{
				this.is_CorrectionFieldSpecified = value;
				this.RaisePropertyChanged("Is_CorrectionSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Is_Rescind
		{
			get
			{
				return this.is_RescindField;
			}
			set
			{
				this.is_RescindField = value;
				this.RaisePropertyChanged("Is_Rescind");
			}
		}

		[XmlIgnore]
		public bool Is_RescindSpecified
		{
			get
			{
				return this.is_RescindFieldSpecified;
			}
			set
			{
				this.is_RescindFieldSpecified = value;
				this.RaisePropertyChanged("Is_RescindSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Prior_Effective_Moment
		{
			get
			{
				return this.prior_Effective_MomentField;
			}
			set
			{
				this.prior_Effective_MomentField = value;
				this.RaisePropertyChanged("Prior_Effective_Moment");
			}
		}

		[XmlIgnore]
		public bool Prior_Effective_MomentSpecified
		{
			get
			{
				return this.prior_Effective_MomentFieldSpecified;
			}
			set
			{
				this.prior_Effective_MomentFieldSpecified = value;
				this.RaisePropertyChanged("Prior_Effective_MomentSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public DateTime Transaction_Entry_Moment
		{
			get
			{
				return this.transaction_Entry_MomentField;
			}
			set
			{
				this.transaction_Entry_MomentField = value;
				this.RaisePropertyChanged("Transaction_Entry_Moment");
			}
		}

		[XmlIgnore]
		public bool Transaction_Entry_MomentSpecified
		{
			get
			{
				return this.transaction_Entry_MomentFieldSpecified;
			}
			set
			{
				this.transaction_Entry_MomentFieldSpecified = value;
				this.RaisePropertyChanged("Transaction_Entry_MomentSpecified");
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
