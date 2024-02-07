using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Contract_Contingent_Worker_Event_DataType : INotifyPropertyChanged
	{
		private string contingent_Worker_IDField;

		private string position_IDField;

		private Event_Classification_SubcategoryObjectType contract_Worker_Reason_ReferenceField;

		private Contingent_Worker_TypeObjectType contract_Worker_Type_ReferenceField;

		private bool create_Purchase_OrderField;

		private bool create_Purchase_OrderFieldSpecified;

		private DateTime contract_End_DateField;

		private bool contract_End_DateFieldSpecified;

		private DateTime first_Day_of_WorkField;

		private bool first_Day_of_WorkFieldSpecified;

		private DateTime conversion_Position_Start_DateField;

		private bool conversion_Position_Start_DateFieldSpecified;

		private object itemField;

		private Position_Details_Sub_DataType position_DetailsField;

		private Contract_Details_Sub_DataType[] contract_Details_DataField;

		private Worker_Document_for_Staffing_Event_DataType[] worker_Document_DataField;

		private Purchase_Order_Contract_Details_DataType purchase_Order_Contract_Details_DataField;

		private External_IDType[] contingent_Worker_External_ID_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Contingent_Worker_ID
		{
			get
			{
				return this.contingent_Worker_IDField;
			}
			set
			{
				this.contingent_Worker_IDField = value;
				this.RaisePropertyChanged("Contingent_Worker_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Position_ID
		{
			get
			{
				return this.position_IDField;
			}
			set
			{
				this.position_IDField = value;
				this.RaisePropertyChanged("Position_ID");
			}
		}

		[XmlElement(Order = 2)]
		public Event_Classification_SubcategoryObjectType Contract_Worker_Reason_Reference
		{
			get
			{
				return this.contract_Worker_Reason_ReferenceField;
			}
			set
			{
				this.contract_Worker_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Contract_Worker_Reason_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Contingent_Worker_TypeObjectType Contract_Worker_Type_Reference
		{
			get
			{
				return this.contract_Worker_Type_ReferenceField;
			}
			set
			{
				this.contract_Worker_Type_ReferenceField = value;
				this.RaisePropertyChanged("Contract_Worker_Type_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public bool Create_Purchase_Order
		{
			get
			{
				return this.create_Purchase_OrderField;
			}
			set
			{
				this.create_Purchase_OrderField = value;
				this.RaisePropertyChanged("Create_Purchase_Order");
			}
		}

		[XmlIgnore]
		public bool Create_Purchase_OrderSpecified
		{
			get
			{
				return this.create_Purchase_OrderFieldSpecified;
			}
			set
			{
				this.create_Purchase_OrderFieldSpecified = value;
				this.RaisePropertyChanged("Create_Purchase_OrderSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Contract_End_Date
		{
			get
			{
				return this.contract_End_DateField;
			}
			set
			{
				this.contract_End_DateField = value;
				this.RaisePropertyChanged("Contract_End_Date");
			}
		}

		[XmlIgnore]
		public bool Contract_End_DateSpecified
		{
			get
			{
				return this.contract_End_DateFieldSpecified;
			}
			set
			{
				this.contract_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Contract_End_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime First_Day_of_Work
		{
			get
			{
				return this.first_Day_of_WorkField;
			}
			set
			{
				this.first_Day_of_WorkField = value;
				this.RaisePropertyChanged("First_Day_of_Work");
			}
		}

		[XmlIgnore]
		public bool First_Day_of_WorkSpecified
		{
			get
			{
				return this.first_Day_of_WorkFieldSpecified;
			}
			set
			{
				this.first_Day_of_WorkFieldSpecified = value;
				this.RaisePropertyChanged("First_Day_of_WorkSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 7)]
		public DateTime Conversion_Position_Start_Date
		{
			get
			{
				return this.conversion_Position_Start_DateField;
			}
			set
			{
				this.conversion_Position_Start_DateField = value;
				this.RaisePropertyChanged("Conversion_Position_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Conversion_Position_Start_DateSpecified
		{
			get
			{
				return this.conversion_Position_Start_DateFieldSpecified;
			}
			set
			{
				this.conversion_Position_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Conversion_Position_Start_DateSpecified");
			}
		}

		[XmlElement("Default_Payment_Term_Reference", typeof(Payment_TermsObjectType), Order = 8), XmlElement("Supplier_Reference", typeof(SupplierObjectType), Order = 8)]
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

		[XmlElement(Order = 9)]
		public Position_Details_Sub_DataType Position_Details
		{
			get
			{
				return this.position_DetailsField;
			}
			set
			{
				this.position_DetailsField = value;
				this.RaisePropertyChanged("Position_Details");
			}
		}

		[XmlElement("Contract_Details_Data", Order = 10)]
		public Contract_Details_Sub_DataType[] Contract_Details_Data
		{
			get
			{
				return this.contract_Details_DataField;
			}
			set
			{
				this.contract_Details_DataField = value;
				this.RaisePropertyChanged("Contract_Details_Data");
			}
		}

		[XmlElement("Worker_Document_Data", Order = 11)]
		public Worker_Document_for_Staffing_Event_DataType[] Worker_Document_Data
		{
			get
			{
				return this.worker_Document_DataField;
			}
			set
			{
				this.worker_Document_DataField = value;
				this.RaisePropertyChanged("Worker_Document_Data");
			}
		}

		[XmlElement(Order = 12)]
		public Purchase_Order_Contract_Details_DataType Purchase_Order_Contract_Details_Data
		{
			get
			{
				return this.purchase_Order_Contract_Details_DataField;
			}
			set
			{
				this.purchase_Order_Contract_Details_DataField = value;
				this.RaisePropertyChanged("Purchase_Order_Contract_Details_Data");
			}
		}

		[XmlArray(Order = 13), XmlArrayItem("External_ID", IsNullable = false)]
		public External_IDType[] Contingent_Worker_External_ID_Data
		{
			get
			{
				return this.contingent_Worker_External_ID_DataField;
			}
			set
			{
				this.contingent_Worker_External_ID_DataField = value;
				this.RaisePropertyChanged("Contingent_Worker_External_ID_Data");
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
