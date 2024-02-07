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
	public class Basis_Limit_Edit_DataType : INotifyPropertyChanged
	{
		private string basis_Limit_NameField;

		private decimal basis_Limit_AmountField;

		private bool basis_Limit_AmountFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Basis_Limit_Name
		{
			get
			{
				return this.basis_Limit_NameField;
			}
			set
			{
				this.basis_Limit_NameField = value;
				this.RaisePropertyChanged("Basis_Limit_Name");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Basis_Limit_Amount
		{
			get
			{
				return this.basis_Limit_AmountField;
			}
			set
			{
				this.basis_Limit_AmountField = value;
				this.RaisePropertyChanged("Basis_Limit_Amount");
			}
		}

		[XmlIgnore]
		public bool Basis_Limit_AmountSpecified
		{
			get
			{
				return this.basis_Limit_AmountFieldSpecified;
			}
			set
			{
				this.basis_Limit_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Basis_Limit_AmountSpecified");
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
