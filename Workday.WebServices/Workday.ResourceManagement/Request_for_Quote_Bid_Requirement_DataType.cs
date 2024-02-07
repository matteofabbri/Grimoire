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
	public class Request_for_Quote_Bid_Requirement_DataType : INotifyPropertyChanged
	{
		private decimal sequence_NumberField;

		private string nameField;

		private Request_for_Quote_Bid_Requirement_TypeObjectType type_ReferenceField;

		private bool response_RequiredField;

		private bool response_RequiredFieldSpecified;

		private Request_for_Quote_Bid_Requirement_ClassificationObjectType request_for_Quote_Bid_Requirement_Classification_ReferenceField;

		private string memoField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Sequence_Number
		{
			get
			{
				return this.sequence_NumberField;
			}
			set
			{
				this.sequence_NumberField = value;
				this.RaisePropertyChanged("Sequence_Number");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
		public Request_for_Quote_Bid_Requirement_ClassificationObjectType Request_for_Quote_Bid_Requirement_Classification_Reference
		{
			get
			{
				return this.request_for_Quote_Bid_Requirement_Classification_ReferenceField;
			}
			set
			{
				this.request_for_Quote_Bid_Requirement_Classification_ReferenceField = value;
				this.RaisePropertyChanged("Request_for_Quote_Bid_Requirement_Classification_Reference");
			}
		}

		[XmlElement(Order = 5)]
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
