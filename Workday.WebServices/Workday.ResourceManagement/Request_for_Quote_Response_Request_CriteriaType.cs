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
	public class Request_for_Quote_Response_Request_CriteriaType : INotifyPropertyChanged
	{
		private CompanyObjectType company_ReferenceField;

		private Request_for_QuoteObjectType rFQ_ReferenceField;

		private Abstract_Request_for_Quote_ParticipantObjectType supplier_ReferenceField;

		private DateTime response_Date_On_or_AfterField;

		private bool response_Date_On_or_AfterFieldSpecified;

		private DateTime response_Date_On_or_BeforeField;

		private bool response_Date_On_or_BeforeFieldSpecified;

		private Document_StatusObjectType rFQ_Response_Status_ReferenceField;

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
		public Request_for_QuoteObjectType RFQ_Reference
		{
			get
			{
				return this.rFQ_ReferenceField;
			}
			set
			{
				this.rFQ_ReferenceField = value;
				this.RaisePropertyChanged("RFQ_Reference");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Response_Date_On_or_After
		{
			get
			{
				return this.response_Date_On_or_AfterField;
			}
			set
			{
				this.response_Date_On_or_AfterField = value;
				this.RaisePropertyChanged("Response_Date_On_or_After");
			}
		}

		[XmlIgnore]
		public bool Response_Date_On_or_AfterSpecified
		{
			get
			{
				return this.response_Date_On_or_AfterFieldSpecified;
			}
			set
			{
				this.response_Date_On_or_AfterFieldSpecified = value;
				this.RaisePropertyChanged("Response_Date_On_or_AfterSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Response_Date_On_or_Before
		{
			get
			{
				return this.response_Date_On_or_BeforeField;
			}
			set
			{
				this.response_Date_On_or_BeforeField = value;
				this.RaisePropertyChanged("Response_Date_On_or_Before");
			}
		}

		[XmlIgnore]
		public bool Response_Date_On_or_BeforeSpecified
		{
			get
			{
				return this.response_Date_On_or_BeforeFieldSpecified;
			}
			set
			{
				this.response_Date_On_or_BeforeFieldSpecified = value;
				this.RaisePropertyChanged("Response_Date_On_or_BeforeSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public Document_StatusObjectType RFQ_Response_Status_Reference
		{
			get
			{
				return this.rFQ_Response_Status_ReferenceField;
			}
			set
			{
				this.rFQ_Response_Status_ReferenceField = value;
				this.RaisePropertyChanged("RFQ_Response_Status_Reference");
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
