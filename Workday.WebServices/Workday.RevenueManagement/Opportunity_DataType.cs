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
	public class Opportunity_DataType : INotifyPropertyChanged
	{
		private string opportunity_IDField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private string opportunity_NameField;

		private Opportunity_StatusObjectType opportunity_Status_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private object itemField;

		private CompanyObjectType company_ReferenceField;

		private WorkerObjectType salesperson_ReferenceField;

		private decimal probability_PercentField;

		private bool probability_PercentFieldSpecified;

		private DateTime close_DateField;

		private bool close_DateFieldSpecified;

		private string notesField;

		private bool update_Opportunity_OnlyField;

		private bool update_Opportunity_OnlyFieldSpecified;

		private Opportunity_Line_DataType[] opportunity_Line_Replacement_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Opportunity_ID
		{
			get
			{
				return this.opportunity_IDField;
			}
			set
			{
				this.opportunity_IDField = value;
				this.RaisePropertyChanged("Opportunity_ID");
			}
		}

		[XmlElement(Order = 1)]
		public bool Inactive
		{
			get
			{
				return this.inactiveField;
			}
			set
			{
				this.inactiveField = value;
				this.RaisePropertyChanged("Inactive");
			}
		}

		[XmlIgnore]
		public bool InactiveSpecified
		{
			get
			{
				return this.inactiveFieldSpecified;
			}
			set
			{
				this.inactiveFieldSpecified = value;
				this.RaisePropertyChanged("InactiveSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public string Opportunity_Name
		{
			get
			{
				return this.opportunity_NameField;
			}
			set
			{
				this.opportunity_NameField = value;
				this.RaisePropertyChanged("Opportunity_Name");
			}
		}

		[XmlElement(Order = 3)]
		public Opportunity_StatusObjectType Opportunity_Status_Reference
		{
			get
			{
				return this.opportunity_Status_ReferenceField;
			}
			set
			{
				this.opportunity_Status_ReferenceField = value;
				this.RaisePropertyChanged("Opportunity_Status_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public CurrencyObjectType Currency_Reference
		{
			get
			{
				return this.currency_ReferenceField;
			}
			set
			{
				this.currency_ReferenceField = value;
				this.RaisePropertyChanged("Currency_Reference");
			}
		}

		[XmlElement("Customer_Reference", typeof(CustomerObjectType), Order = 5), XmlElement("Customer_Request_Reference", typeof(Customer_RequestObjectType), Order = 5), XmlElement("Prospect_Reference", typeof(ProspectObjectType), Order = 5)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement(Order = 6)]
		public CompanyObjectType Company_Reference
		{
			get
			{
				return this.company_ReferenceField;
			}
			set
			{
				this.company_ReferenceField = value;
				this.RaisePropertyChanged("Company_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public WorkerObjectType Salesperson_Reference
		{
			get
			{
				return this.salesperson_ReferenceField;
			}
			set
			{
				this.salesperson_ReferenceField = value;
				this.RaisePropertyChanged("Salesperson_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Probability_Percent
		{
			get
			{
				return this.probability_PercentField;
			}
			set
			{
				this.probability_PercentField = value;
				this.RaisePropertyChanged("Probability_Percent");
			}
		}

		[XmlIgnore]
		public bool Probability_PercentSpecified
		{
			get
			{
				return this.probability_PercentFieldSpecified;
			}
			set
			{
				this.probability_PercentFieldSpecified = value;
				this.RaisePropertyChanged("Probability_PercentSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 9)]
		public DateTime Close_Date
		{
			get
			{
				return this.close_DateField;
			}
			set
			{
				this.close_DateField = value;
				this.RaisePropertyChanged("Close_Date");
			}
		}

		[XmlIgnore]
		public bool Close_DateSpecified
		{
			get
			{
				return this.close_DateFieldSpecified;
			}
			set
			{
				this.close_DateFieldSpecified = value;
				this.RaisePropertyChanged("Close_DateSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public string Notes
		{
			get
			{
				return this.notesField;
			}
			set
			{
				this.notesField = value;
				this.RaisePropertyChanged("Notes");
			}
		}

		[XmlElement(Order = 11)]
		public bool Update_Opportunity_Only
		{
			get
			{
				return this.update_Opportunity_OnlyField;
			}
			set
			{
				this.update_Opportunity_OnlyField = value;
				this.RaisePropertyChanged("Update_Opportunity_Only");
			}
		}

		[XmlIgnore]
		public bool Update_Opportunity_OnlySpecified
		{
			get
			{
				return this.update_Opportunity_OnlyFieldSpecified;
			}
			set
			{
				this.update_Opportunity_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Update_Opportunity_OnlySpecified");
			}
		}

		[XmlElement("Opportunity_Line_Replacement_Data", Order = 12)]
		public Opportunity_Line_DataType[] Opportunity_Line_Replacement_Data
		{
			get
			{
				return this.opportunity_Line_Replacement_DataField;
			}
			set
			{
				this.opportunity_Line_Replacement_DataField = value;
				this.RaisePropertyChanged("Opportunity_Line_Replacement_Data");
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
