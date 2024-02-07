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
	public class RFQ_Header_or_Line_Bid_Response_DataType : INotifyPropertyChanged
	{
		private Abstract_Request_for_Quote_Bid_ResponseObjectType rFQ_Bid_Response_ReferenceField;

		private Abstract_Request_for_Quote_Bid_RequirementObjectType rFQ_Bid_Requirement_ReferenceField;

		private string nameField;

		private string memoField;

		private bool response_RequiredField;

		private bool response_RequiredFieldSpecified;

		private Request_for_Quote_Bid_Requirement_TypeObjectType type_ReferenceField;

		private string response_ValueField;

		private string request_for_Quote_Bid_Response_MemoField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Abstract_Request_for_Quote_Bid_ResponseObjectType RFQ_Bid_Response_Reference
		{
			get
			{
				return this.rFQ_Bid_Response_ReferenceField;
			}
			set
			{
				this.rFQ_Bid_Response_ReferenceField = value;
				this.RaisePropertyChanged("RFQ_Bid_Response_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Abstract_Request_for_Quote_Bid_RequirementObjectType RFQ_Bid_Requirement_Reference
		{
			get
			{
				return this.rFQ_Bid_Requirement_ReferenceField;
			}
			set
			{
				this.rFQ_Bid_Requirement_ReferenceField = value;
				this.RaisePropertyChanged("RFQ_Bid_Requirement_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("Name");
			}
		}

		[XmlElement(Order = 3)]
		public string Memo
		{
			get
			{
				return this.memoField;
			}
			set
			{
				this.memoField = value;
				this.RaisePropertyChanged("Memo");
			}
		}

		[XmlElement(Order = 4)]
		public bool Response_Required
		{
			get
			{
				return this.response_RequiredField;
			}
			set
			{
				this.response_RequiredField = value;
				this.RaisePropertyChanged("Response_Required");
			}
		}

		[XmlIgnore]
		public bool Response_RequiredSpecified
		{
			get
			{
				return this.response_RequiredFieldSpecified;
			}
			set
			{
				this.response_RequiredFieldSpecified = value;
				this.RaisePropertyChanged("Response_RequiredSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public Request_for_Quote_Bid_Requirement_TypeObjectType Type_Reference
		{
			get
			{
				return this.type_ReferenceField;
			}
			set
			{
				this.type_ReferenceField = value;
				this.RaisePropertyChanged("Type_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public string Response_Value
		{
			get
			{
				return this.response_ValueField;
			}
			set
			{
				this.response_ValueField = value;
				this.RaisePropertyChanged("Response_Value");
			}
		}

		[XmlElement(Order = 7)]
		public string Request_for_Quote_Bid_Response_Memo
		{
			get
			{
				return this.request_for_Quote_Bid_Response_MemoField;
			}
			set
			{
				this.request_for_Quote_Bid_Response_MemoField = value;
				this.RaisePropertyChanged("Request_for_Quote_Bid_Response_Memo");
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
