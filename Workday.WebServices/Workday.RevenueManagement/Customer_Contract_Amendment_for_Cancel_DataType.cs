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
	public class Customer_Contract_Amendment_for_Cancel_DataType : INotifyPropertyChanged
	{
		private Contract_Amendment_TypeObjectType contract_Amendment_Type_ReferenceField;

		private DateTime amendment_Effective_DateField;

		private DateTime amendment_Signed_DateField;

		private bool amendment_Signed_DateFieldSpecified;

		private string amendment_NumberField;

		private Document_StatusObjectType document_Status_ReferenceField;

		private string amendment_DescriptionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Contract_Amendment_TypeObjectType Contract_Amendment_Type_Reference
		{
			get
			{
				return this.contract_Amendment_Type_ReferenceField;
			}
			set
			{
				this.contract_Amendment_Type_ReferenceField = value;
				this.RaisePropertyChanged("Contract_Amendment_Type_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Amendment_Effective_Date
		{
			get
			{
				return this.amendment_Effective_DateField;
			}
			set
			{
				this.amendment_Effective_DateField = value;
				this.RaisePropertyChanged("Amendment_Effective_Date");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Amendment_Signed_Date
		{
			get
			{
				return this.amendment_Signed_DateField;
			}
			set
			{
				this.amendment_Signed_DateField = value;
				this.RaisePropertyChanged("Amendment_Signed_Date");
			}
		}

		[XmlIgnore]
		public bool Amendment_Signed_DateSpecified
		{
			get
			{
				return this.amendment_Signed_DateFieldSpecified;
			}
			set
			{
				this.amendment_Signed_DateFieldSpecified = value;
				this.RaisePropertyChanged("Amendment_Signed_DateSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public string Amendment_Number
		{
			get
			{
				return this.amendment_NumberField;
			}
			set
			{
				this.amendment_NumberField = value;
				this.RaisePropertyChanged("Amendment_Number");
			}
		}

		[XmlElement(Order = 4)]
		public Document_StatusObjectType Document_Status_Reference
		{
			get
			{
				return this.document_Status_ReferenceField;
			}
			set
			{
				this.document_Status_ReferenceField = value;
				this.RaisePropertyChanged("Document_Status_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public string Amendment_Description
		{
			get
			{
				return this.amendment_DescriptionField;
			}
			set
			{
				this.amendment_DescriptionField = value;
				this.RaisePropertyChanged("Amendment_Description");
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
