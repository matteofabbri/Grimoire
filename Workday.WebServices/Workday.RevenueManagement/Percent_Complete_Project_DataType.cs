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
	public class Percent_Complete_Project_DataType : INotifyPropertyChanged
	{
		private string idField;

		private Unique_IdentifierObjectType as_Of_Date_ReferenceField;

		private Percent_Complete_MethodObjectType percent_Complete_Method_ReferenceField;

		private Document_StatusObjectType percent_Complete_Status_ReferenceField;

		private Project_AbstractObjectType billable_Project_ReferenceField;

		private Billable_EntityObjectType sold_To_Customer_ReferenceField;

		private decimal contract_ValueField;

		private bool contract_ValueFieldSpecified;

		private Percent_Complete_Line_DataType[] percent_Complete_Line_DataField;

		private Receivable_Contract_Line_AbstractObjectType[] customer_Contract_Line_ReferenceField;

		private Resource_ForecastObjectType forecast_Snapshot_ReferenceField;

		private decimal estimated_Hours_to_CompleteField;

		private bool estimated_Hours_to_CompleteFieldSpecified;

		private decimal cumulative_Hours_WorkedField;

		private bool cumulative_Hours_WorkedFieldSpecified;

		private decimal estimated_CostField;

		private bool estimated_CostFieldSpecified;

		private decimal actual_CostField;

		private bool actual_CostFieldSpecified;

		private decimal actual_Percent_CompleteField;

		private CurrencyObjectType currency_ReferenceField;

		private string noteField;

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
		public Unique_IdentifierObjectType As_Of_Date_Reference
		{
			get
			{
				return this.as_Of_Date_ReferenceField;
			}
			set
			{
				this.as_Of_Date_ReferenceField = value;
				this.RaisePropertyChanged("As_Of_Date_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Percent_Complete_MethodObjectType Percent_Complete_Method_Reference
		{
			get
			{
				return this.percent_Complete_Method_ReferenceField;
			}
			set
			{
				this.percent_Complete_Method_ReferenceField = value;
				this.RaisePropertyChanged("Percent_Complete_Method_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Document_StatusObjectType Percent_Complete_Status_Reference
		{
			get
			{
				return this.percent_Complete_Status_ReferenceField;
			}
			set
			{
				this.percent_Complete_Status_ReferenceField = value;
				this.RaisePropertyChanged("Percent_Complete_Status_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Project_AbstractObjectType Billable_Project_Reference
		{
			get
			{
				return this.billable_Project_ReferenceField;
			}
			set
			{
				this.billable_Project_ReferenceField = value;
				this.RaisePropertyChanged("Billable_Project_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Billable_EntityObjectType Sold_To_Customer_Reference
		{
			get
			{
				return this.sold_To_Customer_ReferenceField;
			}
			set
			{
				this.sold_To_Customer_ReferenceField = value;
				this.RaisePropertyChanged("Sold_To_Customer_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Contract_Value
		{
			get
			{
				return this.contract_ValueField;
			}
			set
			{
				this.contract_ValueField = value;
				this.RaisePropertyChanged("Contract_Value");
			}
		}

		[XmlIgnore]
		public bool Contract_ValueSpecified
		{
			get
			{
				return this.contract_ValueFieldSpecified;
			}
			set
			{
				this.contract_ValueFieldSpecified = value;
				this.RaisePropertyChanged("Contract_ValueSpecified");
			}
		}

		[XmlElement("Percent_Complete_Line_Data", Order = 7)]
		public Percent_Complete_Line_DataType[] Percent_Complete_Line_Data
		{
			get
			{
				return this.percent_Complete_Line_DataField;
			}
			set
			{
				this.percent_Complete_Line_DataField = value;
				this.RaisePropertyChanged("Percent_Complete_Line_Data");
			}
		}

		[XmlElement("Customer_Contract_Line_Reference", Order = 8)]
		public Receivable_Contract_Line_AbstractObjectType[] Customer_Contract_Line_Reference
		{
			get
			{
				return this.customer_Contract_Line_ReferenceField;
			}
			set
			{
				this.customer_Contract_Line_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Contract_Line_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public Resource_ForecastObjectType Forecast_Snapshot_Reference
		{
			get
			{
				return this.forecast_Snapshot_ReferenceField;
			}
			set
			{
				this.forecast_Snapshot_ReferenceField = value;
				this.RaisePropertyChanged("Forecast_Snapshot_Reference");
			}
		}

		[XmlElement(Order = 10)]
		public decimal Estimated_Hours_to_Complete
		{
			get
			{
				return this.estimated_Hours_to_CompleteField;
			}
			set
			{
				this.estimated_Hours_to_CompleteField = value;
				this.RaisePropertyChanged("Estimated_Hours_to_Complete");
			}
		}

		[XmlIgnore]
		public bool Estimated_Hours_to_CompleteSpecified
		{
			get
			{
				return this.estimated_Hours_to_CompleteFieldSpecified;
			}
			set
			{
				this.estimated_Hours_to_CompleteFieldSpecified = value;
				this.RaisePropertyChanged("Estimated_Hours_to_CompleteSpecified");
			}
		}

		[XmlElement(Order = 11)]
		public decimal Cumulative_Hours_Worked
		{
			get
			{
				return this.cumulative_Hours_WorkedField;
			}
			set
			{
				this.cumulative_Hours_WorkedField = value;
				this.RaisePropertyChanged("Cumulative_Hours_Worked");
			}
		}

		[XmlIgnore]
		public bool Cumulative_Hours_WorkedSpecified
		{
			get
			{
				return this.cumulative_Hours_WorkedFieldSpecified;
			}
			set
			{
				this.cumulative_Hours_WorkedFieldSpecified = value;
				this.RaisePropertyChanged("Cumulative_Hours_WorkedSpecified");
			}
		}

		[XmlElement(Order = 12)]
		public decimal Estimated_Cost
		{
			get
			{
				return this.estimated_CostField;
			}
			set
			{
				this.estimated_CostField = value;
				this.RaisePropertyChanged("Estimated_Cost");
			}
		}

		[XmlIgnore]
		public bool Estimated_CostSpecified
		{
			get
			{
				return this.estimated_CostFieldSpecified;
			}
			set
			{
				this.estimated_CostFieldSpecified = value;
				this.RaisePropertyChanged("Estimated_CostSpecified");
			}
		}

		[XmlElement(Order = 13)]
		public decimal Actual_Cost
		{
			get
			{
				return this.actual_CostField;
			}
			set
			{
				this.actual_CostField = value;
				this.RaisePropertyChanged("Actual_Cost");
			}
		}

		[XmlIgnore]
		public bool Actual_CostSpecified
		{
			get
			{
				return this.actual_CostFieldSpecified;
			}
			set
			{
				this.actual_CostFieldSpecified = value;
				this.RaisePropertyChanged("Actual_CostSpecified");
			}
		}

		[XmlElement(Order = 14)]
		public decimal Actual_Percent_Complete
		{
			get
			{
				return this.actual_Percent_CompleteField;
			}
			set
			{
				this.actual_Percent_CompleteField = value;
				this.RaisePropertyChanged("Actual_Percent_Complete");
			}
		}

		[XmlElement(Order = 15)]
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

		[XmlElement(Order = 16)]
		public string Note
		{
			get
			{
				return this.noteField;
			}
			set
			{
				this.noteField = value;
				this.RaisePropertyChanged("Note");
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
