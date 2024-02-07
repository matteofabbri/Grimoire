using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialAid
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Imported_FA_Package_-_Student_Sponsor_Contract_Line_DataType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Imported_FA_Package__Student_Sponsor_Contract_Line_DataType : INotifyPropertyChanged
	{
		private string idField;

		private decimal contract_Line_AmountField;

		private bool contract_Line_AmountFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Contract_Line_Amount
		{
			get
			{
				return this.contract_Line_AmountField;
			}
			set
			{
				this.contract_Line_AmountField = value;
				this.RaisePropertyChanged("Contract_Line_Amount");
			}
		}

		[XmlIgnore]
		public bool Contract_Line_AmountSpecified
		{
			get
			{
				return this.contract_Line_AmountFieldSpecified;
			}
			set
			{
				this.contract_Line_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Contract_Line_AmountSpecified");
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
