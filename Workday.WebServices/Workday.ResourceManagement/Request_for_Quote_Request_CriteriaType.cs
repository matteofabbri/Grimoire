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
	public class Request_for_Quote_Request_CriteriaType : INotifyPropertyChanged
	{
		private CompanyObjectType company_ReferenceField;

		private Request_for_Quote_TypeObjectType rFQ_Type_ReferenceField;

		private DateTime document_DateField;

		private bool document_DateFieldSpecified;

		private DateTime rFQ_Start_Date_On_or_AfterField;

		private bool rFQ_Start_Date_On_or_AfterFieldSpecified;

		private DateTime rFQ_Start_Date_On_or_BeforeField;

		private bool rFQ_Start_Date_On_or_BeforeFieldSpecified;

		private DateTime rFQ_End_Date_On_or_AfterField;

		private bool rFQ_End_Date_On_or_AfterFieldSpecified;

		private DateTime rFQ_End_Date_On_or_BeforeField;

		private bool rFQ_End_Date_On_or_BeforeFieldSpecified;

		private WorkerObjectType sourcing_Buyer_ReferenceField;

		private Document_StatusObjectType[] rFQ_Status_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
		public Request_for_Quote_TypeObjectType RFQ_Type_Reference
		{
			get
			{
				return this.rFQ_Type_ReferenceField;
			}
			set
			{
				this.rFQ_Type_ReferenceField = value;
				this.RaisePropertyChanged("RFQ_Type_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Document_Date
		{
			get
			{
				return this.document_DateField;
			}
			set
			{
				this.document_DateField = value;
				this.RaisePropertyChanged("Document_Date");
			}
		}

		[XmlIgnore]
		public bool Document_DateSpecified
		{
			get
			{
				return this.document_DateFieldSpecified;
			}
			set
			{
				this.document_DateFieldSpecified = value;
				this.RaisePropertyChanged("Document_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime RFQ_Start_Date_On_or_After
		{
			get
			{
				return this.rFQ_Start_Date_On_or_AfterField;
			}
			set
			{
				this.rFQ_Start_Date_On_or_AfterField = value;
				this.RaisePropertyChanged("RFQ_Start_Date_On_or_After");
			}
		}

		[XmlIgnore]
		public bool RFQ_Start_Date_On_or_AfterSpecified
		{
			get
			{
				return this.rFQ_Start_Date_On_or_AfterFieldSpecified;
			}
			set
			{
				this.rFQ_Start_Date_On_or_AfterFieldSpecified = value;
				this.RaisePropertyChanged("RFQ_Start_Date_On_or_AfterSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime RFQ_Start_Date_On_or_Before
		{
			get
			{
				return this.rFQ_Start_Date_On_or_BeforeField;
			}
			set
			{
				this.rFQ_Start_Date_On_or_BeforeField = value;
				this.RaisePropertyChanged("RFQ_Start_Date_On_or_Before");
			}
		}

		[XmlIgnore]
		public bool RFQ_Start_Date_On_or_BeforeSpecified
		{
			get
			{
				return this.rFQ_Start_Date_On_or_BeforeFieldSpecified;
			}
			set
			{
				this.rFQ_Start_Date_On_or_BeforeFieldSpecified = value;
				this.RaisePropertyChanged("RFQ_Start_Date_On_or_BeforeSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime RFQ_End_Date_On_or_After
		{
			get
			{
				return this.rFQ_End_Date_On_or_AfterField;
			}
			set
			{
				this.rFQ_End_Date_On_or_AfterField = value;
				this.RaisePropertyChanged("RFQ_End_Date_On_or_After");
			}
		}

		[XmlIgnore]
		public bool RFQ_End_Date_On_or_AfterSpecified
		{
			get
			{
				return this.rFQ_End_Date_On_or_AfterFieldSpecified;
			}
			set
			{
				this.rFQ_End_Date_On_or_AfterFieldSpecified = value;
				this.RaisePropertyChanged("RFQ_End_Date_On_or_AfterSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime RFQ_End_Date_On_or_Before
		{
			get
			{
				return this.rFQ_End_Date_On_or_BeforeField;
			}
			set
			{
				this.rFQ_End_Date_On_or_BeforeField = value;
				this.RaisePropertyChanged("RFQ_End_Date_On_or_Before");
			}
		}

		[XmlIgnore]
		public bool RFQ_End_Date_On_or_BeforeSpecified
		{
			get
			{
				return this.rFQ_End_Date_On_or_BeforeFieldSpecified;
			}
			set
			{
				this.rFQ_End_Date_On_or_BeforeFieldSpecified = value;
				this.RaisePropertyChanged("RFQ_End_Date_On_or_BeforeSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public WorkerObjectType Sourcing_Buyer_Reference
		{
			get
			{
				return this.sourcing_Buyer_ReferenceField;
			}
			set
			{
				this.sourcing_Buyer_ReferenceField = value;
				this.RaisePropertyChanged("Sourcing_Buyer_Reference");
			}
		}

		[XmlElement("RFQ_Status_Reference", Order = 8)]
		public Document_StatusObjectType[] RFQ_Status_Reference
		{
			get
			{
				return this.rFQ_Status_ReferenceField;
			}
			set
			{
				this.rFQ_Status_ReferenceField = value;
				this.RaisePropertyChanged("RFQ_Status_Reference");
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
