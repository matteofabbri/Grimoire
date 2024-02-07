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
	public class Ledger_Account_Range_DataType : INotifyPropertyChanged
	{
		private string from_ValueField;

		private string to_ValueField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string From_Value
		{
			get
			{
				return this.from_ValueField;
			}
			set
			{
				this.from_ValueField = value;
				this.RaisePropertyChanged("From_Value");
			}
		}

		[XmlElement(Order = 1)]
		public string To_Value
		{
			get
			{
				return this.to_ValueField;
			}
			set
			{
				this.to_ValueField = value;
				this.RaisePropertyChanged("To_Value");
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
