using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialAid
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Status_for_ISIR_TransactionType : INotifyPropertyChanged
	{
		private ISIR_TransactionObjectType iSIR_Transaction_ReferenceField;

		private Status_for_ISIR_Transaction_DataType[] status_for_ISIR_Transaction_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public ISIR_TransactionObjectType ISIR_Transaction_Reference
		{
			get
			{
				return this.iSIR_Transaction_ReferenceField;
			}
			set
			{
				this.iSIR_Transaction_ReferenceField = value;
				this.RaisePropertyChanged("ISIR_Transaction_Reference");
			}
		}

		[XmlElement("Status_for_ISIR_Transaction_Data", Order = 1)]
		public Status_for_ISIR_Transaction_DataType[] Status_for_ISIR_Transaction_Data
		{
			get
			{
				return this.status_for_ISIR_Transaction_DataField;
			}
			set
			{
				this.status_for_ISIR_Transaction_DataField = value;
				this.RaisePropertyChanged("Status_for_ISIR_Transaction_Data");
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
