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
	public class RFQ_Header_Or_Line_Bid_Response_Data_InboundType : INotifyPropertyChanged
	{
		private Abstract_Request_for_Quote_Bid_RequirementObjectType rFQ_Bid_Requirement_ReferenceField;

		private DateTime date_ResponseField;

		private bool date_ResponseFieldSpecified;

		private decimal numeric_ResponseField;

		private bool numeric_ResponseFieldSpecified;

		private string text_ResponseField;

		private bool boolean_Yes_ResponseField;

		private bool boolean_Yes_ResponseFieldSpecified;

		private bool boolean_No_ResponseField;

		private bool boolean_No_ResponseFieldSpecified;

		private string bid_Response_MemoField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Date_Response
		{
			get
			{
				return this.date_ResponseField;
			}
			set
			{
				this.date_ResponseField = value;
				this.RaisePropertyChanged("Date_Response");
			}
		}

		[XmlIgnore]
		public bool Date_ResponseSpecified
		{
			get
			{
				return this.date_ResponseFieldSpecified;
			}
			set
			{
				this.date_ResponseFieldSpecified = value;
				this.RaisePropertyChanged("Date_ResponseSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Numeric_Response
		{
			get
			{
				return this.numeric_ResponseField;
			}
			set
			{
				this.numeric_ResponseField = value;
				this.RaisePropertyChanged("Numeric_Response");
			}
		}

		[XmlIgnore]
		public bool Numeric_ResponseSpecified
		{
			get
			{
				return this.numeric_ResponseFieldSpecified;
			}
			set
			{
				this.numeric_ResponseFieldSpecified = value;
				this.RaisePropertyChanged("Numeric_ResponseSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public string Text_Response
		{
			get
			{
				return this.text_ResponseField;
			}
			set
			{
				this.text_ResponseField = value;
				this.RaisePropertyChanged("Text_Response");
			}
		}

		[XmlElement(Order = 4)]
		public bool Boolean_Yes_Response
		{
			get
			{
				return this.boolean_Yes_ResponseField;
			}
			set
			{
				this.boolean_Yes_ResponseField = value;
				this.RaisePropertyChanged("Boolean_Yes_Response");
			}
		}

		[XmlIgnore]
		public bool Boolean_Yes_ResponseSpecified
		{
			get
			{
				return this.boolean_Yes_ResponseFieldSpecified;
			}
			set
			{
				this.boolean_Yes_ResponseFieldSpecified = value;
				this.RaisePropertyChanged("Boolean_Yes_ResponseSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool Boolean_No_Response
		{
			get
			{
				return this.boolean_No_ResponseField;
			}
			set
			{
				this.boolean_No_ResponseField = value;
				this.RaisePropertyChanged("Boolean_No_Response");
			}
		}

		[XmlIgnore]
		public bool Boolean_No_ResponseSpecified
		{
			get
			{
				return this.boolean_No_ResponseFieldSpecified;
			}
			set
			{
				this.boolean_No_ResponseFieldSpecified = value;
				this.RaisePropertyChanged("Boolean_No_ResponseSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public string Bid_Response_Memo
		{
			get
			{
				return this.bid_Response_MemoField;
			}
			set
			{
				this.bid_Response_MemoField = value;
				this.RaisePropertyChanged("Bid_Response_Memo");
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
