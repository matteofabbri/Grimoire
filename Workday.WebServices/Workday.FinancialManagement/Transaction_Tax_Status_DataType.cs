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
	public class Transaction_Tax_Status_DataType : INotifyPropertyChanged
	{
		private string transaction_Tax_Status_IDField;

		private string transaction_Tax_Status_NameField;

		private string descriptionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Transaction_Tax_Status_ID
		{
			get
			{
				return this.transaction_Tax_Status_IDField;
			}
			set
			{
				this.transaction_Tax_Status_IDField = value;
				this.RaisePropertyChanged("Transaction_Tax_Status_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Transaction_Tax_Status_Name
		{
			get
			{
				return this.transaction_Tax_Status_NameField;
			}
			set
			{
				this.transaction_Tax_Status_NameField = value;
				this.RaisePropertyChanged("Transaction_Tax_Status_Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("Description");
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
