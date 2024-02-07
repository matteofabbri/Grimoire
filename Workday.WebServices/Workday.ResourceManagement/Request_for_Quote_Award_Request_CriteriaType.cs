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
	public class Request_for_Quote_Award_Request_CriteriaType : INotifyPropertyChanged
	{
		private CompanyObjectType company_ReferenceField;

		private Request_for_QuoteObjectType request_for_Quote_ReferenceField;

		private Request_for_Quote_Award_TypeObjectType rFQ_Award_Type_ReferenceField;

		private Document_StatusObjectType rFQ_Award_Status_ReferenceField;

		private DateTime rFQ_Award_Date_On_or_BeforeField;

		private bool rFQ_Award_Date_On_or_BeforeFieldSpecified;

		private DateTime rFQ_Award_Date_On_or_AfterField;

		private bool rFQ_Award_Date_On_or_AfterFieldSpecified;

		private Abstract_Request_for_Quote_ParticipantObjectType supplier_ReferenceField;

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
		public Request_for_QuoteObjectType Request_for_Quote_Reference
		{
			get
			{
				return this.request_for_Quote_ReferenceField;
			}
			set
			{
				this.request_for_Quote_ReferenceField = value;
				this.RaisePropertyChanged("Request_for_Quote_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Request_for_Quote_Award_TypeObjectType RFQ_Award_Type_Reference
		{
			get
			{
				return this.rFQ_Award_Type_ReferenceField;
			}
			set
			{
				this.rFQ_Award_Type_ReferenceField = value;
				this.RaisePropertyChanged("RFQ_Award_Type_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Document_StatusObjectType RFQ_Award_Status_Reference
		{
			get
			{
				return this.rFQ_Award_Status_ReferenceField;
			}
			set
			{
				this.rFQ_Award_Status_ReferenceField = value;
				this.RaisePropertyChanged("RFQ_Award_Status_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime RFQ_Award_Date_On_or_Before
		{
			get
			{
				return this.rFQ_Award_Date_On_or_BeforeField;
			}
			set
			{
				this.rFQ_Award_Date_On_or_BeforeField = value;
				this.RaisePropertyChanged("RFQ_Award_Date_On_or_Before");
			}
		}

		[XmlIgnore]
		public bool RFQ_Award_Date_On_or_BeforeSpecified
		{
			get
			{
				return this.rFQ_Award_Date_On_or_BeforeFieldSpecified;
			}
			set
			{
				this.rFQ_Award_Date_On_or_BeforeFieldSpecified = value;
				this.RaisePropertyChanged("RFQ_Award_Date_On_or_BeforeSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime RFQ_Award_Date_On_or_After
		{
			get
			{
				return this.rFQ_Award_Date_On_or_AfterField;
			}
			set
			{
				this.rFQ_Award_Date_On_or_AfterField = value;
				this.RaisePropertyChanged("RFQ_Award_Date_On_or_After");
			}
		}

		[XmlIgnore]
		public bool RFQ_Award_Date_On_or_AfterSpecified
		{
			get
			{
				return this.rFQ_Award_Date_On_or_AfterFieldSpecified;
			}
			set
			{
				this.rFQ_Award_Date_On_or_AfterFieldSpecified = value;
				this.RaisePropertyChanged("RFQ_Award_Date_On_or_AfterSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public Abstract_Request_for_Quote_ParticipantObjectType Supplier_Reference
		{
			get
			{
				return this.supplier_ReferenceField;
			}
			set
			{
				this.supplier_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Reference");
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
