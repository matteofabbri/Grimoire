using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Asset_Impairment_WWS_DataType : INotifyPropertyChanged
	{
		private DateTime transaction_Effective_DateField;

		private bool transaction_Effective_DateFieldSpecified;

		private decimal current_Fair_Market_ValueField;

		private bool current_Fair_Market_ValueFieldSpecified;

		private decimal revised_Fair_Market_ValueField;

		private bool revised_Fair_Market_ValueFieldSpecified;

		private decimal impairment_AmountField;

		private bool impairment_AmountFieldSpecified;

		private Asset_Impairment_ReasonObjectType impairment_Reason_ReferenceField;

		private string commentField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Transaction_Effective_Date
		{
			get
			{
				return this.transaction_Effective_DateField;
			}
			set
			{
				this.transaction_Effective_DateField = value;
				this.RaisePropertyChanged("Transaction_Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Transaction_Effective_DateSpecified
		{
			get
			{
				return this.transaction_Effective_DateFieldSpecified;
			}
			set
			{
				this.transaction_Effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Transaction_Effective_DateSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Current_Fair_Market_Value
		{
			get
			{
				return this.current_Fair_Market_ValueField;
			}
			set
			{
				this.current_Fair_Market_ValueField = value;
				this.RaisePropertyChanged("Current_Fair_Market_Value");
			}
		}

		[XmlIgnore]
		public bool Current_Fair_Market_ValueSpecified
		{
			get
			{
				return this.current_Fair_Market_ValueFieldSpecified;
			}
			set
			{
				this.current_Fair_Market_ValueFieldSpecified = value;
				this.RaisePropertyChanged("Current_Fair_Market_ValueSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Revised_Fair_Market_Value
		{
			get
			{
				return this.revised_Fair_Market_ValueField;
			}
			set
			{
				this.revised_Fair_Market_ValueField = value;
				this.RaisePropertyChanged("Revised_Fair_Market_Value");
			}
		}

		[XmlIgnore]
		public bool Revised_Fair_Market_ValueSpecified
		{
			get
			{
				return this.revised_Fair_Market_ValueFieldSpecified;
			}
			set
			{
				this.revised_Fair_Market_ValueFieldSpecified = value;
				this.RaisePropertyChanged("Revised_Fair_Market_ValueSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Impairment_Amount
		{
			get
			{
				return this.impairment_AmountField;
			}
			set
			{
				this.impairment_AmountField = value;
				this.RaisePropertyChanged("Impairment_Amount");
			}
		}

		[XmlIgnore]
		public bool Impairment_AmountSpecified
		{
			get
			{
				return this.impairment_AmountFieldSpecified;
			}
			set
			{
				this.impairment_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Impairment_AmountSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public Asset_Impairment_ReasonObjectType Impairment_Reason_Reference
		{
			get
			{
				return this.impairment_Reason_ReferenceField;
			}
			set
			{
				this.impairment_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Impairment_Reason_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public string Comment
		{
			get
			{
				return this.commentField;
			}
			set
			{
				this.commentField = value;
				this.RaisePropertyChanged("Comment");
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
