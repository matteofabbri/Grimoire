using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Custom_Validation_Rule_DataType : INotifyPropertyChanged
	{
		private string custom_Validation_Rule_IDField;

		private string custom_Validation_Rule_for_TransactionField;

		private string custom_Validation_Rule_ClassificationField;

		private Custom_Validation_DataType[] custom_Validation_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Custom_Validation_Rule_ID
		{
			get
			{
				return this.custom_Validation_Rule_IDField;
			}
			set
			{
				this.custom_Validation_Rule_IDField = value;
				this.RaisePropertyChanged("Custom_Validation_Rule_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Custom_Validation_Rule_for_Transaction
		{
			get
			{
				return this.custom_Validation_Rule_for_TransactionField;
			}
			set
			{
				this.custom_Validation_Rule_for_TransactionField = value;
				this.RaisePropertyChanged("Custom_Validation_Rule_for_Transaction");
			}
		}

		[XmlElement(Order = 2)]
		public string Custom_Validation_Rule_Classification
		{
			get
			{
				return this.custom_Validation_Rule_ClassificationField;
			}
			set
			{
				this.custom_Validation_Rule_ClassificationField = value;
				this.RaisePropertyChanged("Custom_Validation_Rule_Classification");
			}
		}

		[XmlElement("Custom_Validation_Data", Order = 3)]
		public Custom_Validation_DataType[] Custom_Validation_Data
		{
			get
			{
				return this.custom_Validation_DataField;
			}
			set
			{
				this.custom_Validation_DataField = value;
				this.RaisePropertyChanged("Custom_Validation_Data");
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
