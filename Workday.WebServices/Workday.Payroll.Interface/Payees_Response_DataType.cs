using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payees_Response_DataType : INotifyPropertyChanged
	{
		private External_Pay_GroupType[] external_Pay_GroupField;

		private Period_Content_DataType period_Content_DataField;

		private PayeeType[] payeeField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("External_Pay_Group", Order = 0)]
		public External_Pay_GroupType[] External_Pay_Group
		{
			get
			{
				return this.external_Pay_GroupField;
			}
			set
			{
				this.external_Pay_GroupField = value;
				this.RaisePropertyChanged("External_Pay_Group");
			}
		}

		[XmlElement(Order = 1)]
		public Period_Content_DataType Period_Content_Data
		{
			get
			{
				return this.period_Content_DataField;
			}
			set
			{
				this.period_Content_DataField = value;
				this.RaisePropertyChanged("Period_Content_Data");
			}
		}

		[XmlElement("Payee", Order = 2)]
		public PayeeType[] Payee
		{
			get
			{
				return this.payeeField;
			}
			set
			{
				this.payeeField = value;
				this.RaisePropertyChanged("Payee");
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
