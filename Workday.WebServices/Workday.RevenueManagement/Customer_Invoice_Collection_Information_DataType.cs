using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Customer_Invoice_Collection_Information_DataType : INotifyPropertyChanged
	{
		private bool on_HoldField;

		private bool on_HoldFieldSpecified;

		private bool is_Excluded_from_Dunning_LetterField;

		private bool is_Excluded_from_Dunning_LetterFieldSpecified;

		private DateTime followup_DateField;

		private bool followup_DateFieldSpecified;

		private Customer_Invoice_Dispute_DataType dispute_DataField;

		private Customer_Invoice_Collection_DataType collection_DataField;

		private Note_WWS_DataType[] note_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool On_Hold
		{
			get
			{
				return this.on_HoldField;
			}
			set
			{
				this.on_HoldField = value;
				this.RaisePropertyChanged("On_Hold");
			}
		}

		[XmlIgnore]
		public bool On_HoldSpecified
		{
			get
			{
				return this.on_HoldFieldSpecified;
			}
			set
			{
				this.on_HoldFieldSpecified = value;
				this.RaisePropertyChanged("On_HoldSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public bool Is_Excluded_from_Dunning_Letter
		{
			get
			{
				return this.is_Excluded_from_Dunning_LetterField;
			}
			set
			{
				this.is_Excluded_from_Dunning_LetterField = value;
				this.RaisePropertyChanged("Is_Excluded_from_Dunning_Letter");
			}
		}

		[XmlIgnore]
		public bool Is_Excluded_from_Dunning_LetterSpecified
		{
			get
			{
				return this.is_Excluded_from_Dunning_LetterFieldSpecified;
			}
			set
			{
				this.is_Excluded_from_Dunning_LetterFieldSpecified = value;
				this.RaisePropertyChanged("Is_Excluded_from_Dunning_LetterSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Followup_Date
		{
			get
			{
				return this.followup_DateField;
			}
			set
			{
				this.followup_DateField = value;
				this.RaisePropertyChanged("Followup_Date");
			}
		}

		[XmlIgnore]
		public bool Followup_DateSpecified
		{
			get
			{
				return this.followup_DateFieldSpecified;
			}
			set
			{
				this.followup_DateFieldSpecified = value;
				this.RaisePropertyChanged("Followup_DateSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public Customer_Invoice_Dispute_DataType Dispute_Data
		{
			get
			{
				return this.dispute_DataField;
			}
			set
			{
				this.dispute_DataField = value;
				this.RaisePropertyChanged("Dispute_Data");
			}
		}

		[XmlElement(Order = 4)]
		public Customer_Invoice_Collection_DataType Collection_Data
		{
			get
			{
				return this.collection_DataField;
			}
			set
			{
				this.collection_DataField = value;
				this.RaisePropertyChanged("Collection_Data");
			}
		}

		[XmlElement("Note_Data", Order = 5)]
		public Note_WWS_DataType[] Note_Data
		{
			get
			{
				return this.note_DataField;
			}
			set
			{
				this.note_DataField = value;
				this.RaisePropertyChanged("Note_Data");
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
