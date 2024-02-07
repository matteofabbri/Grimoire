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
	public class Beginning_Balance_JournalType : INotifyPropertyChanged
	{
		private Accounting_JournalObjectType beginning_Balance_Journal_ReferenceField;

		private Beginning_Balance_Journal_DataType[] beginning_Balance_Journal_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Accounting_JournalObjectType Beginning_Balance_Journal_Reference
		{
			get
			{
				return this.beginning_Balance_Journal_ReferenceField;
			}
			set
			{
				this.beginning_Balance_Journal_ReferenceField = value;
				this.RaisePropertyChanged("Beginning_Balance_Journal_Reference");
			}
		}

		[XmlElement("Beginning_Balance_Journal_Data", Order = 1)]
		public Beginning_Balance_Journal_DataType[] Beginning_Balance_Journal_Data
		{
			get
			{
				return this.beginning_Balance_Journal_DataField;
			}
			set
			{
				this.beginning_Balance_Journal_DataField = value;
				this.RaisePropertyChanged("Beginning_Balance_Journal_Data");
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
