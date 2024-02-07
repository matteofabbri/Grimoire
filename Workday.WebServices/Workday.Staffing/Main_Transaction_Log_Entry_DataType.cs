using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Main_Transaction_Log_Entry_DataType : INotifyPropertyChanged
	{
		private Transaction_LogObjectType transaction_Log_ReferenceField;

		private Transaction_Log_DataType transaction_Log_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Transaction_LogObjectType Transaction_Log_Reference
		{
			get
			{
				return this.transaction_Log_ReferenceField;
			}
			set
			{
				this.transaction_Log_ReferenceField = value;
				this.RaisePropertyChanged("Transaction_Log_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Transaction_Log_DataType Transaction_Log_Data
		{
			get
			{
				return this.transaction_Log_DataField;
			}
			set
			{
				this.transaction_Log_DataField = value;
				this.RaisePropertyChanged("Transaction_Log_Data");
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
