using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.CashManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Intraday_Bank_StatementType : INotifyPropertyChanged
	{
		private Intraday_Bank_StatementObjectType intraday_Bank_Statement_ReferenceField;

		private Intraday_Bank_Statement_DataType[] intraday_Bank_Statement_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Intraday_Bank_StatementObjectType Intraday_Bank_Statement_Reference
		{
			get
			{
				return this.intraday_Bank_Statement_ReferenceField;
			}
			set
			{
				this.intraday_Bank_Statement_ReferenceField = value;
				this.RaisePropertyChanged("Intraday_Bank_Statement_Reference");
			}
		}

		[XmlElement("Intraday_Bank_Statement_Data", Order = 1)]
		public Intraday_Bank_Statement_DataType[] Intraday_Bank_Statement_Data
		{
			get
			{
				return this.intraday_Bank_Statement_DataField;
			}
			set
			{
				this.intraday_Bank_Statement_DataField = value;
				this.RaisePropertyChanged("Intraday_Bank_Statement_Data");
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
