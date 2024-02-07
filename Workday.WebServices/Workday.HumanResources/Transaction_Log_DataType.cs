using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Transaction_Log_DataType : INotifyPropertyChanged
	{
		private string transaction_Log_DescriptionField;

		private DateTime transaction_Effective_MomentField;

		private bool transaction_Effective_MomentFieldSpecified;

		private DateTime transaction_Entry_MomentField;

		private bool transaction_Entry_MomentFieldSpecified;

		private Transaction_Log_TypeObjectType[] transaction_Log_Type_ReferenceField;

		private Event_TargetObjectType[] transaction_Target_ReferenceField;

		private bool is_Rescind_Or_RescindedField;

		private bool is_Rescind_Or_RescindedFieldSpecified;

		private bool is_Correction_Or_CorrectedField;

		private bool is_Correction_Or_CorrectedFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
		public DateTime Transaction_Effective_Moment
		{
			get
			{
				return this.transaction_Effective_MomentField;
			}
			set
			{
				this.transaction_Effective_MomentField = value;
				this.RaisePropertyChanged("Transaction_Effective_Moment");
			}
		}

		[XmlIgnore]
		public bool Transaction_Effective_MomentSpecified
		{
			get
			{
				return this.transaction_Effective_MomentFieldSpecified;
			}
			set
			{
				this.transaction_Effective_MomentFieldSpecified = value;
				this.RaisePropertyChanged("Transaction_Effective_MomentSpecified");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement("Transaction_Log_Type_Reference", Order = 3)]
		public Transaction_Log_TypeObjectType[] Transaction_Log_Type_Reference
		{
			get
			{
				return this.transaction_Log_Type_ReferenceField;
			}
			set
			{
				this.transaction_Log_Type_ReferenceField = value;
				this.RaisePropertyChanged("Transaction_Log_Type_Reference");
			}
		}

		[XmlElement("Transaction_Target_Reference", Order = 4)]
		public Event_TargetObjectType[] Transaction_Target_Reference
		{
			get
			{
				return this.transaction_Target_ReferenceField;
			}
			set
			{
				this.transaction_Target_ReferenceField = value;
				this.RaisePropertyChanged("Transaction_Target_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public bool Is_Rescind_Or_Rescinded
		{
			get
			{
				return this.is_Rescind_Or_RescindedField;
			}
			set
			{
				this.is_Rescind_Or_RescindedField = value;
				this.RaisePropertyChanged("Is_Rescind_Or_Rescinded");
			}
		}

		[XmlIgnore]
		public bool Is_Rescind_Or_RescindedSpecified
		{
			get
			{
				return this.is_Rescind_Or_RescindedFieldSpecified;
			}
			set
			{
				this.is_Rescind_Or_RescindedFieldSpecified = value;
				this.RaisePropertyChanged("Is_Rescind_Or_RescindedSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public bool Is_Correction_Or_Corrected
		{
			get
			{
				return this.is_Correction_Or_CorrectedField;
			}
			set
			{
				this.is_Correction_Or_CorrectedField = value;
				this.RaisePropertyChanged("Is_Correction_Or_Corrected");
			}
		}

		[XmlIgnore]
		public bool Is_Correction_Or_CorrectedSpecified
		{
			get
			{
				return this.is_Correction_Or_CorrectedFieldSpecified;
			}
			set
			{
				this.is_Correction_Or_CorrectedFieldSpecified = value;
				this.RaisePropertyChanged("Is_Correction_Or_CorrectedSpecified");
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
